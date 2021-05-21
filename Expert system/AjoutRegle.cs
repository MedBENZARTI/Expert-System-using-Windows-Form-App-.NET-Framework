using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Systemes_Experts
{
    public partial class AjoutRegle : Form
    {
        DataGridView regledgv;
        ComboBox fait;
        ComboBox but;

        public AjoutRegle(DataGridView regles, ComboBox f, ComboBox b)
        {
            InitializeComponent();
            this.regledgv = regles;
            this.fait = f;
            this.but = b;


        }

        private void ConfirmerBtn_Click(object sender, EventArgs e)
        {
            int res;
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            Object[,] attr =
            {
                {"@premisses",RegleTxtbox.Text},
                {"@conclusion", ConclusionTxtbox.Text.Trim() },
            };
            res = Global.ExecuterOleDBActionNomsParams(@"insert into regle (premisses, conclusion) values" +
                 " (@premisses,@conclusion)", cn, attr);
            Global.seDeconnecter(cn);

            loadRegles(regledgv);
            but.Items.Clear();
            retrieveFait(regledgv, fait, but);
            RegleTxtbox.Text = "";
            ConclusionTxtbox.Text = "";
        }

        private void NonBtn_Click(object sender, EventArgs e)
        {
            RegleTxtbox.Text = (RegleTxtbox.Text + " Non ").Trim();
        }

        private void PremisseBtn_Click(object sender, EventArgs e)
        {
            RegleTxtbox.Text = (RegleTxtbox.Text + " " +PermisseTxtbox.Text).Trim();
            PermisseTxtbox.Text = "";
        }

        private void etBtn_Click(object sender, EventArgs e)
        {
            RegleTxtbox.Text = RegleTxtbox.Text + " ET";
        }

        private void ouBtn_Click(object sender, EventArgs e)
        {
            RegleTxtbox.Text = RegleTxtbox.Text + " OU";
        }

        private void AnuulerBtn_Click(object sender, EventArgs e)
        {
            string[] text = RegleTxtbox.Text.Trim().Split();
            string newtext = "";
            if (text.Length == 2)
            {
                newtext = newtext + " " + text[0].Trim();
            }
            else
            {
                for (int i = 0; i < text.Length - 1; i++)
                {
                    newtext = newtext.Trim() + " " + text[i].Trim();
                }
            }
           
            RegleTxtbox.Text = (newtext + " ").Trim();
        }

        public static void loadRegles(DataGridView dgv)
        {
            dgv.Rows.Clear();
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader reader = Global.ExecuterOleDBSelect(@"select * from regle", cn);
            while (reader.Read())
            {
                dgv.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2));
            }
            reader.Close();
            Global.seDeconnecter(cn);
        }

        private void retrieveFait(DataGridView dgv, ComboBox combo, ComboBox combobut)
        {
            combo.Items.Clear();
            List<string> faits = new List<string>();
            List<string> buts = new List<string>();
            for (int j = 0; j < dgv.Rows.Count; j++)
            {
                string[] premisse = dgv.Rows[j].Cells[1].Value.ToString().Split();
                string conclusion = dgv.Rows[j].Cells[2].Value.ToString();
                for (int i = 0; i < premisse.Length; i++)
                {
                    if (premisse[i] == "ET" || premisse[i] == "OU")
                    {
                        continue;
                    }
                    if (premisse[i] == "Non")
                    {
                        string w = premisse[i] + " " + premisse[i + 1];
                        if (!testIn(w, faits))
                        {
                            faits.Add(premisse[i] + " " + premisse[i + 1]);
                            continue;
                        }
                    }
                    if (!testIn(premisse[i], faits))
                    {
                        faits.Add(premisse[i]);
                    }
                }
                if (!testIn(conclusion, faits))
                {
                    faits.Add(conclusion);

                }
                if (!testIn(conclusion, buts))
                {
                    buts.Add(conclusion);
                }

            }

            foreach (var fait in faits)
            {
                combo.Items.Add(fait);
            }

            foreach (var but in buts)
            {
                combobut.Items.Add(but);
            }
        }

        private Boolean testIn(string value, List<string> tab)
        {
            Boolean exist = false;
            foreach (var val in tab)
            {
                if (val == value)
                {
                    return true;
                }
            }
            return exist;
        }
    }
}

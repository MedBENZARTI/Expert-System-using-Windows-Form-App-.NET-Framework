using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systemes_Experts
{
    public  partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AjoutRegle.loadRegles(reglesdgv);
            retrieveFait(reglesdgv, faitCombo, butCombo);
        }
        private void AjouterRegleBtn_Click(object sender, EventArgs e)
        {
            AjoutRegle a = new AjoutRegle(reglesdgv,faitCombo,butCombo);
            a.Show();
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
                for (int i = 0; i < premisse.Length ; i++)
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
                if (!testIn(conclusion,faits))
                {
                    faits.Add(conclusion);

                } if (!testIn(conclusion,buts))
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

        private void ajouterFaitBtn_Click(object sender, EventArgs e)
        {
            Faitdgv.Rows.Add(faitCombo.SelectedItem);
            faitCombo.Text = "";
        }

        private void butBtn_Click(object sender, EventArgs e)
        {
            but.Text = butCombo.SelectedItem.ToString();
            butCombo.Text = "";
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            Process p = new Process(Faitdgv, but.Text, groupBox);
            p.Show();
        }

        private void deleteFait_Click(object sender, EventArgs e)
        {
            if (Faitdgv.SelectedRows.Count > 0)
            {
                Faitdgv.Rows.Remove(Faitdgv.SelectedRows[0]);
            }
        }
    }
}

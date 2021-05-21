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
    public partial class Process : Form
    {
        DataGridView faitdgv;
        string but;
        GroupBox groupBox;


        // regles contains the indexs of rows for the regles we want to delete 
        List<string> listeRegle = new List<string>();
        List<string> BF = new List<string>();
        string result = "";

        Boolean saturee = false;




        public Process(DataGridView dgv, string b, GroupBox gb)
        {
            InitializeComponent();
            AjoutRegle.loadRegles(datadgv);
            this.faitdgv = dgv;
            this.but = b;
            this.groupBox = gb;
            List<RadioButton> radioButtons = new List<RadioButton>();
            foreach (var r in this.groupBox.Controls.OfType<RadioButton>())
            {
                radioButtons.Add(r);
            }


            Boolean s1 = radioButtons[0].Checked;
            Boolean s2 = radioButtons[1].Checked;

            getInitialFait();

            while (!testIn(this.but, this.BF) && datadgv.Rows.Count > 0 && !saturee)
            {
                // update listeRegle + delete used regles
                this.listeRegle = getNewRegles(this.BF);
                if (s1)
                {
                    strategyLabel.Text = radioButtons[0].Text;
                    fillRegles1();
                }
                // fill the regles DGV with the used regles
                if (s2)
                {
                    strategyLabel.Text = radioButtons[1].Text;
                    fillRegles2();
                }

                // update the BF list
                // fill the BF DGV with the updates list of BF
                // clear the listRegle
                fillBF();

                
            }
            for (int i = 0; i < regledgv.Rows.Count; i++)
            {
                regledgv.Rows[i].Cells[0].Value = "Cycle" + (i + 1).ToString();
                bfdgv.Rows[i].Cells[0].Value = "Cycle" + (i + 1).ToString();
            }
            if (!testIn(this.but, this.BF))
            {
                if (saturee)
                {
                    resultLabel.Text = "La base est saturée, le but n'est pas atteint";
                    resultLabel.ForeColor = Color.Red;
                }
                if (datadgv.Rows.Count == 0)
                {
                    resultLabel.Text = "Il n'y a pas assez de regles, le but n'est pas atteint";
                    resultLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                resultLabel.Text = "Le but est atteint";
            }



      
        }

        private void Process_Load(object sender, EventArgs e)
        {
            
        }
        private void getInitialFait()
        {
            for (int i = 0; i < faitdgv.Rows.Count; i++)
            {
                this.BF.Add(faitdgv.Rows[i].Cells[0].Value.ToString());
            }
        }

        private List<string> getNewRegles(List<string> bf)
        {

            List<string> regles = new List<string>();

            for (int i = 0; i < datadgv.Rows.Count; i++)
            {

                List<string> premisse = new List<string>();
                foreach (var p in splitOperateur(datadgv.Rows[i].Cells[1].Value.ToString()))
                {
                    premisse.Add(p);
                }
                // tests if all premisse of one row is in BF
                bool exists = premisse.All(pre => testIn(pre,this.BF));
                if (exists == true)
                {
                    regles.Add(datadgv.Rows[i].Cells[0].Value.ToString());
                }
            }
            if (regles.Count > 0)
            {
                // delete used Regles
                updateRegles(regles, datadgv);
            }
            return regles;
        }

        private string[] splitOperateur(string word)
        {
            string s = word.Replace(" ET ",".");
            return s.Split('.');
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
        private void updateRegles(List<string> regles, DataGridView dgv)
        {
            DataGridView oldDGV = dgv;
            List < DataGridViewRow >  rows = new List<DataGridViewRow>();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (testIn(dgv.Rows[i].Cells[0].Value.ToString().Trim(), regles))
                {
                    rows.Add(dgv.Rows[i]);
                }
            }

            foreach (var r in rows)
            {
                dgv.Rows.Remove(r);
            }
        }
        private void fillBF()
        {
            int sizeBF = this.BF.Count;
            //get the new conclusions 
            this.BF = getNewBF(this.listeRegle);

            if (this.BF.Count - sizeBF == 0)
            {
                this.saturee = true;

            }
            else
            {
                string conclusionString = "";
                foreach (var c in this.BF)
                {
                    conclusionString = conclusionString + ", " + c;
                }
                bfdgv.Rows.Add("cycle", conclusionString.Trim(',').Trim());
                this.listeRegle.Clear();
            }

            
        }
        private void fillRegles1()
        {
            if (this.listeRegle.Count > 0)
            {
                string regleString = "";
                foreach (var r in this.listeRegle)
                {
                    regleString = regleString + "R" + r + ", ";
                }
                regledgv.Rows.Add("cycle", regleString.Trim(',').Trim().Trim(','));
            }
            
        }
        private void fillRegles2()
        {
            if (this.listeRegle.Count > 0)
            {
                string regleString = "";
                Dictionary<int, List<string>> reglesDict = new Dictionary<int, List<string>>();
                // creation of the dict 
                foreach (var r in this.listeRegle)
                {
                    int count = getListPremisse(r).Count;
                    if (!reglesDict.ContainsKey(count))
                    {
                        List<string> values = new List<string>();
                        values.Add(r);
                        reglesDict[count] = values;
                    }
                    else
                    {
                        reglesDict[count].Add(r);
                    }
                }
                foreach (KeyValuePair<int, List<string>> item in reglesDict.OrderBy(key => key.Key).Reverse())
                {
                    foreach (var r in item.Value)
                    {
                        regleString = regleString + "R" + r + ", ";
                    }
                }
                regledgv.Rows.Add("cycle", regleString.Trim(',').Trim().Trim(','));

            }

        }
        private List<string> getListPremisse(string nbr)
        {
            List<string> s = new List<string>();

            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader readerCmd;
            readerCmd = Global.ExecuterOleDBSelect(@"select premisses from Regle where ID = " + nbr, cn);
            string result = "";
                while (readerCmd.Read())
                {
                result = readerCmd.GetValue(0).ToString();
                
                }
            readerCmd.Close();
            Global.seDeconnecter(cn);
            foreach (var p in splitOperateur(result))
            {
                s.Add(p);
            }
            return s;
        }


        private List<string> getNewBF(List<string> regles)
        {
            List<string> newBF = new List<string>();
            foreach (var b in this.BF)
            {
                newBF.Add(b);
            }

            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader readerCmd;

            foreach (var r in this.listeRegle)
            {
                readerCmd = Global.ExecuterOleDBSelect(@"select conclusion from Regle where ID = " + r, cn);

                while (readerCmd.Read())
                {
                    if (!testIn(readerCmd.GetValue(0).ToString(), newBF))
                    {
                        newBF.Add(readerCmd.GetValue(0).ToString());
                    }
                }
                readerCmd.Close();
            }
            Global.seDeconnecter(cn);
            return newBF;
        }
    }
}

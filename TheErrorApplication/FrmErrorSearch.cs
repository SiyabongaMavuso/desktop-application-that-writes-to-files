using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TheErrorApplication
{
    public partial class FrmErrorSearch : Form
    {
        public FrmErrorSearch()
        {
            InitializeComponent();
            
        }

        private void FrmErrorSearch_Load(object sender, EventArgs e)
        {
            LoadLstErros();
            txtDisplay.Enabled = false;
            //txtSolutionId.Text = GetId().ToString();
        }
        public void LoadLstErros()
        {
            StreamReader read = new StreamReader("Error.txt");
            String[] field;
            string record = "";
            while ((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                lstErrors.Items.Add(field[1]);
            }
            read.Close();
        }

        private void lstErrors_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = lstErrors.SelectedItem.ToString();

            StreamReader reader = new StreamReader("Solution.txt");
            String[] field;
            string record = "";
            while ((record = reader.ReadLine()) != null)
            {
                field = record.Split('#');
                 if (field[2] == curItem)
                 {
                    txtDisplay.Text = field[1];

                 }

            }
            reader.Close();

        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            var m = new FrmLanding();
            m.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string errorMatch = txtSolution.Text.ToString();

            StreamReader reader = new StreamReader("Error.txt");
            String[] field;
            string record = "";
            while ((record = reader.ReadLine()) != null)
            {
                field = record.Split('#');
                if (field[1] == errorMatch)
                {
                    lstErrors.Items.Clear();
                    lstErrors.Items.Add(field[1]);

                }
                else 
                {
                    lstErrors.Items.Add("Error Not Found. Please vist Manage Erros on the home page");
                
                }

            }
            reader.Close();
        }
    }
}

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
    public partial class FrmSolution : Form
    {
        public FrmSolution()
        {
            InitializeComponent();
        }

        private void FrmSolution_Load(object sender, EventArgs e)
        {
            txtSolutionId.Enabled = false;
            txtSolutionId.Text = GetId().ToString();
            LoadCmbError();
            LoadCmbStudy();
            LoadCmbTopic();
        }
        public int GetId()
        {
            int id = 100000;
            try
            {
                StreamReader read = new StreamReader("Solution.txt");
                String[] field;
                string record = "";
                while ((record = read.ReadLine()) != null)
                {
                    field = record.Split('#');
                    id = int.Parse(field[0]) + 1;
                }
                read.Close();
            }
            catch
            {
                id = 100000;
            }
            return id;
        }
        public void LoadCmbError()
        {
            StreamReader read = new StreamReader("Error.txt");
            string[] field;
            string record = "";
            while ((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                cmbError.Items.Add(field[1]);
            }
            read.Close();
        }
        public void LoadCmbStudy()
        {
            StreamReader read = new StreamReader("Study.txt");
            string[] field;
            string record = "";
            while ((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                cmbStudy.Items.Add(field[1]);
            }
            read.Close();
        }
        public void LoadCmbTopic()
        {
            StreamReader read = new StreamReader("Topic.txt");
            string[] field;
            string record = "";
            while ((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                cmbTopic.Items.Add(field[1]);

            }
            read.Close();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            var m = new FrmLanding();
            m.Show();
            this.Hide();
        }

        private void btnInsertSolution_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter("Solution.txt", true);
            write.WriteLine(txtSolutionId.Text + "#" + txtSolutionDescription.Text+ "#" + cmbError.SelectedItem.ToString() + "#" + cmbStudy.SelectedItem.ToString() + "#" + cmbTopic.SelectedItem.ToString() + "#" + DateTime.Today.ToString("dd/MM/yyyy"));
            write.Close();
        }

        private void btnLst_Click(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader("Solution.txt");
            String[] field;
            string record = "";
            while ((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                lstSolution.Items.Add(field[0] + "\t" + field[1] + "\t" + field[2] + "\t" + field[3] + "\t" + field[4] + "\t" + field[5]);
            }
            read.Close();
            lblNoSolutions.Text = lstSolution.Items.Count.ToString();
        }
    }
}

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
    public partial class FrmError : Form
    {
        public FrmError()
        {
            InitializeComponent();
        }

        private void FrmError_Load(object sender, EventArgs e)
        {
            txtErrorId.Enabled = false;
            txtErrorId.Text = GetId().ToString();
            LoadCmbStudy();
            LoadCmbTopic();
        }

        public int GetId()
        {
            int id = 100000;
            try
            {
                StreamReader read = new StreamReader("Error.txt");
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

        private void btnInsertError_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter("Error.txt", true);
            write.WriteLine(txtErrorId.Text + "#" + txtErrorDescription.Text + "#" + cmbStudy.SelectedItem.ToString() + "#" + cmbTopic.SelectedItem.ToString() + "#" + DateTime.Today.ToString("dd/MM/yyyy"));
            write.Close();
        }

        private void btnLst_Click(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader("Error.txt");
            String[] field;
            string record = "";
            while ((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                lstError.Items.Add(field[0] + "\t" + field[1] + "\t" + field[2] + "\t" + field[3] + "\t" + field[4]);
            }
            read.Close();
        }
    }
}

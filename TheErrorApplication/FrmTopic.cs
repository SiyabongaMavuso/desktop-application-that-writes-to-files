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
    public partial class FrmTopic : Form
    {
        public FrmTopic()
        {
            InitializeComponent();
        }

        private void FrmTopic_Load(object sender, EventArgs e)
        {
            txtTopicId.Enabled = false;
            txtTopicId.Text = GetId().ToString();
            LoadCmbTopic();
        }
        public int GetId()
        {
            int id = 100000;
            try
            {
                StreamReader read = new StreamReader("Topic.txt");
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

        private void cmbTopic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadCmbTopic()
        {
            StreamReader read = new StreamReader("Study.txt");
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

        private void btnInsertTopic_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter("Topic.txt", true);
            write.WriteLine(txtTopicId.Text + "#" + txtTopicDescription.Text +"#"+ cmbTopic.SelectedItem.ToString());
            write.Close();
        }

        private void btnLst_Click(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader("Topic.txt");
            String[] field;
            string record = "";
            while ((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                lstTopic.Items.Add(field[0] + "\t" + field[1] + "\t" + "\t" +  field[2]);
            }
            read.Close();
        }

        private void txtTopicId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstTopic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

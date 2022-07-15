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
    public partial class FrmStudy : Form
    {
        public FrmStudy()
        {
            InitializeComponent();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            var m = new FrmLanding();
            m.Show();
            this.Hide();
        }

        private void btnInsertYear_Click(object sender, EventArgs e)
        {
            StreamWriter write = new StreamWriter("Study.txt", true);
            write.WriteLine(txtStudyId.Text + "#" + txtStudyDescription.Text);
            write.Close();
           
        }

        private void FrmStudy_Load(object sender, EventArgs e)
        {
            txtStudyId.Enabled = false;
            txtStudyId.Text = GetId().ToString();        
        }
        public int GetId()
        {
            int id = 100000;
            try
            {
                StreamReader read = new StreamReader("Study.txt");
                String[] field;
                string record = "";
                while ((record = read.ReadLine()) != null)
                {
                    field = record.Split('#');
                    id = int.Parse(field[0]) +1;
                }
                read.Close();
            }
            catch 
            {
                id = 100000;
            }
            return id;

        }

        private void btnLst_Click(object sender, EventArgs e)
        {
            StreamReader read = new StreamReader("Study.txt");
            String[] field;
            string record = "";
            while ((record = read.ReadLine()) != null)
            {
                field = record.Split('#');
                lstStudyLevel.Items.Add(field[0] + "\t" + field[1]);
            }
            read.Close();
        }

        private void txtStudyId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

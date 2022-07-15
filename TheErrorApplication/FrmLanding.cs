using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheErrorApplication
{
    public partial class FrmLanding : Form
    {
        public FrmLanding()
        {
            InitializeComponent();
        }

        private void FrmLanding_Load(object sender, EventArgs e)
        {

        }

        private void lblYears_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnFrmStudy_Click(object sender, EventArgs e)
        {
            var m = new FrmStudy();
            m.Show();
            this.Hide();
        }

        private void btnFrmtopic_Click(object sender, EventArgs e)
        {
            var m = new FrmTopic();
            m.Show();
            this.Hide();
        }

        private void btnFrmError_Click(object sender, EventArgs e)
        {
            var m = new FrmError();
            m.Show();
            this.Hide();
        }

        private void btnFrmSolutions_Click(object sender, EventArgs e)
        {
            var m = new FrmSolution();
            m.Show();
            this.Hide();
        }

        private void btnFormErrorSearch_Click(object sender, EventArgs e)
        {
            var m = new FrmErrorSearch();
            m.Show();
            this.Hide();
        }
    }
}

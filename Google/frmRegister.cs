using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Visible = true;
            this.Hide();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void tboxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tboxFirstName.Text = "";
            tboxLastName.Text = "";
            tboxEmailAddress.Text = "";
            tboxPassword.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tboxFirstName.Text == "")
            {
                MessageBox.Show("Ensure all the fields are filled", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (tboxLastName.Text == "")
            {
                MessageBox.Show("Ensure all the fields are filled", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (tboxEmailAddress.Text == "")
            {
                MessageBox.Show("Ensure all the fields are filled", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (tboxPassword.Text == "")
            {
                MessageBox.Show("Ensure all the fields are filled", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                frmLogin lg = new frmLogin();
                lg.Visible = true;
                this.Hide();
            }
        }
    }
}

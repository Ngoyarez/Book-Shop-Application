using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Google
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            panel1.Top = (this.Height - panel1.Height) / 2;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername1.Text = "";
            txtPassword.Text = "";
            txtUsername1.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername1.Text == "")
                {
                    MessageBox.Show("Ensure All Fields Are Filled! ", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername1.Focus();
                }

                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Ensure All Fields Are Filled! ", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }

                else
                {
                    //Connect to database
                    Conn connect = new Conn();
                    String query = "SELECT * FROM users WHERE username = '" + txtUsername1.Text.ToString() + "' AND password = '" + txtPassword.Text.ToString() + "' AND Status = 1";

                    //Open Connection
                    if (connect.openConnection() == true)
                    {
                        //Create MySql Command
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();
                        if (dataReader.Read())
                        {
                            MDIParent1 md = new MDIParent1();
                            md.Visible = true;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Credentials");
                            txtUsername1.Text = "";
                            txtPassword.Text = "";
                            txtUsername1.Focus();
                        }

                        dataReader.Close();

                        //Close Connection
                        connect.closeConnection();
                    }

                }
            }

            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister rg = new frmRegister();
            rg.Visible = true;
            this.Hide();
        }

        private void linkLabelForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Visible = true;
            this.Hide();
        }

        
    }
}

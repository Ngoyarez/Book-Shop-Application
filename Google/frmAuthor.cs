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
    public partial class frmAuthor : Form
    {
        public frmAuthor()
        {
            InitializeComponent();
        }

        private void frmAuthor_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are You sure you want to close this form?", "Close Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (dr == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             try
            {
                if (txtAuthorId.Text == "")
                {
                    MessageBox.Show("Please Enter The Author Id", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAuthorId.Focus();
                }

                else if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Please Enter The First Name", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFirstName.Focus();
                }

                else if (txtLastName.Text == "")
                {
                    MessageBox.Show("Please Enter The Last Name", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLastName.Focus();
                }
                
                else
                {
                    String query = "INSERT INTO author(author_id, first_name, last_name) VALUES('" + txtAuthorId.Text.ToString() + "', '" + txtFirstName.Text.ToString() + "', '" + txtLastName.Text.ToString() + "')";

                    //Establish Database Connection
                    Conn connect = new Conn();

                    //Open Connection
                    if (connect.openConnection() == true)
                    {

                        //MySQL Command 
                        MySqlCommand cmd = new MySqlCommand(query, connect.connection);

                        //Execute the command
                        cmd.ExecuteNonQuery();

                        //Reset the fields for another entry
                        txtAuthorId.Text = "";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtAuthorId.Focus();

                        MessageBox.Show("Record Successfully Saved", "Google LLC Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //Close Connection
                    connect.closeConnection();
                }
                
            }

            catch(Exception E)
            {
                MessageBox.Show(" " + E, "Google LLC Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        }
    }


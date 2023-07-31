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
    public partial class frmBookBundle : Form
    {
        public frmBookBundle()
        {
            InitializeComponent();
        }

        private void frmBookBundle_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookBundleId.Text == "")
                {
                    MessageBox.Show("Please Enter The Book Bundle Id", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookBundleId.Focus();
                }

                else if (txtBundleId.Text == "")
                {
                    MessageBox.Show("Please Enter The Bundle ID", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBundleId.Focus();
                }

                else if (txtCustomerId.Text == "")
                {
                    MessageBox.Show("Please Enter The Customer ID", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerId.Focus();
                }

                else if (txtBookId.Text == "")
                {
                    MessageBox.Show("Please Enter The Book ID", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookId.Focus();
                }


                else
                {
                    String query = "INSERT INTO book_bundle(book_bundle_id, bundle_id, customer_id, book_id) VALUES('" + txtBookBundleId.Text.ToString() + "', '" + txtBundleId.Text.ToString() + "', '" + txtCustomerId.Text.ToString() + "', " + txtBookId.Text.ToString() + "')";

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
                        txtBookBundleId.Text = "";
                        txtBundleId.Text = "";
                        txtCustomerId.Text = "";
                        txtBookId.Text = "";

                        txtBookBundleId.Focus();

                        MessageBox.Show("Record Successfully Saved", "Google LLC Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //Close Connection
                    connect.closeConnection();
                }
            }

            catch (Exception E)
            {
                MessageBox.Show(" " + E, "Google LLC Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
    }
}

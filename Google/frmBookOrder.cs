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
    public partial class frmBookOrder : Form
    {
        public frmBookOrder()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             try
            {
                if (txtBookOrderId.Text == "")
                {
                    MessageBox.Show("Please Enter The Book Order Id", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookOrderId.Focus();
                }

                else if (txtBookId.Text == "")
                {
                    MessageBox.Show("Please Enter The Book ID", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookId.Focus();
                }

                else if (txtOrderId.Text == "")
                {
                    MessageBox.Show("Please Enter The Order ID", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOrderId.Focus();
                }

                else if (txtCustomerId.Text == "")
                {
                    MessageBox.Show("Please Enter The Customer ID", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerId.Focus();
                }


                else
                {
                    String query = "INSERT INTO book_order(book_order_id, book_id, order_id, customer_id) VALUES('" + txtBookOrderId.Text.ToString() + "', '" + txtBookId.Text.ToString() + "', '" + txtOrderId.Text.ToString() + "', " + txtCustomerId.Text.ToString() +"')";

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
                        txtBookOrderId.Text = "";
                        txtBookId.Text = "";
                        txtOrderId.Text = "";
                        txtCustomerId.Text = "";
                       
                        txtBookOrderId.Focus();

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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Are You sure you want to close this form?", "Close Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (dr == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void frmBookOrder_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }
        }
    }


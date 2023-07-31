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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
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

        private void frmOrders_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             try
            {
                if (txtOrderId.Text == "")
                {
                    MessageBox.Show("Please Enter The Order Id", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOrderId.Focus();
                }

                else if (txtOrderDate.Text == "")
                {
                    MessageBox.Show("Please Enter The Order Date", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOrderDate.Focus();
                }

                else if (txtOrderPrice.Text == "")
                {
                    MessageBox.Show("Please Enter The Order Price", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOrderPrice.Focus();
                }

                

                else
                {
                    String query = "INSERT INTO order1(order_id, order_date, order_price) VALUES('" + txtOrderId.Text.ToString() + "', '" + txtOrderDate.Text.ToString() + "', '" + txtOrderPrice.Text.ToString() + "')";

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
                        txtOrderId.Text = "";
                        txtOrderDate.Text = "";
                        txtOrderPrice.Text = "";
                        txtOrderId.Focus();

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


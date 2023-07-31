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
    public partial class frmBundle : Form
    {
        public frmBundle()
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

        private void frmBundle_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             try
            {
                if (txtBundleId.Text == "")
                {
                    MessageBox.Show("Please Enter The Bundle Id", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBundleId.Focus();
                }

                else if (txtTotalPrice.Text == "")
                {
                    MessageBox.Show("Please Enter The Total Price", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTotalPrice.Focus();
                }

                else if (txtSaleStartDate.Text == "")
                {
                    MessageBox.Show("Please Enter The Sale Start Date", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSaleStartDate.Focus();
                }

                else if (txtSaleEndDate.Text == "")
                {
                    MessageBox.Show("Please Enter The Sale End Date", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSaleEndDate.Focus();
                }

                else if (txtBundleName.Text == "")
                {
                    MessageBox.Show("Please Enter The Bundle Name", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBundleName.Focus();
                }

                else
                {
                    String query = "INSERT INTO bundle(bundle_id, total_price, sales_start_date, sales_end_date, bundle_name) VALUES('" + txtBundleId.Text.ToString() + "', '" + txtTotalPrice.Text.ToString() + "', '" + txtSaleStartDate.Text.ToString() + "', '" + txtSaleEndDate.Text.ToString() + "', '" + txtBundleName.Text.ToString() + "')";

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
                        txtBundleId.Text = "";
                        txtTotalPrice.Text = "";
                        txtSaleStartDate.Text = "";
                        txtSaleEndDate.Text = "";
                        txtBundleName.Text = "";
                        txtBundleId.Focus();

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

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

       
        }

       
    }


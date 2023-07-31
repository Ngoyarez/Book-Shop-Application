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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
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

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerId.Text == "")
                {
                    MessageBox.Show("Please Enter The Customer Id", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerId.Focus();
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

                else if (txtPhoneNumber.Text == "")
                {
                    MessageBox.Show("Please Enter The Phone Number", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhoneNumber.Focus();
                }

                else if (txtPostalAddress.Text == "")
                {
                    MessageBox.Show("Please Enter The Postal Address", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPostalAddress.Focus();
                }

                else if (txtPostalCode.Text == "")
                {
                    MessageBox.Show("Please Enter The Postal Code", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPostalCode.Focus();
                }

                else if (txtCity.Text == "")
                {
                    MessageBox.Show("Please Enter The City", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCity.Focus();
                }

                else if (txtCountry.Text == "")
                {
                    MessageBox.Show("Please Enter The Country", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCountry.Focus();
                }

                else
                {
                    String query = "INSERT INTO customer(customer_id, first_name, last_name, phone_number, postal_address, postal_code, city,country) VALUES('" + txtCustomerId.Text.ToString() + "', '" + txtFirstName.Text.ToString() + "', '" + txtLastName.Text.ToString() + "', '" + txtPhoneNumber.Text.ToString() + "', '" + txtPostalAddress.Text.ToString() + "', '" + txtPostalCode.Text.ToString() + "', '" + txtCity.Text.ToString() + "', '" + txtCountry.Text.ToString() + "')";

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
                        txtCustomerId.Text = "";
                        txtFirstName.Text = "";
                        txtLastName.Text = "";
                        txtPhoneNumber.Text = "";
                        txtPostalAddress.Text = "";
                        txtPostalCode.Text = "";
                        txtCity.Text = "";
                        txtCountry.Text = "";
                        txtCustomerId.Focus();

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
    }

       
    }


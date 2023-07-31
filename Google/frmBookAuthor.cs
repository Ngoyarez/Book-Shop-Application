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
    public partial class frmBookAuthor : Form
    {
        public frmBookAuthor()
        {
            InitializeComponent();
        }

        private void frmBookAuthor_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
            getBookAuthorID();
            getBookID();
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

        //Function to fetch book author ID From the database
        private void getBookAuthorID()
        {
            //Create a connection
            Conn connect = new Conn();
            String query = "SELECT * FROM book_author ORDER BY book_author_id ASC";

            //Open Database 
            if (connect.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                this.cboBookId.Items.Clear();

                while (dataReader.Read())
                {
                    this.cboBookId.Items.Add(dataReader["book_author_id"].ToString());
                }

                //Close dataReader
                dataReader.Close();
            }
            //Close Connection
            connect.closeConnection();
        }


        //Function to fetch book ID From the database
        private void getBookID()
        {
            //Create a connection
            Conn  connect = new Conn();
            String query = "SELECT * FROM book ORDER BY book_id ASC";

            //Open Database 
            if (connect.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                this.cboBookId.Items.Clear();

                while (dataReader.Read())
                {
                    this.cboBookId.Items.Add(dataReader["book_id"].ToString());
                }

                //Close dataReader
                dataReader.Close();
            }
            //Close Connection
            connect.closeConnection();
        }


        //Function to fetch Author ID From the database
        private void getAuthorID()
        {
            //Create a connection
            Conn connect = new Conn();
            String query = "SELECT * FROM author ORDER BY author_id ASC";

            //Open Database 
            if (connect.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                this.cboBookId.Items.Clear();

                while (dataReader.Read())
                {
                    this.cboBookId.Items.Add(dataReader["author_id"].ToString());
                }

                //Close dataReader
                dataReader.Close();
            }
            //Close Connection
            connect.closeConnection();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
             try
            {
                if (cboBookAuthorId.Text == "")
                {
                    MessageBox.Show("Please Enter The Book Author Id", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboBookAuthorId.Focus();
                }

                else if (cboBookId.Text == "")
                {
                    MessageBox.Show("Please Enter The Book ID", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboBookId.Focus();
                }

                 else if (cboAuthorId.Text == "")
                {
                    MessageBox.Show("Please Enter The Author ID", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboAuthorId.Focus();
                }
                
                

                else
                {
                    String query = "INSERT INTO book_author(book_author_id, book_id, author_id) VALUES('" + cboBookAuthorId.Text.ToString() + "', '" + cboBookId.Text.ToString() + "', '" + cboAuthorId.Text.ToString() + "')";

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
                        cboBookAuthorId.Text = "";
                        cboBookId.Text = "";
                        cboAuthorId.Text = "";
                        cboBookAuthorId.Focus();

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

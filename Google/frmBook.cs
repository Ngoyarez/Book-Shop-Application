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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlMain.Top = (this.Height - pnlMain.Height) / 2;
            pnlSearch.Visible = false;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBookId.Text = "";
            txtTitle.Text = "";
            txtBookPrice.Text = "";
            cboGenre.Text = "";
            txtBookPrice.Text = "";
            txtPubYear.Text = "";
            txtBookId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookId.Text == "")
                {
                    MessageBox.Show("Please Enter The Book Id", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookId.Focus();
                }

                else if (txtTitle.Text == "")
                {
                    MessageBox.Show("Please Enter The Book Title", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTitle.Focus();
                }

                else if (cboGenre.Text == "")
                {
                    MessageBox.Show("Please Enter The Book Genre", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboGenre.Focus();
                }

                else if (txtBookPrice.Text == "")
                {
                    MessageBox.Show("Please Enter The Book Price", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookPrice.Focus();
                }

                else if (txtPubYear.Text == "")
                {
                    MessageBox.Show("Please Enter The Book Publication Year", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPubYear.Focus();
                }

                else
                {
                    String query = "INSERT INTO book(book_id, title, genre, book_price, pub_year) VALUES('" + txtBookId.Text.ToString() + "', '" + txtTitle.Text.ToString() + "', '" + cboGenre.Text.ToString() + "', " + txtBookPrice.Text.ToString() + ", '" + txtPubYear.Text.ToString() + "')";

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
                        txtBookId.Text = "";
                        txtTitle.Text = "";
                        cboGenre.Text = "";
                        txtBookPrice.Text = "";
                        txtPubYear.Text = "";
                        txtBookId.Focus();

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

        private void btnFind_Click(object sender, EventArgs e)
        {
            String criteria;
            String searchValue;
            String query = "";

            if (cboSearchCriteria.Text == "")
            {
                MessageBox.Show("Please Ensure All fields are filled", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboSearchCriteria.Focus();
            }

            else if (txtSearchValue.Text == "")
            {
                MessageBox.Show("Please Ensure All fields are filled", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSearchValue.Focus();
            }

            else
            {
                criteria = cboSearchCriteria.Text.ToString();

                //The best search value %0%
                searchValue = "%" + txtSearchValue.Text.ToString() + "%";

                if (criteria == "Book ID")
                {
                    query = "SELECT * FROM book WHERE book_id LIKE '" + searchValue + "' ORDER BY book_id ASC";
                }
                else if (criteria == "Title")
                {
                    query = "SELECT * FROM book WHERE title LIKE '" + searchValue + "' ORDER BY title ASC";
                }
                else if (criteria == "Genre")
                {
                    query = "SELECT * FROM book WHERE genre LIKE '" + searchValue + "' ORDER BY genre ASC";
                }
                else if (criteria == "Book Price")
                {
                    query = "SELECT * FROM book WHERE book_price LIKE '" + searchValue + "' ORDER BY book_price ASC";
                }
                else if (criteria == "Publication Year")
                {
                    query = "SELECT * FROM book WHERE pub_year LIKE '" + searchValue + "' ORDER BY pub_year ASC";
                }
                else if (criteria == "All")
                {
                    query = "SELECT * FROM book ORDER BY book_id ASC";
                }
                else
                {
                    MessageBox.Show("Invalid Search Criteria", "Google LLC Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboSearchCriteria.Focus();
                }

                //Creating Connection to the database
                Conn connect = new Conn();
                if (connect.openConnection() == true)
                {
                    //MessageBox.Show(query);
                    MySqlCommand cmd = new MySqlCommand(query, connect.connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Clear datagridview
                    this.dataGridView1.Rows.Clear();

                    while (dataReader.Read())
                    {
                        String[] row = new String[] { dataReader["book_id"].ToString(), dataReader["title"].ToString(), dataReader["genre"].ToString(), dataReader["book_price"].ToString(), dataReader["pub_year"].ToString() };
                        dataGridView1.Rows.Add(row);
                    }

                    //Close dataReader
                    dataReader.Close();
                }

                //Close connection
                connect.closeConnection();

            }
        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {
            pnlSearch.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = false;
        }

        

       


       
    }
}

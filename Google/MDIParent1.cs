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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.MdiParent = this;
            f.Visible = true;
            
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBook bk = new frmBook();
            bk.MdiParent = this;
            bk.Visible = true;
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthor a = new frmAuthor();
            a.MdiParent = this;
            a.Visible = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Visible = true;
            this.Hide();
        }

        private void bookAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookAuthor ba = new frmBookAuthor();
            ba.MdiParent = this;
            ba.Visible = true;
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders o = new frmOrders();
            o.MdiParent = this;
            o.Visible = true;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers c = new frmCustomers();
            c.MdiParent = this;
            c.Visible = true;
        }

        private void bundlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBundle b = new frmBundle();
            b.MdiParent = this;
            b.Visible = true;
        }

        private void bookBundleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookBundle bb = new frmBookBundle();
            bb.MdiParent = this;
            bb.Visible = true;
        }

        private void bookOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookOrder bo = new frmBookOrder();
            bo.MdiParent = this;
            bo.Visible = true;
        }

    }
}

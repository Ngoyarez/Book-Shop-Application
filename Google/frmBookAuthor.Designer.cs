namespace Google
{
    partial class frmBookAuthor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBookId1 = new System.Windows.Forms.Label();
            this.lblAuthorId = new System.Windows.Forms.Label();
            this.lblBookAuthorId = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.cboBookAuthorId = new System.Windows.Forms.ComboBox();
            this.cboBookId = new System.Windows.Forms.ComboBox();
            this.cboAuthorId = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.lblBookAuthor);
            this.pnlMain.Location = new System.Drawing.Point(103, 26);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(847, 450);
            this.pnlMain.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnQuit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(41, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 100);
            this.panel3.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(119, 45);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(239, 45);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(354, 45);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(685, 45);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(577, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(464, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cboAuthorId);
            this.panel2.Controls.Add(this.cboBookId);
            this.panel2.Controls.Add(this.cboBookAuthorId);
            this.panel2.Controls.Add(this.lblBookId1);
            this.panel2.Controls.Add(this.lblAuthorId);
            this.panel2.Controls.Add(this.lblBookAuthorId);
            this.panel2.Location = new System.Drawing.Point(41, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 190);
            this.panel2.TabIndex = 1;
            // 
            // lblBookId1
            // 
            this.lblBookId1.AutoSize = true;
            this.lblBookId1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId1.Location = new System.Drawing.Point(74, 78);
            this.lblBookId1.Name = "lblBookId1";
            this.lblBookId1.Size = new System.Drawing.Size(75, 21);
            this.lblBookId1.TabIndex = 2;
            this.lblBookId1.Text = "Book ID:";
            // 
            // lblAuthorId
            // 
            this.lblAuthorId.AutoSize = true;
            this.lblAuthorId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorId.Location = new System.Drawing.Point(74, 137);
            this.lblAuthorId.Name = "lblAuthorId";
            this.lblAuthorId.Size = new System.Drawing.Size(89, 21);
            this.lblAuthorId.TabIndex = 1;
            this.lblAuthorId.Text = "Author ID:";
            // 
            // lblBookAuthorId
            // 
            this.lblBookAuthorId.AutoSize = true;
            this.lblBookAuthorId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthorId.Location = new System.Drawing.Point(74, 28);
            this.lblBookAuthorId.Name = "lblBookAuthorId";
            this.lblBookAuthorId.Size = new System.Drawing.Size(138, 21);
            this.lblBookAuthorId.TabIndex = 0;
            this.lblBookAuthorId.Text = "Book Author ID: ";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.Location = new System.Drawing.Point(312, 16);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(214, 28);
            this.lblBookAuthor.TabIndex = 0;
            this.lblBookAuthor.Text = "Book Author Details";
            // 
            // cboBookAuthorId
            // 
            this.cboBookAuthorId.FormattingEnabled = true;
            this.cboBookAuthorId.Location = new System.Drawing.Point(274, 28);
            this.cboBookAuthorId.Name = "cboBookAuthorId";
            this.cboBookAuthorId.Size = new System.Drawing.Size(188, 21);
            this.cboBookAuthorId.TabIndex = 6;
            // 
            // cboBookId
            // 
            this.cboBookId.FormattingEnabled = true;
            this.cboBookId.Location = new System.Drawing.Point(274, 78);
            this.cboBookId.Name = "cboBookId";
            this.cboBookId.Size = new System.Drawing.Size(188, 21);
            this.cboBookId.TabIndex = 7;
            // 
            // cboAuthorId
            // 
            this.cboAuthorId.FormattingEnabled = true;
            this.cboAuthorId.Location = new System.Drawing.Point(274, 137);
            this.cboAuthorId.Name = "cboAuthorId";
            this.cboAuthorId.Size = new System.Drawing.Size(188, 21);
            this.cboAuthorId.TabIndex = 8;
            // 
            // frmBookAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1104, 477);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmBookAuthor";
            this.Text = "frmBookAuthor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBookAuthor_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBookId1;
        private System.Windows.Forms.Label lblAuthorId;
        private System.Windows.Forms.Label lblBookAuthorId;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.ComboBox cboBookAuthorId;
        private System.Windows.Forms.ComboBox cboAuthorId;
        private System.Windows.Forms.ComboBox cboBookId;
    }
}
namespace Google
{
    partial class frmBookBundle
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblBundleId = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.lblBookBundleId = new System.Windows.Forms.Label();
            this.lblBookBundle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBookBundleId = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtBundleId = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.lblBookBundle);
            this.pnlMain.Location = new System.Drawing.Point(288, 16);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(603, 445);
            this.pnlMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtCustomerId);
            this.panel2.Controls.Add(this.txtBundleId);
            this.panel2.Controls.Add(this.txtBookId);
            this.panel2.Controls.Add(this.txtBookBundleId);
            this.panel2.Controls.Add(this.lblCustomerId);
            this.panel2.Controls.Add(this.lblBundleId);
            this.panel2.Controls.Add(this.lblBookId);
            this.panel2.Controls.Add(this.lblBookBundleId);
            this.panel2.Location = new System.Drawing.Point(8, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 198);
            this.panel2.TabIndex = 1;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(59, 156);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(110, 21);
            this.lblCustomerId.TabIndex = 3;
            this.lblCustomerId.Text = "Customer ID:";
            // 
            // lblBundleId
            // 
            this.lblBundleId.AutoSize = true;
            this.lblBundleId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBundleId.Location = new System.Drawing.Point(59, 59);
            this.lblBundleId.Name = "lblBundleId";
            this.lblBundleId.Size = new System.Drawing.Size(89, 21);
            this.lblBundleId.TabIndex = 2;
            this.lblBundleId.Text = "Bundle ID:";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(59, 111);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(75, 21);
            this.lblBookId.TabIndex = 1;
            this.lblBookId.Text = "Book ID:";
            // 
            // lblBookBundleId
            // 
            this.lblBookBundleId.AutoSize = true;
            this.lblBookBundleId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookBundleId.Location = new System.Drawing.Point(59, 17);
            this.lblBookBundleId.Name = "lblBookBundleId";
            this.lblBookBundleId.Size = new System.Drawing.Size(133, 21);
            this.lblBookBundleId.TabIndex = 0;
            this.lblBookBundleId.Text = "Book Bundle ID:";
            // 
            // lblBookBundle
            // 
            this.lblBookBundle.AutoSize = true;
            this.lblBookBundle.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookBundle.Location = new System.Drawing.Point(183, 10);
            this.lblBookBundle.Name = "lblBookBundle";
            this.lblBookBundle.Size = new System.Drawing.Size(214, 28);
            this.lblBookBundle.TabIndex = 0;
            this.lblBookBundle.Text = "Book Bundle Details";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.btnQuit);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(8, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 102);
            this.panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(318, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(165, 53);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(318, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(486, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(18, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(165, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBookBundleId
            // 
            this.txtBookBundleId.Location = new System.Drawing.Point(219, 17);
            this.txtBookBundleId.Name = "txtBookBundleId";
            this.txtBookBundleId.Size = new System.Drawing.Size(168, 20);
            this.txtBookBundleId.TabIndex = 4;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(219, 111);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(168, 20);
            this.txtBookId.TabIndex = 5;
            // 
            // txtBundleId
            // 
            this.txtBundleId.Location = new System.Drawing.Point(219, 62);
            this.txtBundleId.Name = "txtBundleId";
            this.txtBundleId.Size = new System.Drawing.Size(168, 20);
            this.txtBundleId.TabIndex = 6;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(219, 156);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(168, 20);
            this.txtCustomerId.TabIndex = 7;
            // 
            // frmBookBundle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1129, 483);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmBookBundle";
            this.Text = "frmBookBundle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBookBundle_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblBundleId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Label lblBookBundleId;
        private System.Windows.Forms.Label lblBookBundle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtBundleId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookBundleId;
    }
}
namespace Google
{
    partial class frmBundle
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
            this.txtBundleName = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtBundleId = new System.Windows.Forms.TextBox();
            this.lblBundleName = new System.Windows.Forms.Label();
            this.lblSaleEndDate = new System.Windows.Forms.Label();
            this.lblSaleStartDate = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblBundleId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBundleDetails = new System.Windows.Forms.Label();
            this.txtSaleStartDate = new System.Windows.Forms.TextBox();
            this.txtSaleEndDate = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.lblBundleDetails);
            this.pnlMain.Location = new System.Drawing.Point(294, 19);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(679, 488);
            this.pnlMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtSaleEndDate);
            this.panel2.Controls.Add(this.txtSaleStartDate);
            this.panel2.Controls.Add(this.txtBundleName);
            this.panel2.Controls.Add(this.txtTotalPrice);
            this.panel2.Controls.Add(this.txtBundleId);
            this.panel2.Controls.Add(this.lblBundleName);
            this.panel2.Controls.Add(this.lblSaleEndDate);
            this.panel2.Controls.Add(this.lblSaleStartDate);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.lblBundleId);
            this.panel2.Location = new System.Drawing.Point(37, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 270);
            this.panel2.TabIndex = 3;
            // 
            // txtBundleName
            // 
            this.txtBundleName.Location = new System.Drawing.Point(188, 230);
            this.txtBundleName.Name = "txtBundleName";
            this.txtBundleName.Size = new System.Drawing.Size(186, 20);
            this.txtBundleName.TabIndex = 11;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(188, 68);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(186, 20);
            this.txtTotalPrice.TabIndex = 10;
            // 
            // txtBundleId
            // 
            this.txtBundleId.Location = new System.Drawing.Point(188, 23);
            this.txtBundleId.Name = "txtBundleId";
            this.txtBundleId.Size = new System.Drawing.Size(186, 20);
            this.txtBundleId.TabIndex = 7;
            // 
            // lblBundleName
            // 
            this.lblBundleName.AutoSize = true;
            this.lblBundleName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBundleName.Location = new System.Drawing.Point(39, 229);
            this.lblBundleName.Name = "lblBundleName";
            this.lblBundleName.Size = new System.Drawing.Size(118, 21);
            this.lblBundleName.TabIndex = 6;
            this.lblBundleName.Text = "Bundle Name:";
            // 
            // lblSaleEndDate
            // 
            this.lblSaleEndDate.AutoSize = true;
            this.lblSaleEndDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleEndDate.Location = new System.Drawing.Point(39, 174);
            this.lblSaleEndDate.Name = "lblSaleEndDate";
            this.lblSaleEndDate.Size = new System.Drawing.Size(127, 21);
            this.lblSaleEndDate.TabIndex = 5;
            this.lblSaleEndDate.Text = "Sales End Date:";
            // 
            // lblSaleStartDate
            // 
            this.lblSaleStartDate.AutoSize = true;
            this.lblSaleStartDate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleStartDate.Location = new System.Drawing.Point(39, 119);
            this.lblSaleStartDate.Name = "lblSaleStartDate";
            this.lblSaleStartDate.Size = new System.Drawing.Size(134, 21);
            this.lblSaleStartDate.TabIndex = 4;
            this.lblSaleStartDate.Text = "Sales Start Date:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(39, 68);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(94, 21);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblBundleId
            // 
            this.lblBundleId.AutoSize = true;
            this.lblBundleId.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBundleId.Location = new System.Drawing.Point(39, 23);
            this.lblBundleId.Name = "lblBundleId";
            this.lblBundleId.Size = new System.Drawing.Size(89, 21);
            this.lblBundleId.TabIndex = 2;
            this.lblBundleId.Text = "Bundle ID:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(37, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 102);
            this.panel1.TabIndex = 1;
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
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            // lblBundleDetails
            // 
            this.lblBundleDetails.AutoSize = true;
            this.lblBundleDetails.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBundleDetails.Location = new System.Drawing.Point(250, 15);
            this.lblBundleDetails.Name = "lblBundleDetails";
            this.lblBundleDetails.Size = new System.Drawing.Size(163, 28);
            this.lblBundleDetails.TabIndex = 0;
            this.lblBundleDetails.Text = "Bundle Details:";
            // 
            // txtSaleStartDate
            // 
            this.txtSaleStartDate.Location = new System.Drawing.Point(188, 122);
            this.txtSaleStartDate.Name = "txtSaleStartDate";
            this.txtSaleStartDate.Size = new System.Drawing.Size(186, 20);
            this.txtSaleStartDate.TabIndex = 12;
            // 
            // txtSaleEndDate
            // 
            this.txtSaleEndDate.Location = new System.Drawing.Point(188, 177);
            this.txtSaleEndDate.Name = "txtSaleEndDate";
            this.txtSaleEndDate.Size = new System.Drawing.Size(186, 20);
            this.txtSaleEndDate.TabIndex = 13;
            // 
            // frmBundle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1144, 540);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmBundle";
            this.Text = "frmBundle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBundle_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBundleDetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBundleName;
        private System.Windows.Forms.Label lblSaleEndDate;
        private System.Windows.Forms.Label lblSaleStartDate;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblBundleId;
        private System.Windows.Forms.TextBox txtBundleName;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtBundleId;
        private System.Windows.Forms.TextBox txtSaleEndDate;
        private System.Windows.Forms.TextBox txtSaleStartDate;
    }
}
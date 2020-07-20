namespace SeasideSouthPark
{
    partial class formAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAccount));
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlBar = new System.Windows.Forms.Panel();
            this.dragCtrlBar = new JDragControl.JDragControl(this.components);
            this.pnlAccBg = new System.Windows.Forms.Panel();
            this.linkImgUpload = new System.Windows.Forms.LinkLabel();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPNumber = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblFLName = new System.Windows.Forms.Label();
            this.picboxLine = new System.Windows.Forms.PictureBox();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBack = new System.Windows.Forms.Button();
            this.ctrlBar.SuspendLayout();
            this.pnlAccBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(769, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // ctrlBar
            // 
            this.ctrlBar.Controls.Add(this.btnBack);
            this.ctrlBar.Controls.Add(this.btnClose);
            this.ctrlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlBar.Location = new System.Drawing.Point(0, 0);
            this.ctrlBar.Name = "ctrlBar";
            this.ctrlBar.Size = new System.Drawing.Size(800, 35);
            this.ctrlBar.TabIndex = 5;
            // 
            // dragCtrlBar
            // 
            this.dragCtrlBar.GetForm = this;
            this.dragCtrlBar.TargetControl = this.ctrlBar;
            // 
            // pnlAccBg
            // 
            this.pnlAccBg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAccBg.BackgroundImage")));
            this.pnlAccBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlAccBg.Controls.Add(this.linkImgUpload);
            this.pnlAccBg.Controls.Add(this.lblCountry);
            this.pnlAccBg.Controls.Add(this.lblPNumber);
            this.pnlAccBg.Controls.Add(this.lblUserEmail);
            this.pnlAccBg.Controls.Add(this.lblFLName);
            this.pnlAccBg.Controls.Add(this.picboxLine);
            this.pnlAccBg.Controls.Add(this.picboxUser);
            this.pnlAccBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAccBg.Location = new System.Drawing.Point(0, 35);
            this.pnlAccBg.Name = "pnlAccBg";
            this.pnlAccBg.Size = new System.Drawing.Size(800, 565);
            this.pnlAccBg.TabIndex = 6;
            // 
            // linkImgUpload
            // 
            this.linkImgUpload.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkImgUpload.AutoSize = true;
            this.linkImgUpload.Font = new System.Drawing.Font("Cabin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkImgUpload.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkImgUpload.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.linkImgUpload.Location = new System.Drawing.Point(156, 134);
            this.linkImgUpload.Name = "linkImgUpload";
            this.linkImgUpload.Size = new System.Drawing.Size(85, 16);
            this.linkImgUpload.TabIndex = 19;
            this.linkImgUpload.TabStop = true;
            this.linkImgUpload.Text = "Choose image";
            this.linkImgUpload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkImgUpload_LinkClicked);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblCountry.Location = new System.Drawing.Point(51, 260);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 19);
            this.lblCountry.TabIndex = 14;
            this.lblCountry.Text = "Country";
            // 
            // lblPNumber
            // 
            this.lblPNumber.AutoSize = true;
            this.lblPNumber.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblPNumber.Location = new System.Drawing.Point(50, 230);
            this.lblPNumber.Name = "lblPNumber";
            this.lblPNumber.Size = new System.Drawing.Size(97, 19);
            this.lblPNumber.TabIndex = 13;
            this.lblPNumber.Text = "0701234567";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblUserEmail.Location = new System.Drawing.Point(50, 193);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(173, 19);
            this.lblUserEmail.TabIndex = 12;
            this.lblUserEmail.Text = "username@domain.com";
            // 
            // lblFLName
            // 
            this.lblFLName.AutoSize = true;
            this.lblFLName.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblFLName.Location = new System.Drawing.Point(49, 170);
            this.lblFLName.Name = "lblFLName";
            this.lblFLName.Size = new System.Drawing.Size(180, 23);
            this.lblFLName.TabIndex = 11;
            this.lblFLName.Text = "FirstName LastName";
            // 
            // picboxLine
            // 
            this.picboxLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxLine.BackgroundImage")));
            this.picboxLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxLine.Location = new System.Drawing.Point(280, 50);
            this.picboxLine.Name = "picboxLine";
            this.picboxLine.Size = new System.Drawing.Size(10, 275);
            this.picboxLine.TabIndex = 10;
            this.picboxLine.TabStop = false;
            // 
            // picboxUser
            // 
            this.picboxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxUser.BackgroundImage")));
            this.picboxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxUser.Location = new System.Drawing.Point(50, 50);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(100, 100);
            this.picboxUser.TabIndex = 9;
            this.picboxUser.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(743, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(20, 20);
            this.btnBack.TabIndex = 20;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // formAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlAccBg);
            this.Controls.Add(this.ctrlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Account";
            this.ctrlBar.ResumeLayout(false);
            this.pnlAccBg.ResumeLayout(false);
            this.pnlAccBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel ctrlBar;
        private JDragControl.JDragControl dragCtrlBar;
        private System.Windows.Forms.Panel pnlAccBg;
        private System.Windows.Forms.PictureBox picboxLine;
        private System.Windows.Forms.PictureBox picboxUser;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPNumber;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblFLName;
        private System.Windows.Forms.LinkLabel linkImgUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBack;
    }
}
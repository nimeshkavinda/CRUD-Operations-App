namespace SeasideSouthPark
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.loginBanner = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlBar = new System.Windows.Forms.Panel();
            this.dragCtrlBar = new JDragControl.JDragControl(this.components);
            this.pnlBgUserName = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlBgPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlSignIn = new System.Windows.Forms.Panel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.linkSignUp = new System.Windows.Forms.LinkLabel();
            this.lblDntHvAcc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlBar.SuspendLayout();
            this.pnlBgUserName.SuspendLayout();
            this.pnlBgPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBanner
            // 
            this.loginBanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBanner.BackgroundImage")));
            this.loginBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginBanner.Location = new System.Drawing.Point(0, 34);
            this.loginBanner.Name = "loginBanner";
            this.loginBanner.Size = new System.Drawing.Size(434, 568);
            this.loginBanner.TabIndex = 0;
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
            this.ctrlBar.Controls.Add(this.btnClose);
            this.ctrlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlBar.Location = new System.Drawing.Point(0, 0);
            this.ctrlBar.Name = "ctrlBar";
            this.ctrlBar.Size = new System.Drawing.Size(800, 35);
            this.ctrlBar.TabIndex = 4;
            // 
            // dragCtrlBar
            // 
            this.dragCtrlBar.GetForm = this;
            this.dragCtrlBar.TargetControl = this.ctrlBar;
            // 
            // pnlBgUserName
            // 
            this.pnlBgUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBgUserName.BackgroundImage")));
            this.pnlBgUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBgUserName.Controls.Add(this.txtUserName);
            this.pnlBgUserName.Location = new System.Drawing.Point(500, 215);
            this.pnlBgUserName.Name = "pnlBgUserName";
            this.pnlBgUserName.Size = new System.Drawing.Size(234, 38);
            this.pnlBgUserName.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Gray;
            this.txtUserName.Location = new System.Drawing.Point(5, 9);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(225, 24);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Username";
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // pnlBgPassword
            // 
            this.pnlBgPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBgPassword.BackgroundImage")));
            this.pnlBgPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBgPassword.Controls.Add(this.txtPassword);
            this.pnlBgPassword.Location = new System.Drawing.Point(500, 270);
            this.pnlBgPassword.Name = "pnlBgPassword";
            this.pnlBgPassword.Size = new System.Drawing.Size(234, 38);
            this.pnlBgPassword.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(5, 9);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(225, 24);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pnlSignIn
            // 
            this.pnlSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSignIn.BackgroundImage")));
            this.pnlSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlSignIn.Location = new System.Drawing.Point(500, 158);
            this.pnlSignIn.Name = "pnlSignIn";
            this.pnlSignIn.Size = new System.Drawing.Size(100, 35);
            this.pnlSignIn.TabIndex = 7;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(500, 329);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(234, 35);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // linkSignUp
            // 
            this.linkSignUp.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkSignUp.AutoSize = true;
            this.linkSignUp.Font = new System.Drawing.Font("Cabin", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.linkSignUp.Location = new System.Drawing.Point(642, 377);
            this.linkSignUp.Name = "linkSignUp";
            this.linkSignUp.Size = new System.Drawing.Size(83, 16);
            this.linkSignUp.TabIndex = 9;
            this.linkSignUp.TabStop = true;
            this.linkSignUp.Text = "Sign Up Here";
            this.linkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignUp_LinkClicked);
            // 
            // lblDntHvAcc
            // 
            this.lblDntHvAcc.AutoSize = true;
            this.lblDntHvAcc.Font = new System.Drawing.Font("Cabin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDntHvAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblDntHvAcc.Location = new System.Drawing.Point(497, 377);
            this.lblDntHvAcc.Name = "lblDntHvAcc";
            this.lblDntHvAcc.Size = new System.Drawing.Size(139, 16);
            this.lblDntHvAcc.TabIndex = 10;
            this.lblDntHvAcc.Text = "Don\'t Have an Account?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cabin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(586, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "© Seaside South Park. All Rights Reserved.";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDntHvAcc);
            this.Controls.Add(this.linkSignUp);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.pnlSignIn);
            this.Controls.Add(this.pnlBgPassword);
            this.Controls.Add(this.pnlBgUserName);
            this.Controls.Add(this.ctrlBar);
            this.Controls.Add(this.loginBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ctrlBar.ResumeLayout(false);
            this.pnlBgUserName.ResumeLayout(false);
            this.pnlBgUserName.PerformLayout();
            this.pnlBgPassword.ResumeLayout(false);
            this.pnlBgPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginBanner;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel ctrlBar;
        private JDragControl.JDragControl dragCtrlBar;
        private System.Windows.Forms.Panel pnlBgUserName;
        private System.Windows.Forms.Panel pnlBgPassword;
        private System.Windows.Forms.Panel pnlSignIn;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.LinkLabel linkSignUp;
        private System.Windows.Forms.Label lblDntHvAcc;
        private System.Windows.Forms.Label label1;
    }
}


namespace SeasideSouthPark
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlBar = new System.Windows.Forms.Panel();
            this.dragCtrlBar = new JDragControl.JDragControl(this.components);
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.linkManageAcc = new System.Windows.Forms.LinkLabel();
            this.linkSignOut = new System.Windows.Forms.LinkLabel();
            this.pnlHello = new System.Windows.Forms.Panel();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ctrlBar.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(1153, 8);
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
            this.ctrlBar.Size = new System.Drawing.Size(1180, 35);
            this.ctrlBar.TabIndex = 5;
            // 
            // dragCtrlBar
            // 
            this.dragCtrlBar.GetForm = this;
            this.dragCtrlBar.TargetControl = this.ctrlBar;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSideMenu.Controls.Add(this.linkLabel1);
            this.pnlSideMenu.Controls.Add(this.linkManageAcc);
            this.pnlSideMenu.Controls.Add(this.linkSignOut);
            this.pnlSideMenu.Controls.Add(this.pnlHello);
            this.pnlSideMenu.Controls.Add(this.picboxUser);
            this.pnlSideMenu.Controls.Add(this.lblUser);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 35);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(250, 625);
            this.pnlSideMenu.TabIndex = 6;
            // 
            // linkManageAcc
            // 
            this.linkManageAcc.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkManageAcc.AutoSize = true;
            this.linkManageAcc.Font = new System.Drawing.Font("Cabin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkManageAcc.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkManageAcc.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.linkManageAcc.Location = new System.Drawing.Point(22, 110);
            this.linkManageAcc.Name = "linkManageAcc";
            this.linkManageAcc.Size = new System.Drawing.Size(99, 16);
            this.linkManageAcc.TabIndex = 19;
            this.linkManageAcc.TabStop = true;
            this.linkManageAcc.Text = "Manage Account";
            this.linkManageAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkManageAcc_LinkClicked);
            // 
            // linkSignOut
            // 
            this.linkSignOut.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkSignOut.AutoSize = true;
            this.linkSignOut.Font = new System.Drawing.Font("Cabin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSignOut.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.linkSignOut.Location = new System.Drawing.Point(22, 130);
            this.linkSignOut.Name = "linkSignOut";
            this.linkSignOut.Size = new System.Drawing.Size(56, 16);
            this.linkSignOut.TabIndex = 18;
            this.linkSignOut.TabStop = true;
            this.linkSignOut.Text = "Sign Out";
            this.linkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignOut_LinkClicked);
            // 
            // pnlHello
            // 
            this.pnlHello.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlHello.BackgroundImage")));
            this.pnlHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlHello.Location = new System.Drawing.Point(100, 32);
            this.pnlHello.Name = "pnlHello";
            this.pnlHello.Size = new System.Drawing.Size(66, 26);
            this.pnlHello.TabIndex = 9;
            // 
            // picboxUser
            // 
            this.picboxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxUser.BackgroundImage")));
            this.picboxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxUser.Location = new System.Drawing.Point(25, 25);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(65, 65);
            this.picboxUser.TabIndex = 8;
            this.picboxUser.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblUser.Location = new System.Drawing.Point(95, 62);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(93, 23);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Username";
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlWelcome.BackgroundImage")));
            this.pnlWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWelcome.Location = new System.Drawing.Point(250, 35);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(930, 625);
            this.pnlWelcome.TabIndex = 7;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Cabin", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.linkLabel1.Location = new System.Drawing.Point(44, 269);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 16);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "About";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 660);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.ctrlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seaside South Park";
            this.ctrlBar.ResumeLayout(false);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel ctrlBar;
        private JDragControl.JDragControl dragCtrlBar;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Panel pnlHello;
        private System.Windows.Forms.PictureBox picboxUser;
        private System.Windows.Forms.LinkLabel linkSignOut;
        private System.Windows.Forms.LinkLabel linkManageAcc;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
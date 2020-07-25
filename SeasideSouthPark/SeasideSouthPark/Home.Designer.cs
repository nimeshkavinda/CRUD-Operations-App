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
            this.ctrlBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dragCtrlBar = new JDragControl.JDragControl(this.components);
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnMngAcc = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlHello = new System.Windows.Forms.Panel();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.pnlContact = new System.Windows.Forms.Panel();
            this.pnlWeb = new System.Windows.Forms.Panel();
            this.webMap = new System.Windows.Forms.WebBrowser();
            this.linkAnu = new System.Windows.Forms.LinkLabel();
            this.linkSahan = new System.Windows.Forms.LinkLabel();
            this.linkNimesh = new System.Windows.Forms.LinkLabel();
            this.linkFeedback = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkQuit = new System.Windows.Forms.LinkLabel();
            this.linkRegUser = new System.Windows.Forms.LinkLabel();
            this.ctrlBar.SuspendLayout();
            this.pnlSideMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            this.pnlContact.SuspendLayout();
            this.pnlWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlBar
            // 
            this.ctrlBar.Controls.Add(this.btnMinimize);
            this.ctrlBar.Controls.Add(this.btnClose);
            this.ctrlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlBar.Location = new System.Drawing.Point(0, 0);
            this.ctrlBar.Name = "ctrlBar";
            this.ctrlBar.Size = new System.Drawing.Size(1180, 35);
            this.ctrlBar.TabIndex = 5;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Location = new System.Drawing.Point(1127, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
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
            // dragCtrlBar
            // 
            this.dragCtrlBar.GetForm = this;
            this.dragCtrlBar.TargetControl = this.ctrlBar;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSideMenu.Controls.Add(this.linkRegUser);
            this.pnlSideMenu.Controls.Add(this.linkQuit);
            this.pnlSideMenu.Controls.Add(this.label1);
            this.pnlSideMenu.Controls.Add(this.pnlMenu);
            this.pnlSideMenu.Controls.Add(this.pnlHello);
            this.pnlSideMenu.Controls.Add(this.picboxUser);
            this.pnlSideMenu.Controls.Add(this.lblUser);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 35);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(250, 625);
            this.pnlSideMenu.TabIndex = 6;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlMenu.Controls.Add(this.btnSearch);
            this.pnlMenu.Controls.Add(this.btnContact);
            this.pnlMenu.Controls.Add(this.btnMngAcc);
            this.pnlMenu.Controls.Add(this.btnAbout);
            this.pnlMenu.Controls.Add(this.btnSignOut);
            this.pnlMenu.Location = new System.Drawing.Point(0, 110);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 350);
            this.pnlMenu.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cabin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.btnSearch.Location = new System.Drawing.Point(0, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(250, 68);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // btnContact
            // 
            this.btnContact.BackColor = System.Drawing.Color.Transparent;
            this.btnContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContact.BackgroundImage")));
            this.btnContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Cabin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.btnContact.Location = new System.Drawing.Point(0, 71);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(250, 68);
            this.btnContact.TabIndex = 25;
            this.btnContact.UseVisualStyleBackColor = false;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            this.btnContact.MouseEnter += new System.EventHandler(this.btnContact_MouseEnter);
            this.btnContact.MouseLeave += new System.EventHandler(this.btnContact_MouseLeave);
            // 
            // btnMngAcc
            // 
            this.btnMngAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnMngAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMngAcc.BackgroundImage")));
            this.btnMngAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMngAcc.FlatAppearance.BorderSize = 0;
            this.btnMngAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMngAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMngAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngAcc.Font = new System.Drawing.Font("Cabin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMngAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.btnMngAcc.Location = new System.Drawing.Point(0, 212);
            this.btnMngAcc.Name = "btnMngAcc";
            this.btnMngAcc.Size = new System.Drawing.Size(250, 68);
            this.btnMngAcc.TabIndex = 24;
            this.btnMngAcc.UseVisualStyleBackColor = false;
            this.btnMngAcc.Click += new System.EventHandler(this.btnMngAcc_Click);
            this.btnMngAcc.MouseEnter += new System.EventHandler(this.btnMngAcc_MouseEnter);
            this.btnMngAcc.MouseLeave += new System.EventHandler(this.btnMngAcc_MouseLeave);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Cabin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.btnAbout.Location = new System.Drawing.Point(0, 141);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(250, 68);
            this.btnAbout.TabIndex = 23;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSignOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignOut.BackgroundImage")));
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Cabin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.btnSignOut.Location = new System.Drawing.Point(0, 282);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(250, 68);
            this.btnSignOut.TabIndex = 22;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            this.btnSignOut.MouseEnter += new System.EventHandler(this.btnSignOut_MouseEnter);
            this.btnSignOut.MouseLeave += new System.EventHandler(this.btnSignOut_MouseLeave);
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
            this.lblUser.Font = new System.Drawing.Font("Cabin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblUser.Location = new System.Drawing.Point(94, 62);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(118, 29);
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
            // pnlContact
            // 
            this.pnlContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContact.BackgroundImage")));
            this.pnlContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlContact.Controls.Add(this.pnlWeb);
            this.pnlContact.Controls.Add(this.linkAnu);
            this.pnlContact.Controls.Add(this.linkSahan);
            this.pnlContact.Controls.Add(this.linkNimesh);
            this.pnlContact.Controls.Add(this.linkFeedback);
            this.pnlContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContact.Location = new System.Drawing.Point(250, 35);
            this.pnlContact.Name = "pnlContact";
            this.pnlContact.Size = new System.Drawing.Size(930, 625);
            this.pnlContact.TabIndex = 0;
            // 
            // pnlWeb
            // 
            this.pnlWeb.Controls.Add(this.webMap);
            this.pnlWeb.Location = new System.Drawing.Point(34, 330);
            this.pnlWeb.Name = "pnlWeb";
            this.pnlWeb.Size = new System.Drawing.Size(445, 230);
            this.pnlWeb.TabIndex = 25;
            // 
            // webMap
            // 
            this.webMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webMap.Location = new System.Drawing.Point(0, 0);
            this.webMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMap.Name = "webMap";
            this.webMap.ScrollBarsEnabled = false;
            this.webMap.Size = new System.Drawing.Size(445, 230);
            this.webMap.TabIndex = 0;
            // 
            // linkAnu
            // 
            this.linkAnu.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkAnu.AutoSize = true;
            this.linkAnu.BackColor = System.Drawing.Color.Transparent;
            this.linkAnu.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAnu.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkAnu.LinkColor = System.Drawing.Color.Black;
            this.linkAnu.Location = new System.Drawing.Point(424, 181);
            this.linkAnu.Name = "linkAnu";
            this.linkAnu.Size = new System.Drawing.Size(251, 19);
            this.linkAnu.TabIndex = 24;
            this.linkAnu.TabStop = true;
            this.linkAnu.Text = "anvidanagamage@students.nsbm.lk";
            this.linkAnu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAnu_LinkClicked);
            // 
            // linkSahan
            // 
            this.linkSahan.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkSahan.AutoSize = true;
            this.linkSahan.BackColor = System.Drawing.Color.Transparent;
            this.linkSahan.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSahan.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkSahan.LinkColor = System.Drawing.Color.Black;
            this.linkSahan.Location = new System.Drawing.Point(424, 160);
            this.linkSahan.Name = "linkSahan";
            this.linkSahan.Size = new System.Drawing.Size(232, 19);
            this.linkSahan.TabIndex = 23;
            this.linkSahan.TabStop = true;
            this.linkSahan.Text = "ntspnishantha@students.nsbm.lk";
            this.linkSahan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSahan_LinkClicked);
            // 
            // linkNimesh
            // 
            this.linkNimesh.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkNimesh.AutoSize = true;
            this.linkNimesh.BackColor = System.Drawing.Color.Transparent;
            this.linkNimesh.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNimesh.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkNimesh.LinkColor = System.Drawing.Color.Black;
            this.linkNimesh.Location = new System.Drawing.Point(424, 139);
            this.linkNimesh.Name = "linkNimesh";
            this.linkNimesh.Size = new System.Drawing.Size(220, 19);
            this.linkNimesh.TabIndex = 22;
            this.linkNimesh.TabStop = true;
            this.linkNimesh.Text = "ukdnkavinda@students.nsbm.lk";
            this.linkNimesh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkNimesh_LinkClicked);
            // 
            // linkFeedback
            // 
            this.linkFeedback.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkFeedback.AutoSize = true;
            this.linkFeedback.BackColor = System.Drawing.Color.Transparent;
            this.linkFeedback.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFeedback.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkFeedback.LinkColor = System.Drawing.Color.Black;
            this.linkFeedback.Location = new System.Drawing.Point(28, 260);
            this.linkFeedback.Name = "linkFeedback";
            this.linkFeedback.Size = new System.Drawing.Size(246, 23);
            this.linkFeedback.TabIndex = 21;
            this.linkFeedback.TabStop = true;
            this.linkFeedback.Text = "seasidesouthpark@gmail.com";
            this.linkFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFeedback_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cabin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(22, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "© Seaside South Park. All Rights Reserved.";
            // 
            // linkQuit
            // 
            this.linkQuit.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkQuit.AutoSize = true;
            this.linkQuit.BackColor = System.Drawing.Color.Transparent;
            this.linkQuit.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkQuit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkQuit.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.linkQuit.Location = new System.Drawing.Point(24, 559);
            this.linkQuit.Name = "linkQuit";
            this.linkQuit.Size = new System.Drawing.Size(37, 19);
            this.linkQuit.TabIndex = 21;
            this.linkQuit.TabStop = true;
            this.linkQuit.Text = "Quit";
            this.linkQuit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQuit_LinkClicked);
            // 
            // linkRegUser
            // 
            this.linkRegUser.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.linkRegUser.AutoSize = true;
            this.linkRegUser.BackColor = System.Drawing.Color.Transparent;
            this.linkRegUser.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegUser.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkRegUser.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.linkRegUser.Location = new System.Drawing.Point(67, 559);
            this.linkRegUser.Name = "linkRegUser";
            this.linkRegUser.Size = new System.Drawing.Size(158, 19);
            this.linkRegUser.TabIndex = 22;
            this.linkRegUser.TabStop = true;
            this.linkRegUser.Text = "Register Another User";
            this.linkRegUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegUser_LinkClicked);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 660);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.pnlContact);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.ctrlBar);
            this.Font = new System.Drawing.Font("Cabin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seaside South Park";
            this.Load += new System.EventHandler(this.formHome_Load);
            this.ctrlBar.ResumeLayout(false);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            this.pnlContact.ResumeLayout(false);
            this.pnlContact.PerformLayout();
            this.pnlWeb.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlContact;
        private System.Windows.Forms.LinkLabel linkFeedback;
        private System.Windows.Forms.LinkLabel linkNimesh;
        private System.Windows.Forms.LinkLabel linkAnu;
        private System.Windows.Forms.LinkLabel linkSahan;
        private System.Windows.Forms.Panel pnlWeb;
        private System.Windows.Forms.WebBrowser webMap;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnMngAcc;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkRegUser;
        private System.Windows.Forms.LinkLabel linkQuit;
    }
}
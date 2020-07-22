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
            this.btnBack = new System.Windows.Forms.Button();
            this.dragCtrlBar = new JDragControl.JDragControl(this.components);
            this.pnlAccBg = new System.Windows.Forms.Panel();
            this.linkImgUpload = new System.Windows.Forms.LinkLabel();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPNumber = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblFLName = new System.Windows.Forms.Label();
            this.picboxLine = new System.Windows.Forms.PictureBox();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.opnfileDlg = new System.Windows.Forms.OpenFileDialog();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.pnlBgUserName = new System.Windows.Forms.Panel();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ctrlBar.SuspendLayout();
            this.pnlAccBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            this.pnlBgUserName.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
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
            // dragCtrlBar
            // 
            this.dragCtrlBar.GetForm = this;
            this.dragCtrlBar.TargetControl = this.ctrlBar;
            // 
            // pnlAccBg
            // 
            this.pnlAccBg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAccBg.BackgroundImage")));
            this.pnlAccBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlAccBg.Controls.Add(this.btnUpdate);
            this.pnlAccBg.Controls.Add(this.panel7);
            this.pnlAccBg.Controls.Add(this.panel3);
            this.pnlAccBg.Controls.Add(this.panel1);
            this.pnlAccBg.Controls.Add(this.panel6);
            this.pnlAccBg.Controls.Add(this.panel5);
            this.pnlAccBg.Controls.Add(this.panel4);
            this.pnlAccBg.Controls.Add(this.panel2);
            this.pnlAccBg.Controls.Add(this.pnlBgUserName);
            this.pnlAccBg.Controls.Add(this.lblCountry);
            this.pnlAccBg.Controls.Add(this.linkImgUpload);
            this.pnlAccBg.Controls.Add(this.lblCity);
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
            this.linkImgUpload.Location = new System.Drawing.Point(147, 134);
            this.linkImgUpload.Name = "linkImgUpload";
            this.linkImgUpload.Size = new System.Drawing.Size(85, 16);
            this.linkImgUpload.TabIndex = 19;
            this.linkImgUpload.TabStop = true;
            this.linkImgUpload.Text = "Choose image";
            this.linkImgUpload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkImgUpload_LinkClicked);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblCity.Location = new System.Drawing.Point(41, 263);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 19);
            this.lblCity.TabIndex = 14;
            this.lblCity.Text = "City";
            // 
            // lblPNumber
            // 
            this.lblPNumber.AutoSize = true;
            this.lblPNumber.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblPNumber.Location = new System.Drawing.Point(41, 233);
            this.lblPNumber.Name = "lblPNumber";
            this.lblPNumber.Size = new System.Drawing.Size(112, 19);
            this.lblPNumber.TabIndex = 13;
            this.lblPNumber.Text = "Phone Number";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblUserEmail.Location = new System.Drawing.Point(41, 196);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(106, 19);
            this.lblUserEmail.TabIndex = 12;
            this.lblUserEmail.Text = "Email Address";
            // 
            // lblFLName
            // 
            this.lblFLName.AutoSize = true;
            this.lblFLName.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblFLName.Location = new System.Drawing.Point(40, 170);
            this.lblFLName.Name = "lblFLName";
            this.lblFLName.Size = new System.Drawing.Size(91, 23);
            this.lblFLName.TabIndex = 11;
            this.lblFLName.Text = "Full Name";
            // 
            // picboxLine
            // 
            this.picboxLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxLine.BackgroundImage")));
            this.picboxLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxLine.Location = new System.Drawing.Point(264, 50);
            this.picboxLine.Name = "picboxLine";
            this.picboxLine.Size = new System.Drawing.Size(10, 275);
            this.picboxLine.TabIndex = 10;
            this.picboxLine.TabStop = false;
            // 
            // picboxUser
            // 
            this.picboxUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picboxUser.BackgroundImage")));
            this.picboxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picboxUser.Location = new System.Drawing.Point(41, 50);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(100, 100);
            this.picboxUser.TabIndex = 9;
            this.picboxUser.TabStop = false;
            // 
            // opnfileDlg
            // 
            this.opnfileDlg.FileName = "Select an Image";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(92)))), ((int)(((byte)(110)))));
            this.lblCountry.Location = new System.Drawing.Point(41, 293);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(63, 19);
            this.lblCountry.TabIndex = 20;
            this.lblCountry.Text = "Country";
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFName.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.Color.Gray;
            this.txtFName.Location = new System.Drawing.Point(5, 9);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(225, 24);
            this.txtFName.TabIndex = 0;
            this.txtFName.Text = "First Name";
            this.txtFName.Enter += new System.EventHandler(this.txtFName_Enter);
            this.txtFName.Leave += new System.EventHandler(this.txtFName_Leave);
            // 
            // pnlBgUserName
            // 
            this.pnlBgUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBgUserName.BackgroundImage")));
            this.pnlBgUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlBgUserName.Controls.Add(this.txtFName);
            this.pnlBgUserName.Location = new System.Drawing.Point(289, 50);
            this.pnlBgUserName.Name = "pnlBgUserName";
            this.pnlBgUserName.Size = new System.Drawing.Size(234, 38);
            this.pnlBgUserName.TabIndex = 21;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLName.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.Color.Gray;
            this.txtLName.Location = new System.Drawing.Point(5, 9);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(225, 24);
            this.txtLName.TabIndex = 0;
            this.txtLName.Text = "Last Name";
            this.txtLName.Enter += new System.EventHandler(this.txtLName_Enter);
            this.txtLName.Leave += new System.EventHandler(this.txtLName_Leave);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.txtLName);
            this.panel2.Location = new System.Drawing.Point(529, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 38);
            this.panel2.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(5, 9);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 24);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "E-mail";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Location = new System.Drawing.Point(289, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 38);
            this.panel4.TabIndex = 23;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Gray;
            this.txtPhone.Location = new System.Drawing.Point(5, 9);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(225, 24);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.Text = "Mobile Number";
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.txtPhone);
            this.panel5.Location = new System.Drawing.Point(529, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 38);
            this.panel5.TabIndex = 24;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Gray;
            this.txtCity.Location = new System.Drawing.Point(5, 9);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(225, 24);
            this.txtCity.TabIndex = 0;
            this.txtCity.Text = "City";
            this.txtCity.Enter += new System.EventHandler(this.txtCity_Enter);
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Controls.Add(this.txtCity);
            this.panel6.Location = new System.Drawing.Point(289, 166);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 38);
            this.panel6.TabIndex = 25;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountry.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.Color.Gray;
            this.txtCountry.Location = new System.Drawing.Point(5, 9);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(225, 24);
            this.txtCountry.TabIndex = 0;
            this.txtCountry.Text = "Country";
            this.txtCountry.Enter += new System.EventHandler(this.txtCountry_Enter);
            this.txtCountry.Leave += new System.EventHandler(this.txtCountry_Leave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.txtCountry);
            this.panel1.Location = new System.Drawing.Point(529, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 38);
            this.panel1.TabIndex = 26;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.txtCurrentPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPass.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.ForeColor = System.Drawing.Color.Gray;
            this.txtCurrentPass.Location = new System.Drawing.Point(5, 9);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(225, 24);
            this.txtCurrentPass.TabIndex = 0;
            this.txtCurrentPass.Text = "Current Password";
            this.txtCurrentPass.Enter += new System.EventHandler(this.txtCurrentPass_Enter);
            this.txtCurrentPass.Leave += new System.EventHandler(this.txtCurrentPass_Leave);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.txtCurrentPass);
            this.panel3.Location = new System.Drawing.Point(289, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 38);
            this.panel3.TabIndex = 27;
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Font = new System.Drawing.Font("Cabin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.Gray;
            this.txtNewPass.Location = new System.Drawing.Point(5, 9);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(225, 24);
            this.txtNewPass.TabIndex = 0;
            this.txtNewPass.Text = "New Password";
            this.txtNewPass.Enter += new System.EventHandler(this.txtNewPass_Enter);
            this.txtNewPass.Leave += new System.EventHandler(this.txtNewPass_Leave);
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Controls.Add(this.txtNewPass);
            this.panel7.Location = new System.Drawing.Point(529, 224);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(234, 38);
            this.panel7.TabIndex = 28;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(529, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(234, 35);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update Account";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.pnlBgUserName.ResumeLayout(false);
            this.pnlBgUserName.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel ctrlBar;
        private JDragControl.JDragControl dragCtrlBar;
        private System.Windows.Forms.Panel pnlAccBg;
        private System.Windows.Forms.PictureBox picboxLine;
        private System.Windows.Forms.PictureBox picboxUser;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPNumber;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblFLName;
        private System.Windows.Forms.LinkLabel linkImgUpload;
        private System.Windows.Forms.OpenFileDialog opnfileDlg;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Panel pnlBgUserName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnUpdate;
    }
}
namespace OgrenciNotSistemi
{
    partial class FormOgrenci
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblAvarage = new System.Windows.Forms.Label();
            this.lblBiyoloji = new System.Windows.Forms.Label();
            this.lblGeometri = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblFelsefe = new System.Windows.Forms.Label();
            this.lblCografya = new System.Windows.Forms.Label();
            this.lblKimya = new System.Windows.Forms.Label();
            this.lblFizik = new System.Windows.Forms.Label();
            this.lblMatematik = new System.Windows.Forms.Label();
            this.lblEdebiyat = new System.Windows.Forms.Label();
            this.lblTurkce = new System.Windows.Forms.Label();
            this.lblPanelInfo = new System.Windows.Forms.Label();
            this.gbAccountInfo = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbAccept = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbStudentInfo.SuspendLayout();
            this.gbAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaxMin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 55);
            this.panel1.TabIndex = 1;
//            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackgroundImage = global::OgrenciNotSistemi.Properties.Resources.minimize_sign;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(796, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 48);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMaxMin.BackgroundImage = global::OgrenciNotSistemi.Properties.Resources.maximize;
            this.btnMaxMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaxMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMaxMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMin.Location = new System.Drawing.Point(848, 4);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(46, 48);
            this.btnMaxMin.TabIndex = 1;
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Öğrenci Paneli";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackgroundImage = global::OgrenciNotSistemi.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(900, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(149)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.btnAccount);
            this.panel2.Controls.Add(this.btnShowStudents);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 751);
            this.panel2.TabIndex = 2;
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccount.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(12, 687);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(256, 49);
            this.btnAccount.TabIndex = 12;
            this.btnAccount.Text = "Hesap Bilgilerim";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnShowStudents.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnShowStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.btnShowStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowStudents.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowStudents.ForeColor = System.Drawing.Color.White;
            this.btnShowStudents.Location = new System.Drawing.Point(12, 288);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(256, 61);
            this.btnShowStudents.TabIndex = 11;
            this.btnShowStudents.Text = "Ders Notları";
            this.btnShowStudents.UseVisualStyleBackColor = false;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OgrenciNotSistemi.Properties.Resources.graduated;
            this.pictureBox1.Location = new System.Drawing.Point(78, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(213)))));
            this.lblWelcome.Location = new System.Drawing.Point(24, 179);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(53, 37);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "{0}";
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.lblAvarage);
            this.gbStudentInfo.Controls.Add(this.lblBiyoloji);
            this.gbStudentInfo.Controls.Add(this.lblGeometri);
            this.gbStudentInfo.Controls.Add(this.lblTarih);
            this.gbStudentInfo.Controls.Add(this.lblFelsefe);
            this.gbStudentInfo.Controls.Add(this.lblCografya);
            this.gbStudentInfo.Controls.Add(this.lblKimya);
            this.gbStudentInfo.Controls.Add(this.lblFizik);
            this.gbStudentInfo.Controls.Add(this.lblMatematik);
            this.gbStudentInfo.Controls.Add(this.lblEdebiyat);
            this.gbStudentInfo.Controls.Add(this.lblTurkce);
            this.gbStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbStudentInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.gbStudentInfo.Location = new System.Drawing.Point(290, 120);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(647, 619);
            this.gbStudentInfo.TabIndex = 13;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Öğrenci Not Bilgileri";
            this.gbStudentInfo.Visible = false;
            // 
            // lblAvarage
            // 
            this.lblAvarage.AutoSize = true;
            this.lblAvarage.BackColor = System.Drawing.Color.Transparent;
            this.lblAvarage.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAvarage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblAvarage.Location = new System.Drawing.Point(42, 570);
            this.lblAvarage.Name = "lblAvarage";
            this.lblAvarage.Size = new System.Drawing.Size(145, 37);
            this.lblAvarage.TabIndex = 17;
            this.lblAvarage.Text = "Ortalama:";
            // 
            // lblBiyoloji
            // 
            this.lblBiyoloji.AutoSize = true;
            this.lblBiyoloji.BackColor = System.Drawing.Color.Transparent;
            this.lblBiyoloji.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBiyoloji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblBiyoloji.Location = new System.Drawing.Point(65, 518);
            this.lblBiyoloji.Name = "lblBiyoloji";
            this.lblBiyoloji.Size = new System.Drawing.Size(122, 37);
            this.lblBiyoloji.TabIndex = 16;
            this.lblBiyoloji.Text = "Biyoloji:";
            // 
            // lblGeometri
            // 
            this.lblGeometri.AutoSize = true;
            this.lblGeometri.BackColor = System.Drawing.Color.Transparent;
            this.lblGeometri.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGeometri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblGeometri.Location = new System.Drawing.Point(42, 464);
            this.lblGeometri.Name = "lblGeometri";
            this.lblGeometri.Size = new System.Drawing.Size(145, 37);
            this.lblGeometri.TabIndex = 15;
            this.lblGeometri.Text = "Geometri:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblTarih.Location = new System.Drawing.Point(99, 410);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(88, 37);
            this.lblTarih.TabIndex = 13;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblFelsefe
            // 
            this.lblFelsefe.AutoSize = true;
            this.lblFelsefe.BackColor = System.Drawing.Color.Transparent;
            this.lblFelsefe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFelsefe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblFelsefe.Location = new System.Drawing.Point(74, 356);
            this.lblFelsefe.Name = "lblFelsefe";
            this.lblFelsefe.Size = new System.Drawing.Size(113, 37);
            this.lblFelsefe.TabIndex = 14;
            this.lblFelsefe.Text = "Felsefe:";
            // 
            // lblCografya
            // 
            this.lblCografya.AutoSize = true;
            this.lblCografya.BackColor = System.Drawing.Color.Transparent;
            this.lblCografya.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCografya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblCografya.Location = new System.Drawing.Point(45, 302);
            this.lblCografya.Name = "lblCografya";
            this.lblCografya.Size = new System.Drawing.Size(142, 37);
            this.lblCografya.TabIndex = 13;
            this.lblCografya.Text = "Coğrafya:";
            // 
            // lblKimya
            // 
            this.lblKimya.AutoSize = true;
            this.lblKimya.BackColor = System.Drawing.Color.Transparent;
            this.lblKimya.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKimya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblKimya.Location = new System.Drawing.Point(82, 248);
            this.lblKimya.Name = "lblKimya";
            this.lblKimya.Size = new System.Drawing.Size(105, 37);
            this.lblKimya.TabIndex = 13;
            this.lblKimya.Text = "Kimya:";
            // 
            // lblFizik
            // 
            this.lblFizik.AutoSize = true;
            this.lblFizik.BackColor = System.Drawing.Color.Transparent;
            this.lblFizik.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFizik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblFizik.Location = new System.Drawing.Point(104, 194);
            this.lblFizik.Name = "lblFizik";
            this.lblFizik.Size = new System.Drawing.Size(83, 37);
            this.lblFizik.TabIndex = 12;
            this.lblFizik.Text = "Fizik:";
            // 
            // lblMatematik
            // 
            this.lblMatematik.AutoSize = true;
            this.lblMatematik.BackColor = System.Drawing.Color.Transparent;
            this.lblMatematik.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMatematik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblMatematik.Location = new System.Drawing.Point(21, 140);
            this.lblMatematik.Name = "lblMatematik";
            this.lblMatematik.Size = new System.Drawing.Size(166, 37);
            this.lblMatematik.TabIndex = 11;
            this.lblMatematik.Text = "Matematik:";
            // 
            // lblEdebiyat
            // 
            this.lblEdebiyat.AutoSize = true;
            this.lblEdebiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblEdebiyat.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEdebiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblEdebiyat.Location = new System.Drawing.Point(51, 86);
            this.lblEdebiyat.Name = "lblEdebiyat";
            this.lblEdebiyat.Size = new System.Drawing.Size(136, 37);
            this.lblEdebiyat.TabIndex = 10;
            this.lblEdebiyat.Text = "Edebiyat:";
            // 
            // lblTurkce
            // 
            this.lblTurkce.AutoSize = true;
            this.lblTurkce.BackColor = System.Drawing.Color.Transparent;
            this.lblTurkce.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTurkce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblTurkce.Location = new System.Drawing.Point(79, 32);
            this.lblTurkce.Name = "lblTurkce";
            this.lblTurkce.Size = new System.Drawing.Size(108, 37);
            this.lblTurkce.TabIndex = 9;
            this.lblTurkce.Text = "Türkçe:";
            // 
            // lblPanelInfo
            // 
            this.lblPanelInfo.AutoSize = true;
            this.lblPanelInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPanelInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPanelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblPanelInfo.Location = new System.Drawing.Point(296, 61);
            this.lblPanelInfo.Name = "lblPanelInfo";
            this.lblPanelInfo.Size = new System.Drawing.Size(202, 37);
            this.lblPanelInfo.TabIndex = 10;
            this.lblPanelInfo.Text = "Öğrenci Paneli";
            // 
            // gbAccountInfo
            // 
            this.gbAccountInfo.Controls.Add(this.txtUserName);
            this.gbAccountInfo.Controls.Add(this.label4);
            this.gbAccountInfo.Controls.Add(this.btnCancel);
            this.gbAccountInfo.Controls.Add(this.cbAccept);
            this.gbAccountInfo.Controls.Add(this.txtID);
            this.gbAccountInfo.Controls.Add(this.label3);
            this.gbAccountInfo.Controls.Add(this.btnDelete);
            this.gbAccountInfo.Controls.Add(this.btnUpdate);
            this.gbAccountInfo.Controls.Add(this.btnShowHide);
            this.gbAccountInfo.Controls.Add(this.txtPass);
            this.gbAccountInfo.Controls.Add(this.txtStudentNo);
            this.gbAccountInfo.Controls.Add(this.txtSurname);
            this.gbAccountInfo.Controls.Add(this.txtName);
            this.gbAccountInfo.Controls.Add(this.label2);
            this.gbAccountInfo.Controls.Add(this.label10);
            this.gbAccountInfo.Controls.Add(this.lblStudentNum);
            this.gbAccountInfo.Controls.Add(this.lblNameSurname);
            this.gbAccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbAccountInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.gbAccountInfo.Location = new System.Drawing.Point(292, 123);
            this.gbAccountInfo.Name = "gbAccountInfo";
            this.gbAccountInfo.Size = new System.Drawing.Size(647, 619);
            this.gbAccountInfo.TabIndex = 18;
            this.gbAccountInfo.TabStop = false;
            this.gbAccountInfo.Text = "Hesap Bilgileri";
            this.gbAccountInfo.Visible = false;
            this.gbAccountInfo.Enter += new System.EventHandler(this.gbAccountInfo_Enter);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.DarkGray;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Location = new System.Drawing.Point(223, 183);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(304, 43);
            this.txtUserName.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.label4.Location = new System.Drawing.Point(29, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "KullanıcıAdı:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(485, 495);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 49);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbAccept
            // 
            this.cbAccept.AutoSize = true;
            this.cbAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.cbAccept.ForeColor = System.Drawing.Color.Red;
            this.cbAccept.Location = new System.Drawing.Point(485, 577);
            this.cbAccept.Name = "cbAccept";
            this.cbAccept.Size = new System.Drawing.Size(125, 24);
            this.cbAccept.TabIndex = 21;
            this.cbAccept.Text = "Onaylıyorum";
            this.cbAccept.UseVisualStyleBackColor = false;
            this.cbAccept.Visible = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.DarkGray;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(223, 420);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(304, 43);
            this.txtID.TabIndex = 20;
            this.txtID.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.label3.Location = new System.Drawing.Point(51, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hesap idsi:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(223, 561);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(256, 49);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Hesabı Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(223, 495);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(256, 49);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Bilgileri Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShowHide
            // 
            this.btnShowHide.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnShowHide.BackgroundImage = global::OgrenciNotSistemi.Properties.Resources.hidden;
            this.btnShowHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHide.Location = new System.Drawing.Point(533, 332);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(50, 43);
            this.btnShowHide.TabIndex = 17;
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.DarkGray;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.Location = new System.Drawing.Point(223, 341);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(304, 43);
            this.txtPass.TabIndex = 16;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.BackColor = System.Drawing.Color.DarkGray;
            this.txtStudentNo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStudentNo.Location = new System.Drawing.Point(223, 262);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.ReadOnly = true;
            this.txtStudentNo.Size = new System.Drawing.Size(304, 43);
            this.txtStudentNo.TabIndex = 15;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.DarkGray;
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(223, 104);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(304, 43);
            this.txtSurname.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.DarkGray;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(223, 25);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(304, 43);
            this.txtName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.label2.Location = new System.Drawing.Point(86, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "soyisim:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.label10.Location = new System.Drawing.Point(17, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 37);
            this.label10.TabIndex = 11;
            this.label10.Text = "Hesap Şifresi:";
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentNum.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblStudentNum.Location = new System.Drawing.Point(60, 266);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(147, 37);
            this.lblStudentNum.TabIndex = 10;
            this.lblStudentNum.Text = "Numarası:";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblNameSurname.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(87)))), ((int)(((byte)(129)))));
            this.lblNameSurname.Location = new System.Drawing.Point(130, 29);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(77, 37);
            this.lblNameSurname.TabIndex = 9;
            this.lblNameSurname.Text = "isim:";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogout.Location = new System.Drawing.Point(623, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 48);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Hesaptan Çık";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(949, 751);
            this.Controls.Add(this.lblPanelInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbAccountInfo);
            this.Controls.Add(this.gbStudentInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormOgrenci_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.gbAccountInfo.ResumeLayout(false);
            this.gbAccountInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.Label lblBiyoloji;
        private System.Windows.Forms.Label lblGeometri;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblFelsefe;
        private System.Windows.Forms.Label lblCografya;
        private System.Windows.Forms.Label lblKimya;
        private System.Windows.Forms.Label lblFizik;
        private System.Windows.Forms.Label lblMatematik;
        private System.Windows.Forms.Label lblEdebiyat;
        private System.Windows.Forms.Label lblTurkce;
        private System.Windows.Forms.Label lblPanelInfo;
        private System.Windows.Forms.Label lblAvarage;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.GroupBox gbAccountInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStudentNum;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogout;
    }
}
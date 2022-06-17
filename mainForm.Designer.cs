namespace EasySchool
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.leftSidePanel = new System.Windows.Forms.Panel();
            this.subjectContainerPanel = new System.Windows.Forms.Panel();
            this.studentInfoPanel = new System.Windows.Forms.Panel();
            this.splitterLabel2 = new System.Windows.Forms.Label();
            this.schoolNameLabel = new System.Windows.Forms.Label();
            this.schoolYearLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.settingsContainerPanel = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.splitterLabel = new System.Windows.Forms.Label();
            this.rememberPassCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.mainContainerPanel = new System.Windows.Forms.Panel();
            this.wbOptionsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutTimer = new System.Windows.Forms.Timer(this.components);
            this.removeNotesBtn = new System.Windows.Forms.Button();
            this.refreshwbBtn = new System.Windows.Forms.Button();
            this.hidewbBtn = new System.Windows.Forms.Button();
            this.genderPb = new System.Windows.Forms.PictureBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.statsBtn = new System.Windows.Forms.Button();
            this.showPassPb = new System.Windows.Forms.PictureBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.leftSidePanel.SuspendLayout();
            this.studentInfoPanel.SuspendLayout();
            this.settingsContainerPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.wbOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassPb)).BeginInit();
            this.SuspendLayout();
            // 
            // leftSidePanel
            // 
            this.leftSidePanel.Controls.Add(this.subjectContainerPanel);
            this.leftSidePanel.Controls.Add(this.studentInfoPanel);
            this.leftSidePanel.Controls.Add(this.settingsContainerPanel);
            this.leftSidePanel.Controls.Add(this.loginPanel);
            this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.leftSidePanel.Name = "leftSidePanel";
            this.leftSidePanel.Size = new System.Drawing.Size(356, 622);
            this.leftSidePanel.TabIndex = 2;
            // 
            // subjectContainerPanel
            // 
            this.subjectContainerPanel.AutoScroll = true;
            this.subjectContainerPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.subjectContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subjectContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectContainerPanel.Location = new System.Drawing.Point(0, 214);
            this.subjectContainerPanel.Name = "subjectContainerPanel";
            this.subjectContainerPanel.Size = new System.Drawing.Size(356, 219);
            this.subjectContainerPanel.TabIndex = 3;
            // 
            // studentInfoPanel
            // 
            this.studentInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentInfoPanel.Controls.Add(this.genderPb);
            this.studentInfoPanel.Controls.Add(this.splitterLabel2);
            this.studentInfoPanel.Controls.Add(this.schoolNameLabel);
            this.studentInfoPanel.Controls.Add(this.schoolYearLabel);
            this.studentInfoPanel.Controls.Add(this.classLabel);
            this.studentInfoPanel.Controls.Add(this.teacherNameLabel);
            this.studentInfoPanel.Controls.Add(this.studentNameLabel);
            this.studentInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.studentInfoPanel.Name = "studentInfoPanel";
            this.studentInfoPanel.Size = new System.Drawing.Size(356, 214);
            this.studentInfoPanel.TabIndex = 4;
            // 
            // splitterLabel2
            // 
            this.splitterLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitterLabel2.Location = new System.Drawing.Point(0, 50);
            this.splitterLabel2.Name = "splitterLabel2";
            this.splitterLabel2.Size = new System.Drawing.Size(356, 2);
            this.splitterLabel2.TabIndex = 5;
            this.splitterLabel2.Tag = " ";
            // 
            // schoolNameLabel
            // 
            this.schoolNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.schoolNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.schoolNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.schoolNameLabel.Location = new System.Drawing.Point(0, 171);
            this.schoolNameLabel.Name = "schoolNameLabel";
            this.schoolNameLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.schoolNameLabel.Size = new System.Drawing.Size(354, 40);
            this.schoolNameLabel.TabIndex = 3;
            this.schoolNameLabel.Tag = "Naziv škole";
            this.schoolNameLabel.Text = "Naziv škole";
            this.schoolNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // schoolYearLabel
            // 
            this.schoolYearLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.schoolYearLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.schoolYearLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.schoolYearLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.schoolYearLabel.Location = new System.Drawing.Point(0, 131);
            this.schoolYearLabel.Name = "schoolYearLabel";
            this.schoolYearLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.schoolYearLabel.Size = new System.Drawing.Size(354, 40);
            this.schoolYearLabel.TabIndex = 2;
            this.schoolYearLabel.Tag = "Školska Godina";
            this.schoolYearLabel.Text = "Školska Godina";
            this.schoolYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classLabel
            // 
            this.classLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.classLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.classLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.classLabel.Location = new System.Drawing.Point(0, 91);
            this.classLabel.Name = "classLabel";
            this.classLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.classLabel.Size = new System.Drawing.Size(354, 40);
            this.classLabel.TabIndex = 1;
            this.classLabel.Tag = "Razred";
            this.classLabel.Text = "Razred";
            this.classLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.teacherNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.teacherNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teacherNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.teacherNameLabel.Location = new System.Drawing.Point(0, 51);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.teacherNameLabel.Size = new System.Drawing.Size(354, 40);
            this.teacherNameLabel.TabIndex = 4;
            this.teacherNameLabel.Tag = "Ime razrednika";
            this.teacherNameLabel.Text = "Ime razrednika";
            this.teacherNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.studentNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.studentNameLabel.Location = new System.Drawing.Point(0, 0);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.studentNameLabel.Size = new System.Drawing.Size(354, 51);
            this.studentNameLabel.TabIndex = 0;
            this.studentNameLabel.Tag = "Ime i Prezime";
            this.studentNameLabel.Text = "Ime i Prezime";
            this.studentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsContainerPanel
            // 
            this.settingsContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsContainerPanel.Controls.Add(this.logoutBtn);
            this.settingsContainerPanel.Controls.Add(this.settingsBtn);
            this.settingsContainerPanel.Controls.Add(this.printBtn);
            this.settingsContainerPanel.Controls.Add(this.statsBtn);
            this.settingsContainerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingsContainerPanel.Location = new System.Drawing.Point(0, 433);
            this.settingsContainerPanel.Name = "settingsContainerPanel";
            this.settingsContainerPanel.Size = new System.Drawing.Size(356, 89);
            this.settingsContainerPanel.TabIndex = 2;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.showPassPb);
            this.loginPanel.Controls.Add(this.splitterLabel);
            this.loginPanel.Controls.Add(this.rememberPassCheckBox);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.passwordTxt);
            this.loginPanel.Controls.Add(this.userNameTxt);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginPanel.Location = new System.Drawing.Point(0, 522);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(356, 100);
            this.loginPanel.TabIndex = 0;
            // 
            // splitterLabel
            // 
            this.splitterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitterLabel.Location = new System.Drawing.Point(264, -2);
            this.splitterLabel.Name = "splitterLabel";
            this.splitterLabel.Size = new System.Drawing.Size(2, 100);
            this.splitterLabel.TabIndex = 7;
            // 
            // rememberPassCheckBox
            // 
            this.rememberPassCheckBox.AutoSize = true;
            this.rememberPassCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.rememberPassCheckBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rememberPassCheckBox.Location = new System.Drawing.Point(6, 73);
            this.rememberPassCheckBox.Name = "rememberPassCheckBox";
            this.rememberPassCheckBox.Size = new System.Drawing.Size(131, 23);
            this.rememberPassCheckBox.TabIndex = 5;
            this.rememberPassCheckBox.Text = "Zapamti lozinku?";
            this.rememberPassCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTxt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.passwordTxt.Location = new System.Drawing.Point(3, 39);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.ShortcutsEnabled = false;
            this.passwordTxt.Size = new System.Drawing.Size(258, 29);
            this.passwordTxt.TabIndex = 4;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            this.passwordTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTxt_KeyDown);
            // 
            // userNameTxt
            // 
            this.userNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.userNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.userNameTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userNameTxt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.userNameTxt.Location = new System.Drawing.Point(3, 4);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(258, 29);
            this.userNameTxt.TabIndex = 3;
            this.userNameTxt.TextChanged += new System.EventHandler(this.userNameTxt_TextChanged);
            this.userNameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameTxt_KeyDown);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.mainContainerPanel);
            this.rightPanel.Controls.Add(this.wbOptionsPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(356, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(828, 622);
            this.rightPanel.TabIndex = 3;
            // 
            // mainContainerPanel
            // 
            this.mainContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.mainContainerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.mainContainerPanel.Name = "mainContainerPanel";
            this.mainContainerPanel.Size = new System.Drawing.Size(828, 622);
            this.mainContainerPanel.TabIndex = 1;
            // 
            // wbOptionsPanel
            // 
            this.wbOptionsPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.wbOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wbOptionsPanel.Controls.Add(this.removeNotesBtn);
            this.wbOptionsPanel.Controls.Add(this.label1);
            this.wbOptionsPanel.Controls.Add(this.refreshwbBtn);
            this.wbOptionsPanel.Controls.Add(this.label2);
            this.wbOptionsPanel.Controls.Add(this.hidewbBtn);
            this.wbOptionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.wbOptionsPanel.Location = new System.Drawing.Point(828, 0);
            this.wbOptionsPanel.Name = "wbOptionsPanel";
            this.wbOptionsPanel.Size = new System.Drawing.Size(0, 622);
            this.wbOptionsPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 3);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 3);
            this.label2.TabIndex = 12;
            // 
            // logoutTimer
            // 
            this.logoutTimer.Interval = 900000;
            this.logoutTimer.Tick += new System.EventHandler(this.logoutTimer_Tick);
            // 
            // removeNotesBtn
            // 
            this.removeNotesBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.removeNotesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeNotesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeNotesBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeNotesBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeNotesBtn.Image")));
            this.removeNotesBtn.Location = new System.Drawing.Point(0, 116);
            this.removeNotesBtn.Name = "removeNotesBtn";
            this.removeNotesBtn.Size = new System.Drawing.Size(0, 55);
            this.removeNotesBtn.TabIndex = 10;
            this.removeNotesBtn.UseVisualStyleBackColor = false;
            this.removeNotesBtn.Click += new System.EventHandler(this.removeNotesBtn_Click);
            // 
            // refreshwbBtn
            // 
            this.refreshwbBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.refreshwbBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.refreshwbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshwbBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshwbBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshwbBtn.Image")));
            this.refreshwbBtn.Location = new System.Drawing.Point(0, 58);
            this.refreshwbBtn.Name = "refreshwbBtn";
            this.refreshwbBtn.Size = new System.Drawing.Size(0, 55);
            this.refreshwbBtn.TabIndex = 9;
            this.refreshwbBtn.UseVisualStyleBackColor = false;
            this.refreshwbBtn.Click += new System.EventHandler(this.refreshwbBtn_Click);
            // 
            // hidewbBtn
            // 
            this.hidewbBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.hidewbBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.hidewbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hidewbBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hidewbBtn.Image = ((System.Drawing.Image)(resources.GetObject("hidewbBtn.Image")));
            this.hidewbBtn.Location = new System.Drawing.Point(0, 0);
            this.hidewbBtn.Name = "hidewbBtn";
            this.hidewbBtn.Size = new System.Drawing.Size(0, 55);
            this.hidewbBtn.TabIndex = 8;
            this.hidewbBtn.UseVisualStyleBackColor = false;
            this.hidewbBtn.Click += new System.EventHandler(this.hidewbBtn_Click);
            // 
            // genderPb
            // 
            this.genderPb.Location = new System.Drawing.Point(0, 0);
            this.genderPb.Name = "genderPb";
            this.genderPb.Size = new System.Drawing.Size(50, 50);
            this.genderPb.TabIndex = 6;
            this.genderPb.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoutBtn.Image = global::EasySchool.Properties.Resources.logout;
            this.logoutBtn.Location = new System.Drawing.Point(267, 0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(89, 87);
            this.logoutBtn.TabIndex = 9;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsBtn.Image = global::EasySchool.Properties.Resources.settings;
            this.settingsBtn.Location = new System.Drawing.Point(178, 0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(89, 87);
            this.settingsBtn.TabIndex = 6;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.printBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.printBtn.Enabled = false;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printBtn.Image = global::EasySchool.Properties.Resources.print;
            this.printBtn.Location = new System.Drawing.Point(89, 0);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(89, 87);
            this.printBtn.TabIndex = 8;
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // statsBtn
            // 
            this.statsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.statsBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.statsBtn.Enabled = false;
            this.statsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statsBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statsBtn.Image = global::EasySchool.Properties.Resources.stats;
            this.statsBtn.Location = new System.Drawing.Point(0, 0);
            this.statsBtn.Name = "statsBtn";
            this.statsBtn.Size = new System.Drawing.Size(89, 87);
            this.statsBtn.TabIndex = 7;
            this.statsBtn.UseVisualStyleBackColor = false;
            this.statsBtn.Click += new System.EventHandler(this.statsBtn_Click);
            // 
            // showPassPb
            // 
            this.showPassPb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.showPassPb.Image = global::EasySchool.Properties.Resources.hidePass;
            this.showPassPb.Location = new System.Drawing.Point(233, 40);
            this.showPassPb.Name = "showPassPb";
            this.showPassPb.Size = new System.Drawing.Size(27, 27);
            this.showPassPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showPassPb.TabIndex = 8;
            this.showPassPb.TabStop = false;
            this.showPassPb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showPassPb_MouseDown);
            this.showPassPb.MouseLeave += new System.EventHandler(this.showPassPb_MouseLeave);
            this.showPassPb.MouseHover += new System.EventHandler(this.showPassPb_MouseHover);
            this.showPassPb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showPassPb_MouseUp);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.loginBtn.Enabled = false;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginBtn.Image = global::EasySchool.Properties.Resources.login;
            this.loginBtn.Location = new System.Drawing.Point(267, 0);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(87, 98);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1184, 622);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftSidePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasySchool";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.leftSidePanel.ResumeLayout(false);
            this.studentInfoPanel.ResumeLayout(false);
            this.settingsContainerPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.wbOptionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genderPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftSidePanel;
        private System.Windows.Forms.Panel settingsContainerPanel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button statsBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Label splitterLabel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel studentInfoPanel;
        private System.Windows.Forms.Label splitterLabel2;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel wbOptionsPanel;
        private System.Windows.Forms.Button refreshwbBtn;
        private System.Windows.Forms.Button hidewbBtn;
        private System.Windows.Forms.Button removeNotesBtn;
        public System.Windows.Forms.TextBox passwordTxt;
        public System.Windows.Forms.TextBox userNameTxt;
        public System.Windows.Forms.CheckBox rememberPassCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel subjectContainerPanel;
        public System.Windows.Forms.Panel mainContainerPanel;
        public System.Windows.Forms.Label studentNameLabel;
        public System.Windows.Forms.Label teacherNameLabel;
        public System.Windows.Forms.Label schoolNameLabel;
        public System.Windows.Forms.Label schoolYearLabel;
        public System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.PictureBox showPassPb;
        private System.Windows.Forms.Timer logoutTimer;
        private System.Windows.Forms.PictureBox genderPb;
    }
}


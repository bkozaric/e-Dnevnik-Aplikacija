namespace EasySchool
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.userListView = new System.Windows.Forms.ListView();
            this.userColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rmbPwdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitterLabel2 = new System.Windows.Forms.Label();
            this.userMngrPanel = new System.Windows.Forms.Panel();
            this.userMngrRightPanel = new System.Windows.Forms.Panel();
            this.botPanel = new System.Windows.Forms.Panel();
            this.autoPickClassCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gradeRangeTxt = new System.Windows.Forms.TextBox();
            this.testRangeTxt = new System.Windows.Forms.TextBox();
            this.showSplashCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splashScreenMs = new System.Windows.Forms.NumericUpDown();
            this.applyTBtn = new System.Windows.Forms.Button();
            this.applyGBtn = new System.Windows.Forms.Button();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.removeUserBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.userMngrPanel.SuspendLayout();
            this.userMngrRightPanel.SuspendLayout();
            this.botPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenMs)).BeginInit();
            this.SuspendLayout();
            // 
            // userListView
            // 
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userColumn,
            this.rmbPwdColumn});
            this.userListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userListView.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.userListView.FullRowSelect = true;
            this.userListView.GridLines = true;
            this.userListView.Location = new System.Drawing.Point(0, 0);
            this.userListView.MultiSelect = false;
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(316, 150);
            this.userListView.TabIndex = 0;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            // 
            // userColumn
            // 
            this.userColumn.Text = "Korisničko ime";
            this.userColumn.Width = 161;
            // 
            // rmbPwdColumn
            // 
            this.rmbPwdColumn.Text = "Lozinka zapamćena?";
            this.rmbPwdColumn.Width = 132;
            // 
            // splitterLabel2
            // 
            this.splitterLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitterLabel2.Location = new System.Drawing.Point(-8, 159);
            this.splitterLabel2.Name = "splitterLabel2";
            this.splitterLabel2.Size = new System.Drawing.Size(494, 2);
            this.splitterLabel2.TabIndex = 10;
            this.splitterLabel2.Tag = " ";
            // 
            // userMngrPanel
            // 
            this.userMngrPanel.Controls.Add(this.userListView);
            this.userMngrPanel.Controls.Add(this.userMngrRightPanel);
            this.userMngrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userMngrPanel.Location = new System.Drawing.Point(0, 0);
            this.userMngrPanel.Name = "userMngrPanel";
            this.userMngrPanel.Size = new System.Drawing.Size(366, 150);
            this.userMngrPanel.TabIndex = 11;
            // 
            // userMngrRightPanel
            // 
            this.userMngrRightPanel.Controls.Add(this.editUserBtn);
            this.userMngrRightPanel.Controls.Add(this.removeUserBtn);
            this.userMngrRightPanel.Controls.Add(this.addUserBtn);
            this.userMngrRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userMngrRightPanel.Location = new System.Drawing.Point(316, 0);
            this.userMngrRightPanel.Name = "userMngrRightPanel";
            this.userMngrRightPanel.Size = new System.Drawing.Size(50, 150);
            this.userMngrRightPanel.TabIndex = 10;
            // 
            // botPanel
            // 
            this.botPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botPanel.Controls.Add(this.splashScreenMs);
            this.botPanel.Controls.Add(this.label3);
            this.botPanel.Controls.Add(this.applyTBtn);
            this.botPanel.Controls.Add(this.applyGBtn);
            this.botPanel.Controls.Add(this.showSplashCheckBox);
            this.botPanel.Controls.Add(this.testRangeTxt);
            this.botPanel.Controls.Add(this.gradeRangeTxt);
            this.botPanel.Controls.Add(this.label2);
            this.botPanel.Controls.Add(this.label1);
            this.botPanel.Controls.Add(this.autoPickClassCheckBox);
            this.botPanel.Location = new System.Drawing.Point(0, 170);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(366, 135);
            this.botPanel.TabIndex = 12;
            // 
            // autoPickClassCheckBox
            // 
            this.autoPickClassCheckBox.AutoSize = true;
            this.autoPickClassCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autoPickClassCheckBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.autoPickClassCheckBox.Location = new System.Drawing.Point(9, 72);
            this.autoPickClassCheckBox.Name = "autoPickClassCheckBox";
            this.autoPickClassCheckBox.Size = new System.Drawing.Size(280, 21);
            this.autoPickClassCheckBox.TabIndex = 0;
            this.autoPickClassCheckBox.Text = "Automatski odaberi prvi razred na popisu";
            this.autoPickClassCheckBox.UseVisualStyleBackColor = true;
            this.autoPickClassCheckBox.CheckedChanged += new System.EventHandler(this.autoPickClassCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Opseg  traženja nedavnih  ocjena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opseg traženja nadolazećih ispita:";
            // 
            // gradeRangeTxt
            // 
            this.gradeRangeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeRangeTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gradeRangeTxt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gradeRangeTxt.Location = new System.Drawing.Point(225, 6);
            this.gradeRangeTxt.Name = "gradeRangeTxt";
            this.gradeRangeTxt.Size = new System.Drawing.Size(96, 27);
            this.gradeRangeTxt.TabIndex = 41;
            this.gradeRangeTxt.TextChanged += new System.EventHandler(this.gradeRangeTxt_TextChanged);
            // 
            // testRangeTxt
            // 
            this.testRangeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testRangeTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testRangeTxt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.testRangeTxt.Location = new System.Drawing.Point(225, 39);
            this.testRangeTxt.Name = "testRangeTxt";
            this.testRangeTxt.Size = new System.Drawing.Size(96, 27);
            this.testRangeTxt.TabIndex = 42;
            this.testRangeTxt.TextChanged += new System.EventHandler(this.testRangeTxt_TextChanged);
            // 
            // showSplashCheckBox
            // 
            this.showSplashCheckBox.AutoSize = true;
            this.showSplashCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showSplashCheckBox.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.showSplashCheckBox.Location = new System.Drawing.Point(9, 102);
            this.showSplashCheckBox.Name = "showSplashCheckBox";
            this.showSplashCheckBox.Size = new System.Drawing.Size(151, 21);
            this.showSplashCheckBox.TabIndex = 43;
            this.showSplashCheckBox.Text = "Prikaži splash screen";
            this.showSplashCheckBox.UseVisualStyleBackColor = true;
            this.showSplashCheckBox.CheckedChanged += new System.EventHandler(this.showSplashCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(227, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "milisekundi.";
            // 
            // splashScreenMs
            // 
            this.splashScreenMs.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.splashScreenMs.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.splashScreenMs.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.splashScreenMs.Location = new System.Drawing.Point(156, 99);
            this.splashScreenMs.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.splashScreenMs.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.splashScreenMs.Name = "splashScreenMs";
            this.splashScreenMs.Size = new System.Drawing.Size(70, 27);
            this.splashScreenMs.TabIndex = 48;
            this.splashScreenMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.splashScreenMs.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.splashScreenMs.ValueChanged += new System.EventHandler(this.splashScreenMs_ValueChanged);
            // 
            // applyTBtn
            // 
            this.applyTBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.applyTBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applyTBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applyTBtn.Image = ((System.Drawing.Image)(resources.GetObject("applyTBtn.Image")));
            this.applyTBtn.Location = new System.Drawing.Point(327, 39);
            this.applyTBtn.Name = "applyTBtn";
            this.applyTBtn.Size = new System.Drawing.Size(27, 27);
            this.applyTBtn.TabIndex = 45;
            this.applyTBtn.UseVisualStyleBackColor = false;
            this.applyTBtn.Click += new System.EventHandler(this.applyTBtn_Click);
            // 
            // applyGBtn
            // 
            this.applyGBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.applyGBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applyGBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.applyGBtn.Image = ((System.Drawing.Image)(resources.GetObject("applyGBtn.Image")));
            this.applyGBtn.Location = new System.Drawing.Point(327, 6);
            this.applyGBtn.Name = "applyGBtn";
            this.applyGBtn.Size = new System.Drawing.Size(27, 27);
            this.applyGBtn.TabIndex = 44;
            this.applyGBtn.UseVisualStyleBackColor = false;
            this.applyGBtn.Click += new System.EventHandler(this.applyGBtn_Click);
            // 
            // editUserBtn
            // 
            this.editUserBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editUserBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.editUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editUserBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editUserBtn.Image = global::EasySchool.Properties.Resources.editUser;
            this.editUserBtn.Location = new System.Drawing.Point(0, 100);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(50, 50);
            this.editUserBtn.TabIndex = 8;
            this.editUserBtn.UseVisualStyleBackColor = false;
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.removeUserBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeUserBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeUserBtn.Image = global::EasySchool.Properties.Resources.removeUser;
            this.removeUserBtn.Location = new System.Drawing.Point(0, 50);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(50, 50);
            this.removeUserBtn.TabIndex = 7;
            this.removeUserBtn.UseVisualStyleBackColor = false;
            this.removeUserBtn.Click += new System.EventHandler(this.removeUserBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addUserBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addUserBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUserBtn.Image = global::EasySchool.Properties.Resources.addUser;
            this.addUserBtn.Location = new System.Drawing.Point(0, 0);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(50, 50);
            this.addUserBtn.TabIndex = 9;
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 305);
            this.Controls.Add(this.botPanel);
            this.Controls.Add(this.userMngrPanel);
            this.Controls.Add(this.splitterLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postavke";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.userMngrPanel.ResumeLayout(false);
            this.userMngrRightPanel.ResumeLayout(false);
            this.botPanel.ResumeLayout(false);
            this.botPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splashScreenMs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.ColumnHeader userColumn;
        private System.Windows.Forms.ColumnHeader rmbPwdColumn;
        private System.Windows.Forms.Button removeUserBtn;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Label splitterLabel2;
        private System.Windows.Forms.Panel userMngrPanel;
        private System.Windows.Forms.Panel userMngrRightPanel;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.CheckBox autoPickClassCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showSplashCheckBox;
        public System.Windows.Forms.TextBox testRangeTxt;
        public System.Windows.Forms.TextBox gradeRangeTxt;
        private System.Windows.Forms.Button applyTBtn;
        private System.Windows.Forms.Button applyGBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown splashScreenMs;
    }
}
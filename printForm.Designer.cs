namespace EasySchool
{
    partial class printForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printForm));
            this.printFgAvgBtn = new System.Windows.Forms.Button();
            this.printAllGradesBtn = new System.Windows.Forms.Button();
            this.printMissingBtn = new System.Windows.Forms.Button();
            this.printConclBtn = new System.Windows.Forms.Button();
            this.printStudentInfoBtn = new System.Windows.Forms.Button();
            this.avgPb = new System.Windows.Forms.PictureBox();
            this.agPb = new System.Windows.Forms.PictureBox();
            this.studInfoPb = new System.Windows.Forms.PictureBox();
            this.conclPb = new System.Windows.Forms.PictureBox();
            this.misPb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.printSfd = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.avgPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studInfoPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conclPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.misPb)).BeginInit();
            this.SuspendLayout();
            // 
            // printFgAvgBtn
            // 
            this.printFgAvgBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.printFgAvgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printFgAvgBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printFgAvgBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.printFgAvgBtn.Location = new System.Drawing.Point(6, 7);
            this.printFgAvgBtn.Name = "printFgAvgBtn";
            this.printFgAvgBtn.Size = new System.Drawing.Size(247, 32);
            this.printFgAvgBtn.TabIndex = 0;
            this.printFgAvgBtn.Tag = "";
            this.printFgAvgBtn.Text = "Ispiši zaključne ocjene i prosjeke";
            this.printFgAvgBtn.UseVisualStyleBackColor = false;
            this.printFgAvgBtn.Click += new System.EventHandler(this.printFgAvgBtn_Click);
            // 
            // printAllGradesBtn
            // 
            this.printAllGradesBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.printAllGradesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printAllGradesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printAllGradesBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.printAllGradesBtn.Location = new System.Drawing.Point(6, 45);
            this.printAllGradesBtn.Name = "printAllGradesBtn";
            this.printAllGradesBtn.Size = new System.Drawing.Size(247, 32);
            this.printAllGradesBtn.TabIndex = 1;
            this.printAllGradesBtn.Tag = "";
            this.printAllGradesBtn.Text = "Ispiši sve ocjene";
            this.printAllGradesBtn.UseVisualStyleBackColor = false;
            this.printAllGradesBtn.Click += new System.EventHandler(this.printAllGradesBtn_Click);
            // 
            // printMissingBtn
            // 
            this.printMissingBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.printMissingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printMissingBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printMissingBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.printMissingBtn.Location = new System.Drawing.Point(6, 83);
            this.printMissingBtn.Name = "printMissingBtn";
            this.printMissingBtn.Size = new System.Drawing.Size(247, 32);
            this.printMissingBtn.TabIndex = 2;
            this.printMissingBtn.Tag = "";
            this.printMissingBtn.Text = "Ispiši izostanke";
            this.printMissingBtn.UseVisualStyleBackColor = false;
            this.printMissingBtn.Click += new System.EventHandler(this.printMissingBtn_Click);
            // 
            // printConclBtn
            // 
            this.printConclBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.printConclBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printConclBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printConclBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.printConclBtn.Location = new System.Drawing.Point(6, 121);
            this.printConclBtn.Name = "printConclBtn";
            this.printConclBtn.Size = new System.Drawing.Size(247, 32);
            this.printConclBtn.TabIndex = 3;
            this.printConclBtn.Tag = "";
            this.printConclBtn.Text = "Ispiši zaključak i dodatne informacije";
            this.printConclBtn.UseVisualStyleBackColor = false;
            this.printConclBtn.Click += new System.EventHandler(this.printConclBtn_Click);
            // 
            // printStudentInfoBtn
            // 
            this.printStudentInfoBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.printStudentInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printStudentInfoBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printStudentInfoBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.printStudentInfoBtn.Location = new System.Drawing.Point(6, 159);
            this.printStudentInfoBtn.Name = "printStudentInfoBtn";
            this.printStudentInfoBtn.Size = new System.Drawing.Size(247, 32);
            this.printStudentInfoBtn.TabIndex = 4;
            this.printStudentInfoBtn.Tag = "";
            this.printStudentInfoBtn.Text = "Ispiši osnovne podatke o učeniku";
            this.printStudentInfoBtn.UseVisualStyleBackColor = false;
            this.printStudentInfoBtn.Click += new System.EventHandler(this.printStudentInfoBtn_Click);
            // 
            // avgPb
            // 
            this.avgPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgPb.Image = global::EasySchool.Properties.Resources.unCheckMark;
            this.avgPb.Location = new System.Drawing.Point(259, 7);
            this.avgPb.Name = "avgPb";
            this.avgPb.Size = new System.Drawing.Size(32, 32);
            this.avgPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.avgPb.TabIndex = 5;
            this.avgPb.TabStop = false;
            this.avgPb.Tag = "avg";
            // 
            // agPb
            // 
            this.agPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.agPb.Image = global::EasySchool.Properties.Resources.unCheckMark;
            this.agPb.Location = new System.Drawing.Point(259, 45);
            this.agPb.Name = "agPb";
            this.agPb.Size = new System.Drawing.Size(32, 32);
            this.agPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.agPb.TabIndex = 6;
            this.agPb.TabStop = false;
            this.agPb.Tag = "ag";
            // 
            // studInfoPb
            // 
            this.studInfoPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studInfoPb.Image = global::EasySchool.Properties.Resources.unCheckMark;
            this.studInfoPb.Location = new System.Drawing.Point(259, 159);
            this.studInfoPb.Name = "studInfoPb";
            this.studInfoPb.Size = new System.Drawing.Size(32, 32);
            this.studInfoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.studInfoPb.TabIndex = 7;
            this.studInfoPb.TabStop = false;
            // 
            // conclPb
            // 
            this.conclPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conclPb.Image = global::EasySchool.Properties.Resources.unCheckMark;
            this.conclPb.Location = new System.Drawing.Point(259, 121);
            this.conclPb.Name = "conclPb";
            this.conclPb.Size = new System.Drawing.Size(32, 32);
            this.conclPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.conclPb.TabIndex = 8;
            this.conclPb.TabStop = false;
            this.conclPb.Tag = "concl";
            // 
            // misPb
            // 
            this.misPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.misPb.Image = global::EasySchool.Properties.Resources.unCheckMark;
            this.misPb.Location = new System.Drawing.Point(259, 83);
            this.misPb.Name = "misPb";
            this.misPb.Size = new System.Drawing.Size(32, 32);
            this.misPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.misPb.TabIndex = 9;
            this.misPb.TabStop = false;
            this.misPb.Tag = "missing";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-7, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 2);
            this.label1.TabIndex = 11;
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.printBtn.Enabled = false;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.printBtn.Location = new System.Drawing.Point(195, 212);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(96, 32);
            this.printBtn.TabIndex = 12;
            this.printBtn.Tag = "";
            this.printBtn.Text = "Ispis";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // printSfd
            // 
            this.printSfd.DefaultExt = "html";
            this.printSfd.Filter = "HTML (Hypertext Markup Language)| .html";
            this.printSfd.FileOk += new System.ComponentModel.CancelEventHandler(this.printSfd_FileOk);
            // 
            // printForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(296, 251);
            this.Controls.Add(this.avgPb);
            this.Controls.Add(this.misPb);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.agPb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conclPb);
            this.Controls.Add(this.studInfoPb);
            this.Controls.Add(this.printStudentInfoBtn);
            this.Controls.Add(this.printConclBtn);
            this.Controls.Add(this.printMissingBtn);
            this.Controls.Add(this.printAllGradesBtn);
            this.Controls.Add(this.printFgAvgBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "printForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ispis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.printForm_FormClosing);
            this.Load += new System.EventHandler(this.printForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avgPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studInfoPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conclPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.misPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printFgAvgBtn;
        private System.Windows.Forms.Button printAllGradesBtn;
        private System.Windows.Forms.Button printMissingBtn;
        private System.Windows.Forms.Button printConclBtn;
        private System.Windows.Forms.Button printStudentInfoBtn;
        private System.Windows.Forms.PictureBox avgPb;
        private System.Windows.Forms.PictureBox agPb;
        private System.Windows.Forms.PictureBox studInfoPb;
        private System.Windows.Forms.PictureBox conclPb;
        private System.Windows.Forms.PictureBox misPb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.SaveFileDialog printSfd;
    }
}
namespace EasySchool
{
    partial class addNewUserForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newPassTxt = new System.Windows.Forms.TextBox();
            this.newUserTxt = new System.Windows.Forms.TextBox();
            this.passIndicator = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-4, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 2);
            this.label3.TabIndex = 45;
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addUserBtn.Enabled = false;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUserBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addUserBtn.Location = new System.Drawing.Point(123, 131);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(125, 29);
            this.addUserBtn.TabIndex = 44;
            this.addUserBtn.Text = "Dodaj korisnika";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Lozinka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Korisničko ime";
            // 
            // newPassTxt
            // 
            this.newPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newPassTxt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.newPassTxt.Location = new System.Drawing.Point(13, 80);
            this.newPassTxt.Name = "newPassTxt";
            this.newPassTxt.ShortcutsEnabled = false;
            this.newPassTxt.Size = new System.Drawing.Size(228, 27);
            this.newPassTxt.TabIndex = 41;
            this.newPassTxt.UseSystemPasswordChar = true;
            this.newPassTxt.TextChanged += new System.EventHandler(this.newPassTxt_TextChanged);
            // 
            // newUserTxt
            // 
            this.newUserTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newUserTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newUserTxt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.newUserTxt.Location = new System.Drawing.Point(13, 26);
            this.newUserTxt.Name = "newUserTxt";
            this.newUserTxt.Size = new System.Drawing.Size(228, 27);
            this.newUserTxt.TabIndex = 40;
            this.newUserTxt.TextChanged += new System.EventHandler(this.newUserTxt_TextChanged);
            // 
            // passIndicator
            // 
            this.passIndicator.BackColor = System.Drawing.Color.Red;
            this.passIndicator.Location = new System.Drawing.Point(12, 79);
            this.passIndicator.Name = "passIndicator";
            this.passIndicator.Size = new System.Drawing.Size(230, 29);
            this.passIndicator.TabIndex = 46;
            // 
            // addNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(255, 167);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPassTxt);
            this.Controls.Add(this.newUserTxt);
            this.Controls.Add(this.passIndicator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addNewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi korisnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox newPassTxt;
        public System.Windows.Forms.TextBox newUserTxt;
        private System.Windows.Forms.Panel passIndicator;
    }
}
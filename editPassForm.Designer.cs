namespace EasySchool
{
    partial class editPassForm
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
            this.oldPassTxt = new System.Windows.Forms.TextBox();
            this.newPassTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editPass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassIndicator = new System.Windows.Forms.Panel();
            this.oldPassIndicator = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // oldPassTxt
            // 
            this.oldPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldPassTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oldPassTxt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.oldPassTxt.Location = new System.Drawing.Point(13, 26);
            this.oldPassTxt.Name = "oldPassTxt";
            this.oldPassTxt.ShortcutsEnabled = false;
            this.oldPassTxt.Size = new System.Drawing.Size(228, 27);
            this.oldPassTxt.TabIndex = 4;
            this.oldPassTxt.UseSystemPasswordChar = true;
            this.oldPassTxt.TextChanged += new System.EventHandler(this.oldPassTxt_TextChanged);
            // 
            // newPassTxt
            // 
            this.newPassTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassTxt.Enabled = false;
            this.newPassTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newPassTxt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.newPassTxt.Location = new System.Drawing.Point(13, 80);
            this.newPassTxt.Name = "newPassTxt";
            this.newPassTxt.ShortcutsEnabled = false;
            this.newPassTxt.Size = new System.Drawing.Size(228, 27);
            this.newPassTxt.TabIndex = 5;
            this.newPassTxt.UseSystemPasswordChar = true;
            this.newPassTxt.TextChanged += new System.EventHandler(this.newPassTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Stara lozinka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nova lozinka";
            // 
            // editPass
            // 
            this.editPass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editPass.Enabled = false;
            this.editPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editPass.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.editPass.Location = new System.Drawing.Point(123, 131);
            this.editPass.Name = "editPass";
            this.editPass.Size = new System.Drawing.Size(125, 29);
            this.editPass.TabIndex = 38;
            this.editPass.Text = "Promjeni lozinku";
            this.editPass.UseVisualStyleBackColor = false;
            this.editPass.Click += new System.EventHandler(this.editPass_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-4, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 2);
            this.label3.TabIndex = 39;
            // 
            // newPassIndicator
            // 
            this.newPassIndicator.BackColor = System.Drawing.Color.Red;
            this.newPassIndicator.Location = new System.Drawing.Point(12, 79);
            this.newPassIndicator.Name = "newPassIndicator";
            this.newPassIndicator.Size = new System.Drawing.Size(230, 29);
            this.newPassIndicator.TabIndex = 40;
            // 
            // oldPassIndicator
            // 
            this.oldPassIndicator.BackColor = System.Drawing.Color.Red;
            this.oldPassIndicator.Location = new System.Drawing.Point(12, 25);
            this.oldPassIndicator.Name = "oldPassIndicator";
            this.oldPassIndicator.Size = new System.Drawing.Size(230, 29);
            this.oldPassIndicator.TabIndex = 41;
            // 
            // editPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(255, 167);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.editPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPassTxt);
            this.Controls.Add(this.oldPassTxt);
            this.Controls.Add(this.newPassIndicator);
            this.Controls.Add(this.oldPassIndicator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editPassForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena lozinke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox oldPassTxt;
        public System.Windows.Forms.TextBox newPassTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel newPassIndicator;
        private System.Windows.Forms.Panel oldPassIndicator;
    }
}
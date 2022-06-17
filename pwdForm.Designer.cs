namespace EasySchool
{
    partial class pwdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pwdForm));
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeUserBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passIndicator = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // passTxt
            // 
            this.passTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passTxt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.passTxt.Location = new System.Drawing.Point(13, 26);
            this.passTxt.Name = "passTxt";
            this.passTxt.ShortcutsEnabled = false;
            this.passTxt.Size = new System.Drawing.Size(228, 27);
            this.passTxt.TabIndex = 4;
            this.passTxt.UseSystemPasswordChar = true;
            this.passTxt.TextChanged += new System.EventHandler(this.passTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lozinka";
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeUserBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.removeUserBtn.Enabled = false;
            this.removeUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeUserBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeUserBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.removeUserBtn.Location = new System.Drawing.Point(123, 77);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(125, 29);
            this.removeUserBtn.TabIndex = 38;
            this.removeUserBtn.Text = "Izbriši korisnika";
            this.removeUserBtn.UseVisualStyleBackColor = false;
            this.removeUserBtn.Click += new System.EventHandler(this.removeUserBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-4, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 2);
            this.label3.TabIndex = 39;
            // 
            // passIndicator
            // 
            this.passIndicator.BackColor = System.Drawing.Color.Red;
            this.passIndicator.Location = new System.Drawing.Point(12, 25);
            this.passIndicator.Name = "passIndicator";
            this.passIndicator.Size = new System.Drawing.Size(230, 29);
            this.passIndicator.TabIndex = 41;
            // 
            // pwdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(255, 113);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.removeUserBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.passIndicator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pwdForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brisanje korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeUserBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel passIndicator;
    }
}
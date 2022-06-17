namespace EasySchool
{
    partial class changeRangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeRangeForm));
            this.newRangeTxt = new System.Windows.Forms.TextBox();
            this.newRangeLabel = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.splitterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newRangeTxt
            // 
            this.newRangeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newRangeTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newRangeTxt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.newRangeTxt.Location = new System.Drawing.Point(13, 26);
            this.newRangeTxt.MaxLength = 3;
            this.newRangeTxt.Name = "newRangeTxt";
            this.newRangeTxt.ShortcutsEnabled = false;
            this.newRangeTxt.Size = new System.Drawing.Size(228, 27);
            this.newRangeTxt.TabIndex = 4;
            this.newRangeTxt.TextChanged += new System.EventHandler(this.newRangeTxt_TextChanged);
            this.newRangeTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newRangeTxt_KeyDown);
            // 
            // newRangeLabel
            // 
            this.newRangeLabel.AutoSize = true;
            this.newRangeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newRangeLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.newRangeLabel.Location = new System.Drawing.Point(10, 6);
            this.newRangeLabel.Name = "newRangeLabel";
            this.newRangeLabel.Size = new System.Drawing.Size(76, 17);
            this.newRangeLabel.TabIndex = 6;
            this.newRangeLabel.Text = "Novi opseg";
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchBtn.Enabled = false;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.searchBtn.Location = new System.Drawing.Point(152, 77);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(96, 29);
            this.searchBtn.TabIndex = 38;
            this.searchBtn.Text = "Pretraži";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // splitterLabel
            // 
            this.splitterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitterLabel.Location = new System.Drawing.Point(-4, 64);
            this.splitterLabel.Name = "splitterLabel";
            this.splitterLabel.Size = new System.Drawing.Size(270, 2);
            this.splitterLabel.TabIndex = 39;
            // 
            // changeRangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(255, 113);
            this.Controls.Add(this.splitterLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.newRangeLabel);
            this.Controls.Add(this.newRangeTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "changeRangeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox newRangeTxt;
        private System.Windows.Forms.Label newRangeLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label splitterLabel;
    }
}
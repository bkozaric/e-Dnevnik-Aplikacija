namespace EasySchool
{
    partial class pickClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pickClass));
            this.classListLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.pickClassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classListLV
            // 
            this.classListLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classListLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.classListLV.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.classListLV.FullRowSelect = true;
            this.classListLV.Location = new System.Drawing.Point(6, 5);
            this.classListLV.MultiSelect = false;
            this.classListLV.Name = "classListLV";
            this.classListLV.Size = new System.Drawing.Size(623, 166);
            this.classListLV.TabIndex = 0;
            this.classListLV.UseCompatibleStateImageBehavior = false;
            this.classListLV.View = System.Windows.Forms.View.Details;
            this.classListLV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.classListLV_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Razred";
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Školska god.";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Škola";
            this.columnHeader3.Width = 242;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Razrednik/ica";
            this.columnHeader4.Width = 190;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-15, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(665, 2);
            this.label3.TabIndex = 42;
            // 
            // pickClassBtn
            // 
            this.pickClassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pickClassBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pickClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickClassBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickClassBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pickClassBtn.Image = global::EasySchool.Properties.Resources.checkmark;
            this.pickClassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pickClassBtn.Location = new System.Drawing.Point(535, 190);
            this.pickClassBtn.Name = "pickClassBtn";
            this.pickClassBtn.Size = new System.Drawing.Size(94, 33);
            this.pickClassBtn.TabIndex = 1;
            this.pickClassBtn.Text = "     Odaberi";
            this.pickClassBtn.UseVisualStyleBackColor = false;
            this.pickClassBtn.Click += new System.EventHandler(this.pickClassBtn_Click);
            // 
            // pickClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 229);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pickClassBtn);
            this.Controls.Add(this.classListLV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pickClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odaberi razred";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pickClass_FormClosing);
            this.Load += new System.EventHandler(this.pickClass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView classListLV;
        private System.Windows.Forms.Button pickClassBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
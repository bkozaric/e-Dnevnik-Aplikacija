namespace EasySchool
{
    partial class gradeStatsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gradeStatsForm));
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.botPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.grade1Perc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grade2Perc = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grade3Perc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grade4Perc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grade5Perc = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.certainGradePercentageLabel = new System.Windows.Forms.Label();
            this.seperatorPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.grade1Count = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grade2Count = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grade3Count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grade4Count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grade5Count = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.certainGradeCountLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.finalLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gradeCountLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mainStatsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.barChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.botPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.seperatorPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lineChart
            // 
            this.lineChart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX2.LineWidth = 0;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = 1D;
            chartArea1.AxisY2.IsMarginVisible = false;
            chartArea1.BorderWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea1);
            this.lineChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineChart.Location = new System.Drawing.Point(0, 0);
            this.lineChart.Name = "lineChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.MarkerBorderWidth = 5;
            series1.MarkerSize = 8;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 5;
            this.lineChart.Series.Add(series1);
            this.lineChart.Size = new System.Drawing.Size(366, 211);
            this.lineChart.TabIndex = 0;
            this.lineChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.ForeColor = System.Drawing.Color.CornflowerBlue;
            title1.Name = "Title1";
            title1.Text = "Dijagram povijesti ocjena";
            this.lineChart.Titles.Add(title1);
            // 
            // botPanel
            // 
            this.botPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.botPanel.Controls.Add(this.rightPanel);
            this.botPanel.Controls.Add(this.seperatorPanel);
            this.botPanel.Controls.Add(this.leftPanel);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.botPanel.Location = new System.Drawing.Point(0, 213);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(748, 266);
            this.botPanel.TabIndex = 1;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.grade1Perc);
            this.rightPanel.Controls.Add(this.label4);
            this.rightPanel.Controls.Add(this.grade2Perc);
            this.rightPanel.Controls.Add(this.label8);
            this.rightPanel.Controls.Add(this.grade3Perc);
            this.rightPanel.Controls.Add(this.label10);
            this.rightPanel.Controls.Add(this.grade4Perc);
            this.rightPanel.Controls.Add(this.label12);
            this.rightPanel.Controls.Add(this.grade5Perc);
            this.rightPanel.Controls.Add(this.label14);
            this.rightPanel.Controls.Add(this.certainGradePercentageLabel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightPanel.Location = new System.Drawing.Point(381, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(366, 266);
            this.rightPanel.TabIndex = 1;
            // 
            // grade1Perc
            // 
            this.grade1Perc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grade1Perc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grade1Perc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grade1Perc.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grade1Perc.Location = new System.Drawing.Point(0, 226);
            this.grade1Perc.Name = "grade1Perc";
            this.grade1Perc.Size = new System.Drawing.Size(366, 41);
            this.grade1Perc.TabIndex = 56;
            this.grade1Perc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 2);
            this.label4.TabIndex = 55;
            // 
            // grade2Perc
            // 
            this.grade2Perc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grade2Perc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grade2Perc.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grade2Perc.Location = new System.Drawing.Point(0, 183);
            this.grade2Perc.Name = "grade2Perc";
            this.grade2Perc.Size = new System.Drawing.Size(366, 41);
            this.grade2Perc.TabIndex = 54;
            this.grade2Perc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(366, 2);
            this.label8.TabIndex = 53;
            // 
            // grade3Perc
            // 
            this.grade3Perc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grade3Perc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grade3Perc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grade3Perc.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grade3Perc.Location = new System.Drawing.Point(0, 140);
            this.grade3Perc.Name = "grade3Perc";
            this.grade3Perc.Size = new System.Drawing.Size(366, 41);
            this.grade3Perc.TabIndex = 52;
            this.grade3Perc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(0, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(366, 2);
            this.label10.TabIndex = 51;
            // 
            // grade4Perc
            // 
            this.grade4Perc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grade4Perc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grade4Perc.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grade4Perc.Location = new System.Drawing.Point(0, 97);
            this.grade4Perc.Name = "grade4Perc";
            this.grade4Perc.Size = new System.Drawing.Size(366, 41);
            this.grade4Perc.TabIndex = 50;
            this.grade4Perc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(0, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(366, 2);
            this.label12.TabIndex = 49;
            // 
            // grade5Perc
            // 
            this.grade5Perc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grade5Perc.Dock = System.Windows.Forms.DockStyle.Top;
            this.grade5Perc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grade5Perc.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grade5Perc.Location = new System.Drawing.Point(0, 54);
            this.grade5Perc.Name = "grade5Perc";
            this.grade5Perc.Size = new System.Drawing.Size(366, 41);
            this.grade5Perc.TabIndex = 46;
            this.grade5Perc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Location = new System.Drawing.Point(0, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(366, 2);
            this.label14.TabIndex = 48;
            // 
            // certainGradePercentageLabel
            // 
            this.certainGradePercentageLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.certainGradePercentageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.certainGradePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold);
            this.certainGradePercentageLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.certainGradePercentageLabel.Location = new System.Drawing.Point(0, 0);
            this.certainGradePercentageLabel.Name = "certainGradePercentageLabel";
            this.certainGradePercentageLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.certainGradePercentageLabel.Size = new System.Drawing.Size(366, 52);
            this.certainGradePercentageLabel.TabIndex = 47;
            this.certainGradePercentageLabel.Text = "Postotak pojedinih ocjena";
            this.certainGradePercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seperatorPanel
            // 
            this.seperatorPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.seperatorPanel.Controls.Add(this.label11);
            this.seperatorPanel.Controls.Add(this.label9);
            this.seperatorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.seperatorPanel.Location = new System.Drawing.Point(366, 0);
            this.seperatorPanel.Name = "seperatorPanel";
            this.seperatorPanel.Size = new System.Drawing.Size(15, 266);
            this.seperatorPanel.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(2, 266);
            this.label11.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Location = new System.Drawing.Point(13, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 266);
            this.label9.TabIndex = 52;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.grade1Count);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.grade2Count);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.grade3Count);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.grade4Count);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.grade5Count);
            this.leftPanel.Controls.Add(this.label35);
            this.leftPanel.Controls.Add(this.certainGradeCountLabel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(366, 266);
            this.leftPanel.TabIndex = 0;
            // 
            // grade1Count
            // 
            this.grade1Count.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grade1Count.Dock = System.Windows.Forms.DockStyle.Top;
            this.grade1Count.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grade1Count.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grade1Count.Location = new System.Drawing.Point(0, 226);
            this.grade1Count.Name = "grade1Count";
            this.grade1Count.Size = new System.Drawing.Size(366, 41);
            this.grade1Count.TabIndex = 56;
            this.grade1Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(366, 2);
            this.label6.TabIndex = 55;
            // 
            // grade2Count
            // 
            this.grade2Count.Dock = System.Windows.Forms.DockStyle.Top;
            this.grade2Count.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grade2Count.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grade2Count.Location = new System.Drawing.Point(0, 183);
            this.grade2Count.Name = "grade2Count";
            this.grade2Count.Size = new System.Drawing.Size(366, 41);
            this.grade2Count.TabIndex = 54;
            this.grade2Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(366, 2);
            this.label5.TabIndex = 53;
            // 
            // grade3Count
            // 
            this.grade3Count.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grade3Count.Dock = System.Windows.Forms.DockStyle.Top;
            this.grade3Count.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grade3Count.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grade3Count.Location = new System.Drawing.Point(0, 140);
            this.grade3Count.Name = "grade3Count";
            this.grade3Count.Size = new System.Drawing.Size(366, 41);
            this.grade3Count.TabIndex = 52;
            this.grade3Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 2);
            this.label3.TabIndex = 51;
            // 
            // grade4Count
            // 
            this.grade4Count.Dock = System.Windows.Forms.DockStyle.Top;
            this.grade4Count.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grade4Count.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grade4Count.Location = new System.Drawing.Point(0, 97);
            this.grade4Count.Name = "grade4Count";
            this.grade4Count.Size = new System.Drawing.Size(366, 41);
            this.grade4Count.TabIndex = 50;
            this.grade4Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 2);
            this.label2.TabIndex = 49;
            // 
            // grade5Count
            // 
            this.grade5Count.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grade5Count.Dock = System.Windows.Forms.DockStyle.Top;
            this.grade5Count.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.grade5Count.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.grade5Count.Location = new System.Drawing.Point(0, 54);
            this.grade5Count.Name = "grade5Count";
            this.grade5Count.Size = new System.Drawing.Size(366, 41);
            this.grade5Count.TabIndex = 46;
            this.grade5Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label35.Dock = System.Windows.Forms.DockStyle.Top;
            this.label35.Location = new System.Drawing.Point(0, 52);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(366, 2);
            this.label35.TabIndex = 48;
            // 
            // certainGradeCountLabel
            // 
            this.certainGradeCountLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.certainGradeCountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.certainGradeCountLabel.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold);
            this.certainGradeCountLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.certainGradeCountLabel.Location = new System.Drawing.Point(0, 0);
            this.certainGradeCountLabel.Name = "certainGradeCountLabel";
            this.certainGradeCountLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.certainGradeCountLabel.Size = new System.Drawing.Size(366, 52);
            this.certainGradeCountLabel.TabIndex = 47;
            this.certainGradeCountLabel.Text = "Broj pojedinih ocjena";
            this.certainGradeCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.finalLabel);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.averageLabel);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.gradeCountLabel);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.mainStatsLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 184);
            this.panel1.TabIndex = 2;
            // 
            // finalLabel
            // 
            this.finalLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.finalLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.finalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.finalLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.finalLabel.Location = new System.Drawing.Point(0, 142);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(748, 41);
            this.finalLabel.TabIndex = 52;
            this.finalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Location = new System.Drawing.Point(0, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(748, 2);
            this.label15.TabIndex = 51;
            // 
            // averageLabel
            // 
            this.averageLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.averageLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.averageLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.averageLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.averageLabel.Location = new System.Drawing.Point(0, 99);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(748, 41);
            this.averageLabel.TabIndex = 50;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Location = new System.Drawing.Point(0, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(748, 2);
            this.label17.TabIndex = 49;
            // 
            // gradeCountLabel
            // 
            this.gradeCountLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gradeCountLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradeCountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.gradeCountLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.gradeCountLabel.Location = new System.Drawing.Point(0, 56);
            this.gradeCountLabel.Name = "gradeCountLabel";
            this.gradeCountLabel.Size = new System.Drawing.Size(748, 41);
            this.gradeCountLabel.TabIndex = 46;
            this.gradeCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Location = new System.Drawing.Point(0, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(748, 2);
            this.label19.TabIndex = 48;
            // 
            // mainStatsLabel
            // 
            this.mainStatsLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainStatsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainStatsLabel.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold);
            this.mainStatsLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mainStatsLabel.Location = new System.Drawing.Point(0, 2);
            this.mainStatsLabel.Name = "mainStatsLabel";
            this.mainStatsLabel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.mainStatsLabel.Size = new System.Drawing.Size(748, 52);
            this.mainStatsLabel.TabIndex = 47;
            this.mainStatsLabel.Text = "Opća statistika predmeta";
            this.mainStatsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 2);
            this.label1.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(748, 2);
            this.label7.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.lineChart);
            this.panel2.Controls.Add(this.barChart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 211);
            this.panel2.TabIndex = 51;
            // 
            // barChart
            // 
            this.barChart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.Maximum = 6D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX2.LineWidth = 0;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY2.IsMarginVisible = false;
            chartArea2.BorderWidth = 5;
            chartArea2.Name = "ChartArea1";
            this.barChart.ChartAreas.Add(chartArea2);
            this.barChart.Dock = System.Windows.Forms.DockStyle.Right;
            this.barChart.Location = new System.Drawing.Point(366, 0);
            this.barChart.Name = "barChart";
            series2.ChartArea = "ChartArea1";
            series2.MarkerBorderWidth = 5;
            series2.MarkerSize = 8;
            series2.Name = "Series1";
            series2.YValuesPerPoint = 5;
            this.barChart.Series.Add(series2);
            this.barChart.Size = new System.Drawing.Size(382, 211);
            this.barChart.TabIndex = 1;
            this.barChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title2.ForeColor = System.Drawing.Color.CornflowerBlue;
            title2.Name = "Title1";
            title2.Text = "Histogram ocjena";
            this.barChart.Titles.Add(title2);
            // 
            // gradeStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botPanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gradeStatsForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistika ocjena za predmet ";
            this.Load += new System.EventHandler(this.graphForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.botPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.seperatorPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.Panel botPanel;
        private System.Windows.Forms.Panel rightPanel;
        public System.Windows.Forms.Label grade1Perc;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label grade2Perc;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label grade3Perc;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label grade4Perc;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label grade5Perc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label certainGradePercentageLabel;
        private System.Windows.Forms.Panel seperatorPanel;
        private System.Windows.Forms.Panel leftPanel;
        public System.Windows.Forms.Label grade1Count;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label grade2Count;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label grade3Count;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label grade4Count;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label grade5Count;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label certainGradeCountLabel;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label gradeCountLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label mainStatsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart barChart;
    }
}
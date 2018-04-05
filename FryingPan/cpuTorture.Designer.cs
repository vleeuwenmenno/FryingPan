namespace FryingPan
{
    partial class cpuTorture
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.uiUpdater = new System.Windows.Forms.Timer(this.components);
            this.cpuUsage = new System.Windows.Forms.Label();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.threadCount = new System.Windows.Forms.NumericUpDown();
            this.sqrtChck = new System.Windows.Forms.CheckBox();
            this.powChk = new System.Windows.Forms.CheckBox();
            this.cpuName = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiUpdater
            // 
            this.uiUpdater.Enabled = true;
            this.uiUpdater.Interval = 500;
            this.uiUpdater.Tick += new System.EventHandler(this.uiUpdater_Tick);
            // 
            // cpuUsage
            // 
            this.cpuUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuUsage.AutoSize = true;
            this.cpuUsage.BackColor = System.Drawing.Color.White;
            this.cpuUsage.Location = new System.Drawing.Point(748, 121);
            this.cpuUsage.Name = "cpuUsage";
            this.cpuUsage.Size = new System.Drawing.Size(63, 13);
            this.cpuUsage.TabIndex = 2;
            this.cpuUsage.Text = "CPU Usage";
            // 
            // cpuChart
            // 
            this.cpuChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.cpuChart.Legends.Add(legend5);
            this.cpuChart.Location = new System.Drawing.Point(12, 12);
            this.cpuChart.Name = "cpuChart";
            this.cpuChart.Size = new System.Drawing.Size(836, 258);
            this.cpuChart.TabIndex = 1;
            this.cpuChart.Text = "CPU Usage";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Turn up the heater";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(123, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 216);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thread #";
            // 
            // threadCount
            // 
            this.threadCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.threadCount.Location = new System.Drawing.Point(12, 470);
            this.threadCount.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.threadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadCount.Name = "threadCount";
            this.threadCount.Size = new System.Drawing.Size(105, 20);
            this.threadCount.TabIndex = 6;
            this.threadCount.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // sqrtChck
            // 
            this.sqrtChck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sqrtChck.AutoSize = true;
            this.sqrtChck.Checked = true;
            this.sqrtChck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sqrtChck.Location = new System.Drawing.Point(12, 496);
            this.sqrtChck.Name = "sqrtChck";
            this.sqrtChck.Size = new System.Drawing.Size(43, 17);
            this.sqrtChck.TabIndex = 0;
            this.sqrtChck.Text = "sqrt";
            this.sqrtChck.UseVisualStyleBackColor = true;
            // 
            // powChk
            // 
            this.powChk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.powChk.AutoSize = true;
            this.powChk.Checked = true;
            this.powChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.powChk.Location = new System.Drawing.Point(12, 519);
            this.powChk.Name = "powChk";
            this.powChk.Size = new System.Drawing.Size(46, 17);
            this.powChk.TabIndex = 7;
            this.powChk.Text = "pow";
            this.powChk.UseVisualStyleBackColor = true;
            // 
            // cpuName
            // 
            this.cpuName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpuName.AutoSize = true;
            this.cpuName.Location = new System.Drawing.Point(592, 456);
            this.cpuName.Name = "cpuName";
            this.cpuName.Size = new System.Drawing.Size(155, 39);
            this.cpuName.TabIndex = 8;
            this.cpuName.Text = "CPU NAME BLA BLA BLA BLA\r\n99 CORES - 99 THREADS\r\nHyperthreading: ";
            this.cpuName.Click += new System.EventHandler(this.cpuName_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(12, 276);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(836, 172);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "CPU Temperature";
            // 
            // cpuTorture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 674);
            this.Controls.Add(this.cpuName);
            this.Controls.Add(this.powChk);
            this.Controls.Add(this.cpuUsage);
            this.Controls.Add(this.sqrtChck);
            this.Controls.Add(this.threadCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cpuChart);
            this.Controls.Add(this.chart1);
            this.Name = "cpuTorture";
            this.Text = "Emergency Heater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cpuTorture_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer uiUpdater;
        private System.Windows.Forms.Label cpuUsage;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown threadCount;
        private System.Windows.Forms.CheckBox sqrtChck;
        private System.Windows.Forms.CheckBox powChk;
        private System.Windows.Forms.Label cpuName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
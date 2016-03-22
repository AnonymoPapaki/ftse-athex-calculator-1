namespace ftse_athex_calculator
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTarFTSE = new System.Windows.Forms.TextBox();
            this.tbCurFTSE = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBanks41 = new System.Windows.Forms.Button();
            this.btBanks31 = new System.Windows.Forms.Button();
            this.btBanks21 = new System.Windows.Forms.Button();
            this.btBanks11 = new System.Windows.Forms.Button();
            this.btBanks01 = new System.Windows.Forms.Button();
            this.btBanks40 = new System.Windows.Forms.Button();
            this.btBanks30 = new System.Windows.Forms.Button();
            this.btBanks20 = new System.Windows.Forms.Button();
            this.btBanks10 = new System.Windows.Forms.Button();
            this.btBanks00 = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTakeSnapshot = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(174, 33);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTarFTSE);
            this.groupBox1.Controls.Add(this.tbCurFTSE);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Location = new System.Drawing.Point(369, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 94);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTSE/ASE 20";
            // 
            // tbTarFTSE
            // 
            this.tbTarFTSE.Location = new System.Drawing.Point(56, 49);
            this.tbTarFTSE.Name = "tbTarFTSE";
            this.tbTarFTSE.Size = new System.Drawing.Size(100, 20);
            this.tbTarFTSE.TabIndex = 3;
            // 
            // tbCurFTSE
            // 
            this.tbCurFTSE.Location = new System.Drawing.Point(56, 23);
            this.tbCurFTSE.Name = "tbCurFTSE";
            this.tbCurFTSE.Size = new System.Drawing.Size(100, 20);
            this.tbCurFTSE.TabIndex = 2;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 52);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 13);
            this.label29.TabIndex = 1;
            this.label29.Text = "Target:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 26);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 0;
            this.label28.Text = "Current:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(378, 209);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 17);
            this.checkBox1.TabIndex = 78;
            this.checkBox1.Text = "Real time feed";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBanks41);
            this.groupBox2.Controls.Add(this.btBanks31);
            this.groupBox2.Controls.Add(this.btBanks21);
            this.groupBox2.Controls.Add(this.btBanks11);
            this.groupBox2.Controls.Add(this.btBanks01);
            this.groupBox2.Controls.Add(this.btBanks40);
            this.groupBox2.Controls.Add(this.btBanks30);
            this.groupBox2.Controls.Add(this.btBanks20);
            this.groupBox2.Controls.Add(this.btBanks10);
            this.groupBox2.Controls.Add(this.btBanks00);
            this.groupBox2.Location = new System.Drawing.Point(583, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 156);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Banks";
            // 
            // btBanks41
            // 
            this.btBanks41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btBanks41.Enabled = false;
            this.btBanks41.Location = new System.Drawing.Point(65, 123);
            this.btBanks41.Name = "btBanks41";
            this.btBanks41.Size = new System.Drawing.Size(53, 23);
            this.btBanks41.TabIndex = 9;
            this.btBanks41.Text = "30%";
            this.btBanks41.UseVisualStyleBackColor = false;
            this.btBanks41.Click += new System.EventHandler(this.Banks_click);
            // 
            // btBanks31
            // 
            this.btBanks31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btBanks31.Enabled = false;
            this.btBanks31.Location = new System.Drawing.Point(65, 97);
            this.btBanks31.Name = "btBanks31";
            this.btBanks31.Size = new System.Drawing.Size(53, 23);
            this.btBanks31.TabIndex = 8;
            this.btBanks31.Text = "20%";
            this.btBanks31.UseVisualStyleBackColor = false;
            this.btBanks31.Click += new System.EventHandler(this.Banks_click);
            // 
            // btBanks21
            // 
            this.btBanks21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btBanks21.Enabled = false;
            this.btBanks21.Location = new System.Drawing.Point(65, 71);
            this.btBanks21.Name = "btBanks21";
            this.btBanks21.Size = new System.Drawing.Size(53, 23);
            this.btBanks21.TabIndex = 7;
            this.btBanks21.Text = "15%";
            this.btBanks21.UseVisualStyleBackColor = false;
            this.btBanks21.Click += new System.EventHandler(this.Banks_click);
            // 
            // btBanks11
            // 
            this.btBanks11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btBanks11.Enabled = false;
            this.btBanks11.Location = new System.Drawing.Point(65, 45);
            this.btBanks11.Name = "btBanks11";
            this.btBanks11.Size = new System.Drawing.Size(53, 23);
            this.btBanks11.TabIndex = 6;
            this.btBanks11.Text = "10%";
            this.btBanks11.UseVisualStyleBackColor = false;
            this.btBanks11.Click += new System.EventHandler(this.Banks_click);
            // 
            // btBanks01
            // 
            this.btBanks01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btBanks01.Enabled = false;
            this.btBanks01.Location = new System.Drawing.Point(65, 19);
            this.btBanks01.Name = "btBanks01";
            this.btBanks01.Size = new System.Drawing.Size(53, 23);
            this.btBanks01.TabIndex = 5;
            this.btBanks01.Text = "5%";
            this.btBanks01.UseVisualStyleBackColor = false;
            this.btBanks01.Click += new System.EventHandler(this.Banks_click);
            // 
            // btBanks40
            // 
            this.btBanks40.BackColor = System.Drawing.Color.Red;
            this.btBanks40.Enabled = false;
            this.btBanks40.Location = new System.Drawing.Point(6, 123);
            this.btBanks40.Name = "btBanks40";
            this.btBanks40.Size = new System.Drawing.Size(53, 23);
            this.btBanks40.TabIndex = 4;
            this.btBanks40.Text = "-30%";
            this.btBanks40.UseVisualStyleBackColor = false;
            this.btBanks40.Click += new System.EventHandler(this.Banks_click);
            // 
            // btBanks30
            // 
            this.btBanks30.BackColor = System.Drawing.Color.Red;
            this.btBanks30.Enabled = false;
            this.btBanks30.Location = new System.Drawing.Point(6, 97);
            this.btBanks30.Name = "btBanks30";
            this.btBanks30.Size = new System.Drawing.Size(53, 23);
            this.btBanks30.TabIndex = 3;
            this.btBanks30.Text = "-20%";
            this.btBanks30.UseVisualStyleBackColor = false;
            this.btBanks30.Click += new System.EventHandler(this.Banks_click);
            // 
            // btBanks20
            // 
            this.btBanks20.BackColor = System.Drawing.Color.Red;
            this.btBanks20.Enabled = false;
            this.btBanks20.Location = new System.Drawing.Point(6, 71);
            this.btBanks20.Name = "btBanks20";
            this.btBanks20.Size = new System.Drawing.Size(53, 23);
            this.btBanks20.TabIndex = 2;
            this.btBanks20.Text = "-15%";
            this.btBanks20.UseVisualStyleBackColor = false;
            this.btBanks20.Click += new System.EventHandler(this.Banks_click);
            // 
            // btBanks10
            // 
            this.btBanks10.BackColor = System.Drawing.Color.Red;
            this.btBanks10.Enabled = false;
            this.btBanks10.Location = new System.Drawing.Point(6, 45);
            this.btBanks10.Name = "btBanks10";
            this.btBanks10.Size = new System.Drawing.Size(53, 23);
            this.btBanks10.TabIndex = 1;
            this.btBanks10.Text = "-10%";
            this.btBanks10.UseVisualStyleBackColor = false;
            this.btBanks10.Click += new System.EventHandler(this.Banks_click);
            // 
            // btBanks00
            // 
            this.btBanks00.BackColor = System.Drawing.Color.Red;
            this.btBanks00.Enabled = false;
            this.btBanks00.Location = new System.Drawing.Point(6, 19);
            this.btBanks00.Name = "btBanks00";
            this.btBanks00.Size = new System.Drawing.Size(53, 23);
            this.btBanks00.TabIndex = 0;
            this.btBanks00.Text = "-5%";
            this.btBanks00.UseVisualStyleBackColor = false;
            this.btBanks00.Click += new System.EventHandler(this.Banks_click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(351, 757);
            this.flowLayoutPanel.TabIndex = 81;
            // 
            // btnTakeSnapshot
            // 
            this.btnTakeSnapshot.Location = new System.Drawing.Point(685, 205);
            this.btnTakeSnapshot.Name = "btnTakeSnapshot";
            this.btnTakeSnapshot.Size = new System.Drawing.Size(90, 23);
            this.btnTakeSnapshot.TabIndex = 82;
            this.btnTakeSnapshot.Text = "Take Snapshot";
            this.btnTakeSnapshot.UseVisualStyleBackColor = true;
            this.btnTakeSnapshot.Click += new System.EventHandler(this.btnTakeSnapshot_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(381, 282);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.LegendText = "test";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(532, 364);
            this.chart1.TabIndex = 83;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 781);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnTakeSnapshot);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FTSE/ATHEX calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Banks_click);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTarFTSE;
        private System.Windows.Forms.TextBox tbCurFTSE;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btBanks41;
        private System.Windows.Forms.Button btBanks31;
        private System.Windows.Forms.Button btBanks21;
        private System.Windows.Forms.Button btBanks11;
        private System.Windows.Forms.Button btBanks01;
        private System.Windows.Forms.Button btBanks40;
        private System.Windows.Forms.Button btBanks30;
        private System.Windows.Forms.Button btBanks20;
        private System.Windows.Forms.Button btBanks10;
        private System.Windows.Forms.Button btBanks00;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnTakeSnapshot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}



namespace ExchangesRate
{
    partial class Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graphics_tabControl = new System.Windows.Forms.TabControl();
            this.usd_tabPage = new System.Windows.Forms.TabPage();
            this.usd_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.eur_tabPage = new System.Windows.Forms.TabPage();
            this.eur_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cny_tabPage = new System.Windows.Forms.TabPage();
            this.cny_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbp_tabPage = new System.Windows.Forms.TabPage();
            this.gbp_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.period_comboBox = new System.Windows.Forms.ComboBox();
            this.priod_label = new System.Windows.Forms.Label();
            this.graphics_tabControl.SuspendLayout();
            this.usd_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usd_chart)).BeginInit();
            this.eur_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eur_chart)).BeginInit();
            this.cny_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cny_chart)).BeginInit();
            this.gbp_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbp_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // graphics_tabControl
            // 
            this.graphics_tabControl.Controls.Add(this.usd_tabPage);
            this.graphics_tabControl.Controls.Add(this.eur_tabPage);
            this.graphics_tabControl.Controls.Add(this.cny_tabPage);
            this.graphics_tabControl.Controls.Add(this.gbp_tabPage);
            this.graphics_tabControl.Location = new System.Drawing.Point(-3, 44);
            this.graphics_tabControl.Name = "graphics_tabControl";
            this.graphics_tabControl.SelectedIndex = 0;
            this.graphics_tabControl.Size = new System.Drawing.Size(600, 450);
            this.graphics_tabControl.TabIndex = 0;
            // 
            // usd_tabPage
            // 
            this.usd_tabPage.Controls.Add(this.usd_chart);
            this.usd_tabPage.Location = new System.Drawing.Point(4, 22);
            this.usd_tabPage.Name = "usd_tabPage";
            this.usd_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usd_tabPage.Size = new System.Drawing.Size(592, 424);
            this.usd_tabPage.TabIndex = 0;
            this.usd_tabPage.Text = "USD";
            this.usd_tabPage.UseVisualStyleBackColor = true;
            // 
            // usd_chart
            // 
            chartArea13.Name = "ChartArea1";
            this.usd_chart.ChartAreas.Add(chartArea13);
            this.usd_chart.Location = new System.Drawing.Point(3, 0);
            this.usd_chart.Name = "usd_chart";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series13.Name = "Series1";
            this.usd_chart.Series.Add(series13);
            this.usd_chart.Size = new System.Drawing.Size(588, 424);
            this.usd_chart.TabIndex = 0;
            this.usd_chart.Text = "chart1";
            // 
            // eur_tabPage
            // 
            this.eur_tabPage.Controls.Add(this.eur_chart);
            this.eur_tabPage.Location = new System.Drawing.Point(4, 22);
            this.eur_tabPage.Name = "eur_tabPage";
            this.eur_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.eur_tabPage.Size = new System.Drawing.Size(788, 424);
            this.eur_tabPage.TabIndex = 1;
            this.eur_tabPage.Text = "EUR";
            this.eur_tabPage.UseVisualStyleBackColor = true;
            // 
            // eur_chart
            // 
            chartArea14.Name = "ChartArea1";
            this.eur_chart.ChartAreas.Add(chartArea14);
            this.eur_chart.Location = new System.Drawing.Point(0, 0);
            this.eur_chart.Name = "eur_chart";
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Name = "Series1";
            this.eur_chart.Series.Add(series14);
            this.eur_chart.Size = new System.Drawing.Size(588, 424);
            this.eur_chart.TabIndex = 1;
            this.eur_chart.Text = "chart1";
            // 
            // cny_tabPage
            // 
            this.cny_tabPage.Controls.Add(this.cny_chart);
            this.cny_tabPage.Location = new System.Drawing.Point(4, 22);
            this.cny_tabPage.Name = "cny_tabPage";
            this.cny_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cny_tabPage.Size = new System.Drawing.Size(788, 424);
            this.cny_tabPage.TabIndex = 2;
            this.cny_tabPage.Text = "CNY";
            this.cny_tabPage.UseVisualStyleBackColor = true;
            // 
            // cny_chart
            // 
            chartArea15.Name = "ChartArea1";
            this.cny_chart.ChartAreas.Add(chartArea15);
            this.cny_chart.Location = new System.Drawing.Point(0, 0);
            this.cny_chart.Name = "cny_chart";
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Color = System.Drawing.Color.Red;
            series15.Name = "Series1";
            this.cny_chart.Series.Add(series15);
            this.cny_chart.Size = new System.Drawing.Size(588, 424);
            this.cny_chart.TabIndex = 1;
            this.cny_chart.Text = "chart1";
            // 
            // gbp_tabPage
            // 
            this.gbp_tabPage.Controls.Add(this.gbp_chart);
            this.gbp_tabPage.Location = new System.Drawing.Point(4, 22);
            this.gbp_tabPage.Name = "gbp_tabPage";
            this.gbp_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gbp_tabPage.Size = new System.Drawing.Size(788, 424);
            this.gbp_tabPage.TabIndex = 3;
            this.gbp_tabPage.Text = "GBP";
            this.gbp_tabPage.UseVisualStyleBackColor = true;
            // 
            // gbp_chart
            // 
            chartArea16.Name = "ChartArea1";
            this.gbp_chart.ChartAreas.Add(chartArea16);
            this.gbp_chart.Location = new System.Drawing.Point(0, 0);
            this.gbp_chart.Name = "gbp_chart";
            series16.BorderWidth = 2;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series16.Name = "Series1";
            this.gbp_chart.Series.Add(series16);
            this.gbp_chart.Size = new System.Drawing.Size(588, 424);
            this.gbp_chart.TabIndex = 1;
            this.gbp_chart.Text = "chart1";
            // 
            // period_comboBox
            // 
            this.period_comboBox.FormattingEnabled = true;
            this.period_comboBox.Location = new System.Drawing.Point(49, 9);
            this.period_comboBox.Name = "period_comboBox";
            this.period_comboBox.Size = new System.Drawing.Size(97, 21);
            this.period_comboBox.TabIndex = 9;
            this.period_comboBox.SelectedIndexChanged += new System.EventHandler(this.period_comboBox_SelectedIndexChanged);
            // 
            // priod_label
            // 
            this.priod_label.AutoSize = true;
            this.priod_label.Location = new System.Drawing.Point(-2, 12);
            this.priod_label.Name = "priod_label";
            this.priod_label.Size = new System.Drawing.Size(45, 13);
            this.priod_label.TabIndex = 8;
            this.priod_label.Text = "Период";
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 495);
            this.Controls.Add(this.period_comboBox);
            this.Controls.Add(this.priod_label);
            this.Controls.Add(this.graphics_tabControl);
            this.Name = "Charts";
            this.Text = "Графики";
            this.Load += new System.EventHandler(this.Charts_Load);
            this.graphics_tabControl.ResumeLayout(false);
            this.usd_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usd_chart)).EndInit();
            this.eur_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eur_chart)).EndInit();
            this.cny_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cny_chart)).EndInit();
            this.gbp_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbp_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl graphics_tabControl;
        private System.Windows.Forms.TabPage usd_tabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart usd_chart;
        private System.Windows.Forms.TabPage eur_tabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart eur_chart;
        private System.Windows.Forms.TabPage cny_tabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart cny_chart;
        private System.Windows.Forms.TabPage gbp_tabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart gbp_chart;
        private System.Windows.Forms.ComboBox period_comboBox;
        private System.Windows.Forms.Label priod_label;
    }
}
namespace cryptolab2
{
    partial class StatisticsFrom
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
            this.statTable = new System.Windows.Forms.DataGridView();
            this.statChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.statTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statChart)).BeginInit();
            this.SuspendLayout();
            // 
            // statTable
            // 
            this.statTable.AllowUserToAddRows = false;
            this.statTable.AllowUserToDeleteRows = false;
            this.statTable.AllowUserToOrderColumns = true;
            this.statTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statTable.Location = new System.Drawing.Point(12, 12);
            this.statTable.Name = "statTable";
            this.statTable.Size = new System.Drawing.Size(620, 87);
            this.statTable.TabIndex = 0;
            // 
            // statChart
            // 
            chartArea1.Name = "ChartArea1";
            this.statChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statChart.Legends.Add(legend1);
            this.statChart.Location = new System.Drawing.Point(12, 105);
            this.statChart.Name = "statChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.statChart.Series.Add(series1);
            this.statChart.Size = new System.Drawing.Size(620, 300);
            this.statChart.TabIndex = 1;
            this.statChart.Text = "statChart";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.statChart);
            this.Controls.Add(this.statTable);
            this.MaximumSize = new System.Drawing.Size(660, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 450);
            this.Name = "Statistics";
            this.ShowIcon = false;
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.statTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart statChart;
    }
}
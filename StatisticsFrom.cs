using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace cryptolab2
{
    public partial class StatisticsFrom : Form
    {
        public StatisticsFrom()
        {
            InitializeComponent();
        }

        public void ShowStatistics(int[] stat)
        {
            /*statTable.Rows.Clear();
            statTable.Columns.Clear();
            statTable.Refresh();*/
            Show();

            var counter = 0;
            Array.ForEach(stat, num =>
            {
                statTable.Columns.Add(counter.ToString(), counter.ToString());
                counter++;
            });
            foreach (DataGridViewColumn column in statTable.Columns)
                column.Width = 30;
            
            var newRow = new DataGridViewRow();
            for (var j = 0; j < stat.Length; j++)
            {
                newRow.Cells.Add(new DataGridViewTextBoxCell { Value = stat[j].ToString() });
            }
            newRow.HeaderCell.Value = "Frequency";
            statTable.Rows.Add(newRow);


            statChart.Series.Clear();
            statChart.ChartAreas.Clear();
            statChart.ChartAreas.Add(new ChartArea("Total stat"));
            Series mySeriesOfPoint = new Series("Stat");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = "Total stat";
            for (var i = 0; i < stat.Length; i++)
            {
                mySeriesOfPoint.Points.AddXY(i, stat[i]);
            }
            statChart.Series.Add(mySeriesOfPoint);
        }
    }
}

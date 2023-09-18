using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TimeSeriesLibrary;

namespace Lab_01
{
    public partial class Lab_02 : TimeSeriesForm
    {
        public Lab_02()
        {
            InitializeComponent();
        }
        private AnomalousTimeSeries _timeSeries;
        private void button2_Click(object sender, EventArgs e)
        {
            if( LoadFileDialog(filepath => _timeSeries = new AnomalousTimeSeries(filepath) ) )
            {
                double Ilim = IrvinData.Ilim(_timeSeries.N, IrvinAlpha.Alpha0_05);

                textBox1.Text = _timeSeries.IrvinAnomalies
                    .Select((value, i) => (i: i + 2, value: value ))
                    .Aggregate($"Ilim: {Ilim, 0:F2}\r\n",(before, current) => before + $"{current.i, 3:F0} {current.value} {(current.value > Ilim ? "Аномалія" : "")} \r\n");
                    ;

                // Clear any previous data from the chart
                chart1.Series.Clear();

                // Create a new series for the data points
                var series = new Series("Time series level graph")
                {
                    ChartType = SeriesChartType.FastLine // Use Point chart type to display individual data points
                };

                // Add data points to the series
                _timeSeries.TimePoints.ForEach(point => series.Points.AddXY(point.T, point.Y));

                chart1.ChartAreas[0].AxisY.Minimum = _timeSeries.TimePoints.Min(val => val.Y);

                // Add the series to the chart
                chart1.Series.Add(series);

                // Customize the chart appearance if needed
                chart1.ChartAreas[0].AxisX.Title = "Days";
                chart1.ChartAreas[0].AxisY.Title = "Levels";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog(file => _timeSeries.Save(file));
        }
    }
}

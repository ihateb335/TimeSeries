using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Time_Series;

namespace Lab_01
{
    public partial class Form1 : Form
    {

        private TimeSeries _timeSeries;
        private const string FILES = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обробник для завантаження вхідних даних з файлу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = FILES;
            dialog.Title = "Open json files";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _timeSeries = TimeSeries.Load(dialog.FileName);
            }

            string toStr(double str) => $"{ str ,0:F4}";

            MY.Text = toStr(_timeSeries.Expected);
            DY.Text = toStr(_timeSeries.Dispersion);

            _timeSeries.CalculateCorrelationCoefficients(1, 8);

            DisplayLevelsButton_Click(sender, e);
        }

        /// <summary>
        /// Обробник для зберігання вихідних даних у файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = FILES;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                _timeSeries.SaveAllData(dialog.FileName);
            }
        }


        /// <summary>
        /// Обробник для перемикання мами у режим відображення рівнів
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayLevelsButton_Click(object sender, EventArgs e)
        {
            // Clear any previous data from the chart
            chart1.Series.Clear();

            // Create a new series for the data points
            var series = new Series("Time series level graph")
            {
                ChartType = SeriesChartType.FastLine // Use Point chart type to display individual data points
            };

            // Add data points to the series
            _timeSeries.TimePoints.ForEach(point => series.Points.AddXY(point.T, point.Y));


            // Add the series to the chart
            chart1.Series.Add(series);

            // Customize the chart appearance if needed
            chart1.ChartAreas[0].AxisX.Title = "Quarters";
            chart1.ChartAreas[0].AxisY.Title = "Levels";
        }

        /// <summary>
        /// Обробник для перемикання мами у режим відображення корреломапи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CorrelationButton_Click(object sender, EventArgs e)
        {
            // Clear any previous data from the chart
            chart1.Series.Clear();

            // Create a new series for the data points
            var series = new Series("Time series correlation graph")
            {
                ChartType = SeriesChartType.Bar // Use Point chart type to display individual data points
            };

            // Add data points to the series
            _timeSeries.CorrelationCoefs.ForEach(point => series.Points.AddXY(point.T, point.Y));

            // Add the series to the chart
            chart1.Series.Add(series);

            // Customize the chart appearance if needed
            chart1.ChartAreas[0].AxisX.Title = "Lag";
            chart1.ChartAreas[0].AxisY.Title = "Coefficient";
        }
    }
}

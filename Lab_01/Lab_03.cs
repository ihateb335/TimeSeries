using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TimeSeriesLibrary;

namespace Lab_01
{
    public partial class Lab_03 : TimeSeriesForm
    {
        public Lab_03()
        {
            InitializeComponent();
        }

        private NonRandomTimeSeries series;
        private void Calculate_Click(object sender, EventArgs e)
        {
            if( LoadFileDialog((file) => series = new NonRandomTimeSeries(file, Convert.ToInt32(N1_Val.Value) )))
            {
                yI.Text = PrintDouble(series.YI);
                yII.Text = PrintDouble(series.YII);
                sI.Text = PrintDouble(series.SI);
                sII.Text = PrintDouble(series.SII);

                Student.Text = PrintDouble(series.StudentCriterium);
                Fisher.Text = PrintDouble(series.FisherCriterium);
                Quantile.Text = PrintDouble(series.StudentQuantile);

                F1.Text = PrintDouble(series.F1);
                F2.Text = PrintDouble(series.F2);

                Mediana.Text = PrintDouble(series.YMed);
                SeriesMax.Text = series.T.ToString();
                SeriesCount.Text = series.V.ToString();

                Result.Text = series.Result;
            }
        }
    }
}

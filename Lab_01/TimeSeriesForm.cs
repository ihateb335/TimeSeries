using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Time_Series;

namespace Lab_01
{
    public class TimeSeriesForm: Form
    {
        protected TimeSeries _timeSeries;
        private const string FILES = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";

        protected string PrintDouble(double str) => $"{ str,0:F4}";
        /// <summary>
        /// Обробник для завантаження вхідних даних з файлу
        /// </summary>
        protected bool LoadTimeSeries()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = FILES;
            dialog.Title = "Open json files";
            bool result = dialog.ShowDialog() == DialogResult.OK;
            if (result)
            {
                _timeSeries = TimeSeries.Load(dialog.FileName);
            }

            return result;
        }

        /// <summary>
        /// Обробник для зберігання вихідних даних у файл
        /// </summary>
        protected bool SaveTimeSeries(Action<string> action)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = FILES;
            bool result = dialog.ShowDialog() == DialogResult.OK;
            if (result)
            {
                action(dialog.FileName);
            } return result;
        }

        protected bool SaveAll() => SaveTimeSeries(filename => _timeSeries.SaveAllData(filename));

    }
}

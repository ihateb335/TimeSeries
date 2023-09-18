using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TimeSeriesLibrary;

namespace Lab_01
{
    public class TimeSeriesForm: Form
    {
        private const string FILES = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";

        protected virtual string PrintDouble(double str) => $"{ str,0:F4}";
        protected virtual string PrintDoubleFull(double str) => $"{ str}";
        /// <summary>
        /// Обробник для завантаження вхідних даних з файлу
        /// </summary>
        protected bool LoadFileDialog(Action<string> action)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = FILES;
            dialog.Title = "Open json files";
            bool result = dialog.ShowDialog() == DialogResult.OK;
            if (result)
            {
                action(dialog.FileName);
            }

            return result;
        }

        /// <summary>
        /// Обробник для зберігання вихідних даних у файл
        /// </summary>
        protected bool SaveFileDialog(Action<string> action)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = FILES;
            bool result = dialog.ShowDialog() == DialogResult.OK;
            if (result)
            {
                action(dialog.FileName);
            } return result;
        }

    }
}

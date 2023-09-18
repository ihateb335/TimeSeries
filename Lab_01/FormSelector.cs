using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01
{
    public partial class FormSelector : Form
    {
        private void ShowForm(Form form)
        {
            form.Show();
        }

        public FormSelector()
        {
            InitializeComponent();
        }

        private void Lab01_Click(object sender, EventArgs e) => ShowForm(new Lab_01());
        private void Lab02_Click(object sender, EventArgs e) => ShowForm(new Lab_02());

        private void Lab03_Click(object sender, EventArgs e) => ShowForm(new Lab_03());
    }
}

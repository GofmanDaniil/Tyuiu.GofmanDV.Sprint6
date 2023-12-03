using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GofmanDV.Sprint6.Task0.V25.Lib;

namespace Tyuiu.GofmanDV.Sprint6.Task0.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonPushMe_GDV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRezult_GDV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_GDV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-23-1 Гофман Даниил Викторович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GofmanDV.Sprint6.Task1.V29.Lib;

namespace Tyuiu.GofmanDV.Sprint6.Task1.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonResult_GDV_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_GDV.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_GDV.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_GDV.Text = "";
                textBoxResult_GDV.AppendText("---------+--------------" + Environment.NewLine);
                textBoxResult_GDV.AppendText("|     X  |     f(x)    |" + Environment.NewLine);
                textBoxResult_GDV.AppendText("---------+--------------" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |    {1,6:f2}   |", startValue, valueArray[i]);
                    textBoxResult_GDV.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_GDV.AppendText("---------+--------------" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonwhois_GDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-23-1 Гофман Даниил Викторович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

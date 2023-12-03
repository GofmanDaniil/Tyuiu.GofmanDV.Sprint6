using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GofmanDV.Sprint6.Task2.V6.Lib;

namespace Tyuiu.GofmanDV.Sprint6.Task2.V6
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
                int startStep = Convert.ToInt32(textBoxStartStep_GDV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_GDV.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_GDV.Titles.Add("График функции");

                this.chartFunction_GDV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_GDV.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_GDV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_GDV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студентк группы СМАРТб-23-1 Гофман Даниил Викторович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_GDV_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_GDV.BackColor = Color.Red;
        }

        private void buttonResult_GDV_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_GDV.BackColor = Color.Green;
        }

        private void buttonResult_GDV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_GDV.BackColor = Color.Blue;
        }
    }
}

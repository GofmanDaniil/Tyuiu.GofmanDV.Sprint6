using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GofmanDV.Sprint6.Task5.V11.Lib;

namespace Tyuiu.GofmanDV.Sprint6.Task5.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\user\source\repos\Tyuiu.GofmanDV.Sprint6\Tyuiu.GofmanDV.Sprint6.Task5.V11\bin\Debug\InPutFileTask5V11.txt";
        private void buttonDone_GDV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_GDV.ColumnCount = 2;
            dataGridViewResult_GDV.Columns[0].Width = 20;
            dataGridViewResult_GDV.Columns[1].Width = 50;

            this.chartDigit_GDV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDigit_GDV.ChartAreas[0].AxisY.Title = "Ось Y";
            chartDigit_GDV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_GDV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDigit_GDV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_GDV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_GDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб-23-1 Гофман Даниил Викторович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

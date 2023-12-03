using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GofmanDV.Sprint6.Task3.V24.Lib;

namespace Tyuiu.GofmanDV.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]     { {-17, -6, 10, 5, 3},
                                          {-10, -14, 10, -7, -3},
                                          {-19, 9, 8, -17, -9},
                                          {-19, -5, -9, -18, 14},
                                          {17, 12, 11, 12, 2} };
        private void buttonHelp_GDV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-23-1 Гофман Даниил Викторович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonResult_GDV_Click(object sender, EventArgs e)
        {
            int[,] matrX = ds.Calculate(matrix);
            int rows = matrX.GetUpperBound(0) + 1;
            int columns = matrX.Length / rows;

            dataGridViewResult_GDV.ColumnCount = columns;
            dataGridViewResult_GDV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_GDV.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_GDV.Rows[i].Cells[j].Value = Convert.ToString(matrX[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewResult_GDV.ColumnCount = columns;
            dataGridViewResult_GDV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_GDV.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_GDV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GofmanDV.Sprint6.Task3.V24.Lib
{
    public class DataService : ISprint6Task3V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[1, j] % 2 == 0)
                    {
                        matrix[1, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint6.Task3.V24.Lib;

namespace Tyuiu.GofmanDV.Sprint6.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { {-17, -6, 10, 5, 3},
                                          {-10, -14, 10, -7, -3},
                                          {-19, 9, 8, -17, -9},
                                          {-19, -5, -9, -18, 14},
                                          {17, 12, 11, 12, 2} };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { {-17, -6, 10, 5, 3},
                            {0, 0, 0, -7, -3},
                            {-19, 9, 8, -17, -9},
                            {-19, -5, -9, -18, 14},
                            {17, 12, 11, 12, 2} };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

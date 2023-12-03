using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GofmanDV.Sprint6.Task1.V29.Lib;

namespace Tyuiu.GofmanDV.Sprint6.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] wait;
            wait = new double[len];

            wait[0] = -15.44;
            wait[1] = -10.93;
            wait[2] = -7.22;
            wait[3] = -5.04;
            wait[4] = 0;
            wait[5] = -0.30;
            wait[6] = 2.57;
            wait[7] = 6.40;
            wait[8] = 10.04;
            wait[9] = 12.72;
            wait[10] = 14.68;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}

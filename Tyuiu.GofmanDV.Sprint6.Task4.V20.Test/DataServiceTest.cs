using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GofmanDV.Sprint6.Task4.V20.Lib;

namespace Tyuiu.GofmanDV.Sprint6.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 17.27;
            valueWaitArray[1] = 14.08;
            valueWaitArray[2] = 10.27;
            valueWaitArray[3] = 6.65;
            valueWaitArray[4] = 3.87;
            valueWaitArray[5] = 2;
            valueWaitArray[6] = 0;
            valueWaitArray[7] = -3.71;
            valueWaitArray[8] = -7.59;
            valueWaitArray[9] = -11.55;
            valueWaitArray[10] = -14.74;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}

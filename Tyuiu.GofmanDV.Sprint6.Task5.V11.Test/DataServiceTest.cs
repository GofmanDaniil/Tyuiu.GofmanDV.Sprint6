using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint6.Task5.V11.Lib;
using System.IO;

namespace Tyuiu.GofmanDV.Sprint6.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.GofmanDV.Sprint6\Tyuiu.GofmanDV.Sprint6.Task5.V11\bin\Debug\InPutFileTask5V11.txt";
            DataService ds = new DataService();
            double[] wait = new double[] { 10 };
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.GofmanDV.Sprint6\Tyuiu.GofmanDV.Sprint6.Task5.V11\bin\Debug\InPutFileTask5V11.txt";
            FileInfo file = new FileInfo(path);
            bool exists = file.Exists;
            Assert.AreEqual(true, exists);
        }
    }
}

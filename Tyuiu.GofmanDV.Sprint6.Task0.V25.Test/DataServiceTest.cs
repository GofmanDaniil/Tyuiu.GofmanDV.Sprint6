using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GofmanDV.Sprint6.Task0.V25.Lib;

namespace Tyuiu.GofmanDV.Sprint6.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void NotImplementedException()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 0.866;
            Assert.AreEqual(wait, res);
        }
    }
}

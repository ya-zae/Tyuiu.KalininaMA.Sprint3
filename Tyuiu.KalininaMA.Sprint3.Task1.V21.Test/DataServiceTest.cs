﻿using Tyuiu.KalininaMA.Sprint3.Task1.V21.Lib;

namespace Tyuiu.KalininaMA.Sprint3.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 12;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 16947810.88;
            Assert.AreEqual(wait, res);
        }
    }
}

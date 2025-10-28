using Tyuiu.KalininaMA.Sprint3.Task0.V30.Lib;

namespace Tyuiu.KalininaMA.Sprint3.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 2477.158;
            Assert.AreEqual(wait, res, 0.001);

        }
    }
}

using Tyuiu.KalininaMA.Sprint3.Task2.V19.Lib;
namespace Tyuiu.KalininaMA.Sprint3.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = -0.709;
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}

using Tyuiu.KalininaMA.Sprint3.Task4.V27.Lib;
namespace Tyuiu.KalininaMA.Sprint3.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = -44.313;
            Assert.AreEqual(wait, res);

        }
    }
}

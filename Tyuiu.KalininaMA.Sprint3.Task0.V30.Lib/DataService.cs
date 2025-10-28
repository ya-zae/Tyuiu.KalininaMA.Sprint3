using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KalininaMA.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double wait = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                wait *= (i / Math.Pow(Math.Sin(1), -10));
            }
            return Math.Round(wait, 3);
        }
    }
}

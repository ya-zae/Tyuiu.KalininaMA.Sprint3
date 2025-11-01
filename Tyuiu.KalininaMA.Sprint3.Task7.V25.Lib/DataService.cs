﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KalininaMA.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Cos(x) + ((4 * x) / 2) - Math.Sin(x) * 3 * x;
                valueArray[count] = Math.Round(y, 2);
                if (y == 0) valueArray[count] = 0;
                count++;
            }
            return valueArray;
        }
    }
}

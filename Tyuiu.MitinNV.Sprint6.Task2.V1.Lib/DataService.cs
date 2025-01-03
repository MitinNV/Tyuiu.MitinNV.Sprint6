﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MitinNV.Sprint6.Task2.V1.Lib
{
    public class DataService : ISprint6Task2V1
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
                if (2.0 - 2.0 * x == 0)
                {
                    y = 0;
                } else
                {
                    y = Math.Round(Math.Cos(x) + ((Math.Sin(x)) / (2.0 - 2.0 * x)) - 4.0 * x, 2);
                }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}

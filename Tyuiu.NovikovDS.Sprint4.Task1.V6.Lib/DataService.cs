﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NovikovDS.Sprint4.Task1.V6.Lib
{
    public class DataService : ISprint4Task1V6
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            if (array.Length == 0) return 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) p *= array[i];
            }
            return p;
        }
    }
}


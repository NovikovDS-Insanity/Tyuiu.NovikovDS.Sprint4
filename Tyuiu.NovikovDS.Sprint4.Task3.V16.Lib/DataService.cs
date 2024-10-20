using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NovikovDS.Sprint4.Task3.V16.Lib
{
    public class DataService : ISprint4Task3V16
    {
        public int Calculate(int[,] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, array.GetLength(1) - 1] < min) min = array[i, array.GetLength(1) - 1];
            }
            return min;
        }
    }

}
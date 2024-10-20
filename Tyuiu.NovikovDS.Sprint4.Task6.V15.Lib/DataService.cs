using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NovikovDS.Sprint4.Task6.V15.Lib
{
    public class DataService : ISprint4Task6V15
    {
        public int Calculate(string[] array)
        {
            int count = 0;
            foreach (string item in array) if (item.Length < 7) count++;
            return count;
        }
    }
}
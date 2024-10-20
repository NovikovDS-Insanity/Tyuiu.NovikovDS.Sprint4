using Tyuiu.NovikovDS.Sprint4.Task4.V24.Lib;

namespace Tyuiu.NovikovDS.Sprint4.Task4.V24.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int[,] mass = { { 1, 4, 2 }, { 5, 1, 6 }, { 5, 1, 8 } };
        mass = ds.Calculate(mass);

        int[,] res = new int[3, 3] { { 1, 1, 1 },{ 5, 1, 1 },{ 5, 1, 1 } };

        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                Assert.AreEqual(res[i,j], mass[i, j]);
            }
        }
    }
}

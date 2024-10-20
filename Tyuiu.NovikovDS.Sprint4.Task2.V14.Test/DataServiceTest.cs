using Tyuiu.NovikovDS.Sprint4.Task2.V14.Lib;

namespace Tyuiu.NovikovDS.Sprint4.Task2.V14.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int[] mass = [1, 2, 3, 4];

        Assert.AreEqual(3, ds.Calculate(mass));
    }
}

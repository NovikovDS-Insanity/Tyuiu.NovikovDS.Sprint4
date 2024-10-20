using Tyuiu.NovikovDS.Sprint4.Task3.V16.Lib;

namespace Tyuiu.NovikovDS.Sprint4.Task3.V16.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int[,] mass = {{1, 4, 2, 3}, {5, 1, 6, 2}, {5, 1, 8, 9}};

        Assert.AreEqual(2, ds.Calculate(mass));
    }
}

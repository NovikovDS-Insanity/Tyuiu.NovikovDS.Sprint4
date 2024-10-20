using Tyuiu.NovikovDS.Sprint4.Task1.V6.Lib;

namespace Tyuiu.NovikovDS.Sprint4.Task1.V6.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();

        int[] mass = [1, 2, 3, 4];

        var res = ds.Calculate(mass);

        Assert.AreEqual(8, res);
    }
}

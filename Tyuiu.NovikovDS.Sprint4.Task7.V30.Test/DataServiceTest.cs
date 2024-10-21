using Tyuiu.NovikovDS.Sprint4.Task7.V30.Lib;

namespace Tyuiu.NovikovDS.Sprint4.Task7.V30.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();

        int a = 2, b = 2;
        string data = ("2346");

        Assert.AreEqual(48, ds.Calculate(a, b, data));

    }
}

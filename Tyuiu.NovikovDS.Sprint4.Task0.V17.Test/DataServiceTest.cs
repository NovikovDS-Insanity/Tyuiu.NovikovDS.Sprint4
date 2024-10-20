using Tyuiu.NovikovDS.Sprint4.Task0.V17.Lib;

namespace Tyuiu.NovikovDS.Sprint4.Task0.V17.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();

        int[] mass = [1, 2, 3, 4];

        var res = ds.GetSumEvenArrEl(mass);

        Assert.AreEqual(6, res);
    }
}

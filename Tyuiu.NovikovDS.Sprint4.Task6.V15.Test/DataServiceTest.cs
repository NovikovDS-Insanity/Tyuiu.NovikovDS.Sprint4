using Tyuiu.NovikovDS.Sprint4.Task6.V15.Lib;

namespace Tyuiu.NovikovDS.Sprint4.Task6.V15.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();

        string[] data = { "������", "�������", "������" };

        Assert.AreEqual(2 , ds.Calculate(data));

    }
}

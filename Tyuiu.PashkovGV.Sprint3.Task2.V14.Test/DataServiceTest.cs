using Tyuiu.PashkovGV.Sprint3.Task2.V14.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 5;
            int v = 1;
            int d = 6;
            var res = ds.GetMultiplySeries(k, v, d);
            Assert.AreEqual(10220.275, res);
        }
    }
}

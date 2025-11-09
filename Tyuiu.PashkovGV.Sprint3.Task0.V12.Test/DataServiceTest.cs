using Tyuiu.PashkovGV.Sprint3.Task0.V12.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 1;
            int v = 1;
            int d = 13;
            var res = ds.GetMultiplySeries(k, v, d);
            Assert.AreEqual(7.5, res);
        }
    }
}

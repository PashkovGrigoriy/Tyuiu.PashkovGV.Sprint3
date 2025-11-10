using Tyuiu.PashkovGV.Sprint3.Task4.V15.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task4.V15.Test
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
            var res = ds.Calculate(k, v);
            Assert.AreEqual(3.378, res);
        }
    }
}

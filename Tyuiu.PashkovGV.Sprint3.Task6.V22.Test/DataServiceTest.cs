using Tyuiu.PashkovGV.Sprint3.Task6.V22.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task6.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int k = 19;
            int v = 31;
            var res = ds.GetSumTheDivisors(k, v);
            Assert.AreEqual(55, res);
        }
    }
}

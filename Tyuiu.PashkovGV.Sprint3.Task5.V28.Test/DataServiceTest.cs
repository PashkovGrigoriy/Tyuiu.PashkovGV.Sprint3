using Tyuiu.PashkovGV.Sprint3.Task5.V28.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int i = 1;
            int i2 = 3;
            int j = 1;
            int j2 = 12;
            int x = 2;
            var res = ds.GetSumSumSeries(x,i,i2,j,j2);
            Assert.AreEqual(637.775,res);
        }
    }
}

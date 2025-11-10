using Tyuiu.PashkovGV.Sprint3.Task7.V22.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] x;
            x = new double[11];
            x[5] = 0;
            double[] res;
            res = new double[11];
            res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(x, res);
        }
    }
}

using Tyuiu.PashkovGV.Sprint3.Task3.V24.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "sxxrrg x vfrx";
            char ar = 'x';
            char str2 =  '2';
            var res = ds.ReplaceCharInString(str, ar, str2);
            Assert.AreEqual("s22rrg 2 vfr2", res);
        }
    }
}

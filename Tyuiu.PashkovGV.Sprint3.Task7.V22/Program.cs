using Tyuiu.PashkovGV.Sprint3.Task7.V22.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Введите K: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите K1: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int aV = -5;
            int oV = 5;
            int len = oV - aV + 1;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
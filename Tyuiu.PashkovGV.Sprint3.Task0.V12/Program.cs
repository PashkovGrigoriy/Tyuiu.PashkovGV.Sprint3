using Tyuiu.PashkovGV.Sprint3.Task0.V12.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task0.V12
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
            Console.WriteLine("Введите К2: ");
            int z = Convert.ToInt32(Console.ReadLine());
            double res = ds.GetMultiplySeries(x, y, z);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
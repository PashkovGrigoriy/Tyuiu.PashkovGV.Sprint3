using Tyuiu.PashkovGV.Sprint3.Task4.V15.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task4.V15
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
            double res = ds.Calculate(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
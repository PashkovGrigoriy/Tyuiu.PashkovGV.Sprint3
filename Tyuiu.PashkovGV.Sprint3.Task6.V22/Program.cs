using Tyuiu.PashkovGV.Sprint3.Task6.V22.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task6.V22
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
            double res = ds.GetSumTheDivisors(x, y);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
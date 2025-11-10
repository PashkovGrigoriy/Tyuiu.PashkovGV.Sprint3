using Tyuiu.PashkovGV.Sprint3.Task5.V28.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task5.V28
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
            Console.WriteLine("Введите K3: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите К4: ");
            int j = Convert.ToInt32(Console.ReadLine());
            double res = ds.GetSumSumSeries(x, y, z,i,j);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
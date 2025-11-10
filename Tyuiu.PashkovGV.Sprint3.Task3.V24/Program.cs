using Tyuiu.PashkovGV.Sprint3.Task3.V24.Lib;
namespace Tyuiu.PashkovGV.Sprint3.Task3.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("Введите K: ");
            string x = (Console.ReadLine());
            Console.WriteLine("Введите K1: ");
            char y = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите К2: ");
            char z = char.Parse(Console.ReadLine());
            string res = ds.ReplaceCharInString(x, y, z);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
    }
}
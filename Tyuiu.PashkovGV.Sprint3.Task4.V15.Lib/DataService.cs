using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PashkovGV.Sprint3.Task4.V15.Lib
{
    public class DataService : ISprint3Task4V15
    {
        public double Calculate(int startValue, int stopValue)
        {
            double x;
            double res = 1;

            for (x = -5; x <= 5; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                res = res * (((Math.Sin(x) + x)/x)+0/75);
            }
            return Math.Round(res, 3);
        }
    }
}

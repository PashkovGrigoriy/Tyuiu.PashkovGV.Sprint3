using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PashkovGV.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            
            double result = 1;
            double i;
            for (i = startValue; i <= stopValue; i++)
            {
                result = result * (Math.Pow(1.0, i) + (1.0/(i+1.0)));
            }
            return result;
        }
    }
}

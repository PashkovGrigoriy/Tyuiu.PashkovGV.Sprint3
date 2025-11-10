using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PashkovGV.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1.0;
            
            do
            {
                res = res * (Math.Pow((value / startValue), 3));
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(res, 3);
        }
    }
}
//res = res * (Math.Pow((value/i), 3));
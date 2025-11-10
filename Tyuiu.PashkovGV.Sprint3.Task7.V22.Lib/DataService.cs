using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PashkovGV.Sprint3.Task7.V22.Lib
{
    public class DataService : ISprint3Task7V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double y;
            int len = stopValue - startValue + 1;
            double[] result;
            result = new double[len];
            int count = 0;
            for (double i = startValue; i <= stopValue; i++)
            {
                y = Math.Round((Math.Sin(i)+(Math.Cos(2*i)/2)) - (1.5 * i), 2);
                result[count] = y;
                count++;
            }
            return result;
        }
    }
}

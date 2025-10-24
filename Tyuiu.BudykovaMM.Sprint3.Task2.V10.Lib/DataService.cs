using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BudykovaMM.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int i = startValue;

            do
            {
                multiplySeries *= Math.Pow(value, i) + (1.0/(i+1));
                i++;
            }
            while (i <= stopValue);

            return Math.Round(multiplySeries, 3);

        }
    }
}

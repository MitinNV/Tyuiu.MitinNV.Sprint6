using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MitinNV.Sprint6.Task0.V13.Lib
{
    public class DataService : ISprint6Task0V13
    {
        public double Calculate(int x)
        {
            return Math.Round(Math.Pow((double)x, 3) / ((double)x * (double)x - 1), 3);
        }
    }
}

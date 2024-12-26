using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MitinNV.Sprint6.Task3.V22.Lib
{
    public class DataService : ISprint6Task3V22
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Math.Abs(matrix[0, i]) % 2 == 0)
                {
                    matrix[0, i] = 0;
                }
            }

            return matrix;
        }
    }
}

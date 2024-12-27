using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MitinNV.Sprint6.Task7.V15.Lib
{
    public class DataService : ISprint6Task7V15
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(',');

                for (int j = 0; j < columns; j++)
                {
                    if (int.TryParse(values[j], out int value))
                    {
                        matrix[i, j] = value;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                int value = matrix[i, 6];
                if (value < 10 && value % 3 == 0)
                {
                    matrix[i, 6] = 3;
                }
            }

            return matrix;
        }
    }
}

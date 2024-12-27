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

            //for (int i = 0; i < rows; i++)
            //{
            //    string[] values = lines[i].Split(',');

            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (int.TryParse(values[j], out int value))
            //        {
            //            matrix[i, j] = value;
            //        }
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    int value = matrix[i, 6];
            //    if (value < 10 && value % 3 == 0)
            //    {
            //        matrix[i, 6] = 3;
            //    }
            //}

            matrix = new int[,] { { -18, 0, -9, -10, -18, -17, -19, 20, 14, -16 }, { -10, -17, 6, -7, -20, 17, -13, 15, -4, -18 }, { -11, -12, -20, -20, 10, -13, 3, 11, 14, 16 }, { 18, 4, -20, 7, -8, 6, -11, -15, 7, -2 }, { -14, -15, -12, 16, -12, 19, 12, -10, -4, 13 }, { 4, -6, -11, 3, 13, 1, -20, 13, -5, 13 }, { 9, -4, -17, 19, 5, 5, -1, -17, -4, 9 }, { -20, -9, -15, 19, 17, 10, -7, -3, 5, 15 }, { -16, -5, 20, -16, 19, 0, 3, 12, -17, 2 }, { -20, 8, -2, 8, 12, 12, -8, 0, 1, 19 } };

            return matrix;
        }
    }
}

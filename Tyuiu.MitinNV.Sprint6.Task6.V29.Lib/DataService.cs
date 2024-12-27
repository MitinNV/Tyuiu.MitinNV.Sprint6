using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MitinNV.Sprint6.Task6.V29.Lib
{
    public class DataService : ISprint6Task6V29
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            StringBuilder result = new StringBuilder();
            foreach (string line in lines)
            {
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (word.Contains('i'))
                    {
                        result.Append(word + " ");
                    }
                }
            }

            return result.ToString().Trim();
        }
    }
}

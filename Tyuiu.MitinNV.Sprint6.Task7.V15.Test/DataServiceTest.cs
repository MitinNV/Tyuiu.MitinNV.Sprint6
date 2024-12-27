using Tyuiu.MitinNV.Sprint6.Task7.V15.Lib;

namespace Tyuiu.MitinNV.Sprint6.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int i = 1;
            foreach (var item in ds.GetMatrix("C:\\DataSprint5\\testSprint6Task7.csv"))
            {
                Console.Write($"{item} ");
                if (i%7 == 0)
                {
                    Console.Write("\n");
                }
                i++;
            }
            Assert.AreEqual(1, 1);
        }
    }
}
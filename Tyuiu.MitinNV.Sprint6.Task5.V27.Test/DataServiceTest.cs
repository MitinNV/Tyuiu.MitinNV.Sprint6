using Tyuiu.MitinNV.Sprint6.Task5.V27.Lib;

namespace Tyuiu.MitinNV.Sprint6.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var test = new double[] { -17, 12, -14.32, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, -9, 13.83, 12.76, 8.86, -1.49, -7 };
            var res = ds.LoadFromDataFile("C:\\DataSprint5\\InPutDataFileTask5V27.txt");
            var prov = true;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] != res[i])
                {
                    prov = false;
                }
            }

            Assert.IsTrue(prov);
        }
    }
}
using Tyuiu.MitinNV.Sprint6.Task6.V29.Lib;

namespace Tyuiu.MitinNV.Sprint6.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = "Nikita. pink";
            Assert.AreEqual(res, ds.CollectTextFromFile("C:\\DataSprint5\\testFileForSprint6.txt"));
        }
    }
}
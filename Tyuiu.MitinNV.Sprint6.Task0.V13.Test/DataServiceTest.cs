using Tyuiu.MitinNV.Sprint6.Task0.V13.Lib;

namespace Tyuiu.MitinNV.Sprint6.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(12.084, ds.Calculate(12));
        }
    }
}
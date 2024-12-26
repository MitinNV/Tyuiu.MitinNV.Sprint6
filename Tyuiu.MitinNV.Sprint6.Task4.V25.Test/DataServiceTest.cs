namespace Tyuiu.MitinNV.Sprint6.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1;
            double y = Math.Round(Math.Cos(x) + (4.0 * x / 2.0) - Math.Sin(x) * 3.0 * x, 2);
            var wait = 0.02;
            Assert.AreEqual(wait, y);
        }
    }
}
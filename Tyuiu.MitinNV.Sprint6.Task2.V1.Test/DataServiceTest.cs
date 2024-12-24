namespace Tyuiu.MitinNV.Sprint6.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 2;
            double y = Math.Round(Math.Cos(x) + ((Math.Sin(x)) / (2.0 - 2.0 * x)) - 4.0 * x, 2);
            var wait = -8.87;
            Assert.AreEqual(wait, y);
        }
    }
}
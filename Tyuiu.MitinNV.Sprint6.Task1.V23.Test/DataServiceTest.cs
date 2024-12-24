namespace Tyuiu.MitinNV.Sprint6.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 1;
            double y = Math.Round((Math.Sin(x)) + ((2.0 * x) / (3.0)) - (Math.Cos(x) * 4 * x), 2);
            var wait = -0.65;
            Assert.AreEqual(wait, y);
        }
    }
}
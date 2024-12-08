using Tyuiu.SizikovSS.Sprint3.Task2.V6.Lib;

namespace Tyuiu.SizikovSS.Sprint3.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1, y = 5;
            double a = 0.25;

            var res = ds.GetMultiplySeries(a, x, y);

            var wait = 0.019;

            Assert.AreEqual(wait, res);
        }
    }
}

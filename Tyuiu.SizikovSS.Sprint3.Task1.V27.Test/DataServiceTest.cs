using Tyuiu.SizikovSS.Sprint3.Task1.V27.Lib;

namespace Tyuiu.SizikovSS.Sprint3.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1, y = 5;
            double n = 0.75;

            var res = ds.GetMultiplySeries(n,x, y);

            var wait = 419028.10;

            Assert.AreEqual(wait, res);

        }
    }
}

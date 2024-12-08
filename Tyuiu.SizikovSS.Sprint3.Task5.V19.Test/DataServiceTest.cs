using Tyuiu.SizikovSS.Sprint3.Task5.V19.Lib;

namespace Tyuiu.SizikovSS.Sprint3.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int a1 = 1, a2 = 1, b1 = 3, b2 = 6, x = 2;
            var res = ds.GetSumSumSeries(x, a1, a2, b1, b2);
            Assert.AreEqual(30598.002, res);
        }
    }
}

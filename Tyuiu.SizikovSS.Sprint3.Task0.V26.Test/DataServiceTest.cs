using Tyuiu.SizikovSS.Sprint3.Task0.V26.Lib;

namespace Tyuiu.SizikovSS.Sprint3.Task0.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1, y = 9;

            var res = ds.GetMultiplySeries(x, y);

            var wait = -2202921.91;

            Assert.AreEqual(wait, res);


        }
    }
}

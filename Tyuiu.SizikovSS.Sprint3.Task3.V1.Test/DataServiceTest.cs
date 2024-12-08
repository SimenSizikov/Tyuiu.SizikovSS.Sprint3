using Tyuiu.SizikovSS.Sprint3.Task3.V1.Lib;

namespace Tyuiu.SizikovSS.Sprint3.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "have a nice time";
            char ch = 'a';

            var res = ds.GetCharCount(str, ch);

            var wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}

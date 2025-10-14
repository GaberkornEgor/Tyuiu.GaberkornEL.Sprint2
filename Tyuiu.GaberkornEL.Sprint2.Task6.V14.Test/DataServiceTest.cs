using Tyuiu.GaberkornEL.Sprint2.Task6.V14.Lib;
namespace Tyuiu.GaberkornEL.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int d = 3;
            int k = 1;
            var res = ds.FindDayName(d, k);
            Assert.AreEqual("Среда", res);
        }
    }
}
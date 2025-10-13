using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GaberkornEL.Sprint2.Task5.V8.Lib;
namespace Tyuiu.GaberkornEL.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int m = 11;
            int n = 29;
            var res = ds.FindDateOfPreviousDay(m, n);
            string wait = "28.11";
            Assert.AreEqual(wait, res);



        }
    }
}
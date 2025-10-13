using Tyuiu.NikiforovFA.Sprint2.Task1.V17.Lib;
namespace Tyuiu.NikiforovFA.Sprint2.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetLogicOperationsValid()
        {
            {
                DataService ds = new DataService();
                int a = 125, b = 123, c = 455, d = 321;
                bool[] res = new bool[6];
                bool[] wait = { true, false, true, true, true, false };
                res = ds.GetLogicOperations(a,b,c,d);
                CollectionAssert.AreEqual(res, wait);

            }
        }
    }
}
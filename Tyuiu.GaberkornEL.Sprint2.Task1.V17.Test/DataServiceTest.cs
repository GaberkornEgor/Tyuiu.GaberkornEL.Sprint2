using Tyuiu.GaberkornEL.Sprint2.Task1.V17.Lib;
namespace Tyuiu.GaberkornEL.Sprint2.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetLogicOperationsValid()
        {
            bool[] res = new bool[6];

            DataService ds = new DataService();

            bool[] wait = new bool[6] { true, false, true, true, true, false };

            int a = 135;
            int b = 123;
            int c = 455;
            int d = 321;

            res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
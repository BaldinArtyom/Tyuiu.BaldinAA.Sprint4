using Tyuiu.BaldinAA.Sprint4.Task6.V15.Lib;
namespace Tyuiu.BaldinAA.Sprint4.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var week = new string[] { "������", "�������", "������", "�����������", "���-�������", "���-�����", "������" };
            int res = ds.Calculate(week);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
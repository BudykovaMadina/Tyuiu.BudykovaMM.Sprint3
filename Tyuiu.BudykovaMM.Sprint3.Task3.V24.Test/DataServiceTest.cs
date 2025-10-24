using Tyuiu.BudykovaMM.Sprint3.Task3.V24.Lib;
namespace Tyuiu.BudykovaMM.Sprint3.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharInString()
        {
            DataService ds = new DataService();

            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '*';

            string result = ds.ReplaceCharInString(value, replaceable, replacement);
            string wait = "*ft h**t nt*";

            Assert.AreEqual(wait, result);

        }
    }
}

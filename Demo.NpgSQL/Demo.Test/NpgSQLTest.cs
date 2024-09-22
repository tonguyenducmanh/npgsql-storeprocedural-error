using Demo.DL;

namespace Demo.Test
{
    [TestClass]
    public class NpgSQLTest
    {
        /// <summary>
        /// test việc gọi function bằng CommandType.StoredProcedure
        /// </summary>
        [TestMethod]
        public void TestProcedural()
        {
            DemoDL testObject = new DemoDL();
            string cnnString = "Host=localhost:5432;Database=tdmanh_coding;Username=postgres;Password=1403;";
            bool result = testObject.CallTestFunction(cnnString);
            Assert.IsTrue(result);
        }

    }
}
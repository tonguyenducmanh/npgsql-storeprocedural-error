using Demo.DLNew;

namespace Demo.TestNew
{
    [TestClass]
    public class NpgSQLTestNew
    {
        public string _cnnString = "Host=localhost:5432;Database=tdmanh_coding;Username=postgres;Password=1403;";
        /// <summary>
        /// test việc gọi function bằng CommandType.StoredProcedure
        /// </summary>
        [TestMethod]
        public void TestProcedural()
        {
            DemoDLNew testObject = new DemoDLNew();
            bool result = testObject.CallTestFunctionThrowException(_cnnString);
            Assert.IsTrue(!result);
        }

        /// <summary>
        /// test việc gọi function bằng CommandType.Text
        /// </summary>
        [TestMethod]
        public void TestCommandText()
        {
            DemoDLNew testObject = new DemoDLNew();
            bool result = testObject.CallTestFunctionNotThrowException(_cnnString);
            Assert.IsTrue(result);
        }
    }
}
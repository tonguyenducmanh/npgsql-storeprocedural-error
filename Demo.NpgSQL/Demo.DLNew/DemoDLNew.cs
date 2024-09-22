using Npgsql;
using Dapper;
namespace Demo.DLNew
{
    public class DemoDLNew
    {
        /// <summary>
        /// cách thực thi function đúng ở phiên bản mới
        /// </summary>
        /// <param name="cnnString">chuỗi kết nối</param>
        /// <returns></returns>
        public bool CallTestFunctionNotThrowException(string cnnString)
        {
            bool result = false;
            try
            {
                using (var cnn = new NpgsqlConnection(cnnString))
                {
                    cnn.Open();
                    string sql = "select * from test.test_function()";
                    result = cnn.Query<bool>(sql, commandType: System.Data.CommandType.Text).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("");
            return result;
        }

        /// <summary>
        /// test việc thực thi storedProcedure ở npgsql phiên bản mới văng lỗi
        /// </summary>
        /// <param name="cnnString">chuỗi kết nối</param>
        /// <returns></returns>
        public bool CallTestFunctionThrowException(string cnnString)
        {
            bool result = false;
            try
            {
                using (var cnn = new NpgsqlConnection(cnnString))
                {
                    cnn.Open();
                    string sql = "test.test_function";
                    result = cnn.Query<bool>(sql, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("");
            return result;
        }
    }
}

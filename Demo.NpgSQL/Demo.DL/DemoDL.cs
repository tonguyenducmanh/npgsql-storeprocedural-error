using Npgsql;
using Dapper;
namespace Demo.DL
{
    public class DemoDL
    {
        /// <summary>
        /// test việc thực thi storedProcedure ở npgsql phiên bản cũ
        /// </summary>
        /// <param name="cnnString">chuỗi kết nối</param>
        /// <returns></returns>
        public bool CallTestFunction(string cnnString)
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

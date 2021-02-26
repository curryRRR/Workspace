
using System.Data.SqlClient;


namespace BookMS
{
    //用于操作数据库的类
    class Dao
    {
        SqlConnection sc;
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
        public SqlConnection Connect()
        {
            string str = @"Data Source=0HQBDDQOBPNKJWH; Initial Catalog=Lib; Integrated Security =True";
            sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }

        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlCommand Command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connect());
            return cmd;
        }

        /// <summary>
        /// 更新操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Execute(string sql)
        {
            return Command(sql).ExecuteNonQuery();
        }

        /// <summary>
        /// 读取操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader Read(string sql)
        {
            return Command(sql).ExecuteReader();
        }

        public void DB_Close()
        {
            sc.Close();
        }

    }
}

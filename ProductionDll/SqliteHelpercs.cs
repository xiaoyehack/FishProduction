using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionDll
{
     
    public static class SqliteHelpercs
    {
        /*从配置文本中读取连接字符串*/
      
          private static string connStr = "data source=" + System.Environment.CurrentDirectory + "\\" + ConfigurationManager.ConnectionStrings["ProductionInfo"].ConnectionString;
        /*执行命令方法*/
        /*
        insert , update ,delete
        */

        /*
        params:可变参数，目的是省略了手动构造数组的过程，直接指定对象，编译器会帮助我们构造数组，并将对象加入数组中，传递过来
        */

        public static int ExecuteNonQuery(string sql,params SQLiteParameter[] ps)
        {
             
            /*创建连接对象*/
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                /*创建命令对象*/
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                /*添加参数*/
                cmd.Parameters.AddRange(ps);

                /*打开连接*/

                conn.Open();

                return cmd.ExecuteNonQuery();

            }
        }



        /*获取首行首列*/

        public static object ExecuteScalar(string sql,params SQLiteParameter[] ps)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddRange(ps);
                conn.Open();

                return cmd.ExecuteScalar();
            }
        }



        /*获取结果集*/
        public static DataTable GetDataTable(string sql,params SQLiteParameter[] ps)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connStr))
            {
                /*构造适配器对象*/
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);


                /*构造数据表，用于接受查询结果*/
                DataTable dt = new DataTable();

                /*添加参数*/
                adapter.SelectCommand.Parameters.AddRange(ps);

                /*执行结果*/
                adapter.Fill(dt);

                /*返回结果集*/

                return dt;



            }
        }

    }
}

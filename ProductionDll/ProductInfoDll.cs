using ProductionModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace ProductionDll
{
   
    public partial class ProductInfoDll
    {
        /// <summary>
        /// 查询获取结果集
        /// </summary>
        /// 

        public List<ProductInfo> GetList(Dictionary<string,string>dic)
        {
            //构造查询语言

            string sql = "select * from ProInfo";

            List<SQLiteParameter> listP = new List<SQLiteParameter>();

            if (dic.Count > 0)
            {
                foreach(var pair in dic)
                {
                    sql += " where " + pair.Key + " like @" + pair.Key;
                    listP.Add(new SQLiteParameter("@" + pair.Key, "%" + pair.Value + "%"));
                }
            }

            //使用Helper进行查询，得到结果
            DataTable dt = SqliteHelpercs.GetDataTable(sql,listP.ToArray());

            //将dt 中的数据转存到List中

            List<ProductInfo> list = new List<ProductInfo>();


            foreach (DataRow Row in dt.Rows)
            {
                list.Add(new ProductInfo()
                {
                    ID = Convert.ToInt32(Row["id"]),
                    BoardId = Row["boardid"].ToString(),
                    SimId = Row["SimId"].ToString(),
                    SofeEdti = Row["SofeEdti"].ToString(),
                    Prodate =Convert.ToDateTime( Row["prodate"]),
                    OtherOne = Row["OtherOne"].ToString (),
                    OtherTwo = Row["OtherTwo"].ToString()
                    
                });
            }

            return list;
        }

        public int Insert(ProductInfo mi)
        {
            //构造insert 

            string sql = "insert into ProInfo(BoardId,SimId,SofeEdti,Prodate,OtherOne,OtherTwo) values(@boardid,@Simid,@SofeEdti,@Prodate,@otherOne,@othertwo)";

            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@boardid",mi.BoardId),
                new SQLiteParameter("@Simid",mi.SimId),
                new SQLiteParameter("@sofeEdti",mi.SofeEdti),
                new SQLiteParameter("@Prodate",mi.Prodate),
                new SQLiteParameter("@otherOne",mi.OtherOne),
                new SQLiteParameter("@othertwo",mi.OtherTwo),
            };

            return SqliteHelpercs.ExecuteNonQuery(sql, ps);

        }

        public int Update(ProductInfo mi)
        {
            //构造Sql语句

            string sql = "update ProInfo set BoardId=@Boardid,SimId=@simid,SofeEdti=@sofeedti,Prodate=@prodate,OtherOne=@otherOne,OtherTwo=@otherNote where id=@id";


            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@Boardid",mi.BoardId),
                new SQLiteParameter("@simid",mi.SimId),
                new SQLiteParameter("@sofeedti",mi.SofeEdti),
                new SQLiteParameter("@prodate",mi.Prodate),
                new SQLiteParameter("@otherOne",mi.OtherOne),
                new SQLiteParameter("@otherNote",mi.OtherTwo),
                new SQLiteParameter("@id",mi.ID)
            };

            return SqliteHelpercs.ExecuteNonQuery(sql, ps);






        }

        public int Delete(int id)
        {
            string sql = "delete from ProInfo where id=@id";
            SQLiteParameter p = new SQLiteParameter("@id", id);
            return SqliteHelpercs.ExecuteNonQuery(sql, p);

        }

    }
}

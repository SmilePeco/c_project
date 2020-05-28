using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace TestPro
{
    static class DBConnect
    {
        public static string strSQL;
        //public static SqlConnection cn = null;
        public static SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NAKADB"].ConnectionString);
        public static SqlCommand cd = null;



        //////////////////////////////////////////////////
        //DB接続                                        //
        //////////////////////////////////////////////////
        public static void DBConnect_Main()
        {



            // 接続文字列の取得
            var connectionString = ConfigurationManager.ConnectionStrings["NAKADB"].ConnectionString;
            
            try
            {
                // データベース接続の準備
                SqlConnection cn = new SqlConnection(connectionString);
                // データベースの接続開始
                cn.Open();

//                // 実行するSQLの準備
//                strSQL = @"
//                 SELECT
//                   *
//                 FROM
//                   ORDER_TBL
//                ";

                //cd = new SqlCommand(strSQL, cn);
                //SqlDataReader drReader = cd.ExecuteReader();




                //drReader.Close();





            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
          


        }

        //////////////////////////////////////////////////
        //DBクローズ                                    //
        //////////////////////////////////////////////////
        public static void  DBConnect_Close(SqlConnection cn)
        {
            //OPENしていた場合は、CLOSEする
            if (cn.State == ConnectionState.Open)
            {
                //cn.Dispose();
                cn.Close();
            }


        }


        




    }







}




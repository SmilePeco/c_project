using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CT010_部品仮登録画面
{
    class CheckClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //部品コード チェック処理                       //
        //////////////////////////////////////////////////
        public Boolean Check_PartsCode(string strPartsCode){

            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 部品コード ";
            strSQL += "FROM ";
            strSQL += " PARTS_MS ";
            strSQL += "WHERE ";
            strSQL += " 部品コード = '" + strPartsCode + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                //存在した場合は、TRUEをかえす
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;


            }else{
                //存在しなかった場合は、FALSEをかえす
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;

            }


        }

        //////////////////////////////////////////////////
        //部品コード MAX値取得処理                       //
        //////////////////////////////////////////////////
        public string Check_PartsNoMAX(){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnValue = "1";
            int intCount = 0;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " COALESCE(MAX(部品登録NO), 0) AS 部品登録NO ";
            strSQL += "FROM ";
            strSQL += " PARTS_TBL ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                if (dtReader.Read()) { intCount = int.Parse(dtReader["部品登録NO"].ToString()); }
                intCount += 1;
                strReturnValue = Convert.ToString(intCount);
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;

            }else{
                //ありえないが、１をかえす。
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;
            }
        }
    }
}

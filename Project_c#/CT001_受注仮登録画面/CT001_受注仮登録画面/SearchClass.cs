using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CT001_受注仮登録画面
{
    class SearchClass
    {

        public string strSQL;

        public string Search_UnitPrice(string strProductCode){

            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnValue = "";
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 製品コード, ";
            strSQL += " 単価, ";
            strSQL += " 更新日 ";
            strSQL += "FROM ";
            strSQL += " PRODUCT_HISTORY_MS ";
            strSQL += "WHERE ";
            strSQL += "    製品コード = '" + strProductCode + "' ";
            strSQL += "AND 更新日 = (SELECT MAX(更新日) FROM PRODUCT_HISTORY_MS WHERE 製品コード = '" + strProductCode + "' ) ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                if (dtReader.Read()) { strReturnValue = dtReader["単価"].ToString().Trim(); }
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;


            }else{
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                strReturnValue = "0";
                return strReturnValue;
            }





        }

    }
}

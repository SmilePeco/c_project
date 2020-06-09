using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CT004_部品分類マスタメンテナンス
{
    class SearchClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //部品分類NO 連番取得処理                       //
        //////////////////////////////////////////////////
        public int Search_PartsClassNOMAX(){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            int intCount = 0;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " COALESCE(MAX(部品分類NO),0) AS 部品分類NO ";
            strSQL += "FROM ";
            strSQL += " PARTS_CLASS_MS";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                while (dtReader.Read()){
                    intCount = Convert.ToInt32(dtReader["部品分類NO"].ToString().Trim());
                }
                intCount += 1;
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return intCount;
            }else{
                //ありえないが、＋１にする
                intCount += 1;
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return intCount;
            }
        }

        //////////////////////////////////////////////////
        //部品分類NO 検索チェック処理                   //
        //////////////////////////////////////////////////
        public Boolean Search_PartsClassNO(string strPartsClassNO)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 部品分類NO ";
            strSQL += "FROM ";
            strSQL += " PARTS_CLASS_MS ";
            strSQL += "WHERE ";
            strSQL += " 部品分類NO = " + strPartsClassNO +" ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;


            }
            else
            {
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }

        }

        //////////////////////////////////////////////////
        //部品分類NO 部品分類名取得処理                //
        //////////////////////////////////////////////////
        public string Search_PartsClassName(string strPartsClassNO)
        {
            //変数定義
            SqlDataReader dtReader;
            SqlCommand cd = null;
            string strReturnValue = "";
            
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 部品分類名 ";
            strSQL += "FROM ";
            strSQL += " PARTS_CLASS_MS ";
            strSQL += "WHERE ";
            strSQL += " 部品分類NO = " + strPartsClassNO + " ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows)
            {
                if (dtReader.Read()) { strReturnValue = dtReader["部品分類名"].ToString().Trim(); } //値を取得
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;

            }
            else
            {
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;
            }

        }
    }
}

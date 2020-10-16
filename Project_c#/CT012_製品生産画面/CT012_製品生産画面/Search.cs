using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CT012_製品生産画面
{
    class Search
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        public Boolean Main(string strProductCode, ref string[] PartsCode, ref string[] PartsName)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " A.製品コード, ";
            strSQL += " IsNull(A.使用部品コード1, '') AS 使用部品コード1, ";
            strSQL += " IsNull(B.部品名, '') AS 使用部品名1, ";
            strSQL += " IsNull(A.使用部品コード2, '') AS 使用部品コード2, ";
            strSQL += " IsNull(C.部品名, '') AS 使用部品名2, ";
            strSQL += " IsNull(A.使用部品コード3, '') AS 使用部品コード3, ";
            strSQL += " IsNull(D.部品名, '') AS 使用部品名3  ";
            strSQL += "FROM ";
            strSQL += " PRODUCT_MS A ";
            strSQL += " LEFT JOIN PARTS_MS B ";
            strSQL += " ON  (A.使用部品コード1 = B.部品コード AND B.部品コード = (SELECT 使用部品コード1 FROM PRODUCT_MS WHERE 製品コード = '" + strProductCode + "' )) ";
            strSQL += " LEFT JOIN PARTS_MS C ";
            strSQL += " ON  (A.使用部品コード2 = C.部品コード AND C.部品コード = (SELECT 使用部品コード2 FROM PRODUCT_MS WHERE 製品コード = '" + strProductCode + "' )) ";
            strSQL += " LEFT JOIN PARTS_MS D ";
            strSQL += " ON  (A.使用部品コード3 = D.部品コード AND D.部品コード = (SELECT 使用部品コード3 FROM PRODUCT_MS WHERE 製品コード = '" + strProductCode + "' )) ";
            strSQL += "WHERE ";
            strSQL += "    A.製品コード = '" + strProductCode + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();

            //if (dtReader.HasRows || dtReader.Read()){
            if (dtReader.HasRows){
                //if (dtReader.Read()){
                dtReader.Read();
                for(int i = 1; i <= 3; i++){
                    PartsCode[i] = dtReader["使用部品コード" + i].ToString().Trim();
                    PartsName[i] = dtReader["使用部品名" + i].ToString().Trim();
                }
                //}

                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;
            }else{
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }
        }


        public string Search_OutputPartsNumber(string strPartsNo){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnValue = "";
            ////事前処理
            //PartsNoが空だった場合は、０にする
            if (strPartsNo == "") { strPartsNo = "0"; }
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 部品登録NO, ";
            strSQL += " 登録数 ";
            strSQL += "FROM ";
            strSQL += " PARTS_TBL ";
            strSQL += "WHERE ";
            strSQL += " 部品登録NO = " + strPartsNo + " ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                if (dtReader.Read()) { strReturnValue = dtReader["登録数"].ToString().Trim(); }
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;

            }else{
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;
            }

        }

    }
}

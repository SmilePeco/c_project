using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CT007_製品マスタメンテナンス
{
    class SearchClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //PRODUCT_MS 検索処理                           //
        //////////////////////////////////////////////////
        public string Search_ReturnValue(string strSELECTValue, string strWHEREValue){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReciveValue = "";
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " " + strSELECTValue +" " ;
            strSQL += "FROM ";
            strSQL += " PRODUCT_MS ";
            strSQL += "WHERE ";
            strSQL += " 製品コード = '" + strWHEREValue + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                if (dtReader.Read()) { strReciveValue = dtReader["" + strSELECTValue + ""].ToString().Trim(); }
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReciveValue;

            }else{
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReciveValue;
            }
        }


        //////////////////////////////////////////////////
        //検索前チェック処理                            //
        //////////////////////////////////////////////////
        public Boolean Search_Check(string strSearchProductCode){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 製品コード ";
            strSQL += "FROM ";
            strSQL += " PRODUCT_MS ";
            strSQL += "WHERE ";
            strSQL += " 製品コード = '" + strSearchProductCode + "'";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows)
            {
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
        //PRODUCT_HISYORY_MS 最新単価取得処理           //
        //////////////////////////////////////////////////
        public string Search_latestMoney(string strProductCode)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReciveValue = "";
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 単価 ";
            strSQL += "FROM ";
            strSQL += " PRODUCT_HISTORY_MS ";
            strSQL += "WHERE ";
            strSQL += "    製品コード = '" + strProductCode + "' ";
            strSQL += "AND 更新日 = (SELECT MAX(更新日) FROM PRODUCT_HISTORY_MS WHERE 製品コード = '" + strProductCode + "') ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                if (dtReader.Read()) { strReciveValue = dtReader["単価"].ToString().Trim(); }
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReciveValue;

            }else{
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReciveValue;
            }
        }

        //////////////////////////////////////////////////
        //PRODUCT_HISYORY_MS 全単価履歴取得             //
        //////////////////////////////////////////////////
        public DataSet Search_DataGridView(string strPartsCode)
        {
            //変数定義
            DataSet dsDataset = new DataSet();
            CTCommon.DataGridViewConnect DataGridViewConnect = new CTCommon.DataGridViewConnect();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 単価, ";
            strSQL += " 更新日 ";
            strSQL += "FROM ";
            strSQL += " PRODUCT_HISTORY_MS ";
            strSQL += "WHERE ";
            strSQL += " 製品コード = '" + strPartsCode + "' ";
            strSQL += "ORDER BY ";
            strSQL += " 更新日 DESC ";
            //DataSetの取得
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            //DataSetをかえす
            return dsDataset;
        }


        

    }
}

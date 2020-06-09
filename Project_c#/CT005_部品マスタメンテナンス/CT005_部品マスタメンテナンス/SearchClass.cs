using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CT005_部品マスタメンテナンス
{
    class SearchClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //部品NO 連番取得処理                           //
        //////////////////////////////////////////////////
        public int Search_ItemNOMAX(){

            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            int intCount = 0;

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += "  COALESCE(MAX(部品NO),0) AS 部品NO ";
            strSQL += "FROM ";
            strSQL += " PARTS_MS ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows)
            {
                while (dtReader.Read()){
                    intCount = Convert.ToInt32(dtReader["部品NO"].ToString().Trim());
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
        //部品No 検索処理                           //
        //////////////////////////////////////////////////
        public string Search_PartsNo(string strPartsCode)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnValue = "";

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 部品No ";
            strSQL += "FROM ";
            strSQL += " PARTS_MS ";
            strSQL += "WHERE ";
            strSQL += " 部品コード = '" + strPartsCode + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //drReader読込
            if (dtReader.HasRows)
            {
                while (dtReader.Read())
                {
                    strReturnValue = dtReader["部品No"].ToString().Trim();
                }
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





        //////////////////////////////////////////////////
        //部品コード 検索処理                           //
        //////////////////////////////////////////////////
        public string Search_PartsCode(string strPartsCode)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnValue = "";

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
            //drReader読込
            if (dtReader.HasRows){
                while (dtReader.Read()){
                    strReturnValue = dtReader["部品コード"].ToString().Trim();
                }
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

        //////////////////////////////////////////////////
        //部品名 検索処理                               //
        //////////////////////////////////////////////////
        public string Search_PartsName(string strPartsCode)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnValue = "";

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 部品名 ";
            strSQL += "FROM ";
            strSQL += " PARTS_MS ";
            strSQL += "WHERE ";
            strSQL += " 部品コード = '" + strPartsCode + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //drReader読込
            if (dtReader.HasRows){
                while (dtReader.Read()) { strReturnValue = dtReader["部品名"].ToString().Trim();   }
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

        //////////////////////////////////////////////////
        //部品分類NO 検索処理                           //
        //////////////////////////////////////////////////
        public string Search_PartsClassNo(string strPartsCode)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnValue = "";

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 部品分類No ";
            strSQL += "FROM ";
            strSQL += " PARTS_MS ";
            strSQL += "WHERE ";
            strSQL += " 部品コード = '" + strPartsCode + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //drReader読込
            if (dtReader.HasRows){
                while (dtReader.Read()) { strReturnValue = dtReader["部品分類No"].ToString().Trim(); }
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

        //////////////////////////////////////////////////
        //単価 最新単価取得処理                         //
        //////////////////////////////////////////////////
        public string Search_UpdateMoney(string strPartsCode)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnValue = "";

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 単価 ";
            strSQL += "FROM ";
            strSQL += " PARTS_HISTORY_MS ";
            strSQL += "WHERE ";
            strSQL += "    部品コード = '" + strPartsCode + "' ";
            strSQL += "AND 更新日 = (SELECT MAX(更新日) FROM PARTS_HISTORY_MS WHERE 部品コード = '" + strPartsCode + "') ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //drReader読込
            if (dtReader.HasRows){
                while (dtReader.Read()) { strReturnValue = dtReader["単価"].ToString().Trim(); }
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


        //////////////////////////////////////////////////
        //更新担当者 検索処理                           //
        //////////////////////////////////////////////////
        public string Search_HumanNo(string strPartsCode)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnValue = "";

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 最終更新者 ";
            strSQL += "FROM ";
            strSQL += " PARTS_MS ";
            strSQL += "WHERE ";
            strSQL += " 部品コード = '" + strPartsCode + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //drReader読込
            if (dtReader.HasRows)
            {
                while (dtReader.Read()) { strReturnValue = dtReader["最終更新者"].ToString().Trim(); }
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

        //////////////////////////////////////////////////
        //単価 DataGridView検索処理                     //
        //////////////////////////////////////////////////
        public DataSet Search_UpdateMoney_History(string strPartsCode)
        {
            //変数定義
            DataSet dsDataset;
            CTCommon.DataGridViewConnect DataGridViewConnect = new CTCommon.DataGridViewConnect();

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 単価, ";
            strSQL += " 更新日 ";
            strSQL += "FROM ";
            strSQL += " PARTS_HISTORY_MS ";
            strSQL += "WHERE ";
            strSQL += " 部品コード = '" + strPartsCode + "' ";
            strSQL += "ORDER BY ";
            strSQL += " 更新日 DESC ";
            //DataSetの取得
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            return dsDataset;

        }


    }
}

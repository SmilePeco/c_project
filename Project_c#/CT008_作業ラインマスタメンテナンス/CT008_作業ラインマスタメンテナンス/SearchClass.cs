using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CT008_作業ラインマスタメンテナンス
{
    class SearchClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //作業ライン 存在確認処理                       //
        //////////////////////////////////////////////////
        public Boolean Search_Check(string strWorklineNo)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtrReader;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 作業ラインNO ";
            strSQL += "FROM ";
            strSQL += " WORKLINE_MS ";
            strSQL += "WHERE ";
            strSQL += " 作業ラインNO = '" + strWorklineNo + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtrReader = cd.ExecuteReader();
            if (dtrReader.HasRows)
            {
                //存在した場合TRUE
                //クローズ処理
                dtrReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }
            else
            {
                //存在しない場合FALSE
                //クローズ処理
                dtrReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }

        }

        //////////////////////////////////////////////////
        //作業ライン名 取得処理                         //
        //////////////////////////////////////////////////
        public string Search_WorklineName(string strWorklineNo){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtrReader;
            string strReturnValue = "";
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 作業ライン名 ";
            strSQL += "FROM ";
            strSQL += " WORKLINE_MS ";
            strSQL += "WHERE ";
            strSQL += " 作業ラインNO = '" + strWorklineNo +"' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtrReader = cd.ExecuteReader();
            if (dtrReader.HasRows)
            {
                if (dtrReader.Read()) { strReturnValue = dtrReader["作業ライン名"].ToString().Trim(); }
                //クローズ処理
                dtrReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;

            }else{
                //クローズ処理
                dtrReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;
            }

        }

        //////////////////////////////////////////////////
        //工程NO 取得処理                               //
        //////////////////////////////////////////////////
        public string Search_ProcessNo(string strWorklineNo)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtrReader;
            string strReturnValue = "";
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 工程NO ";
            strSQL += "FROM ";
            strSQL += " WORKLINE_MS ";
            strSQL += "WHERE ";
            strSQL += " 作業ラインNO = '" + strWorklineNo + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtrReader = cd.ExecuteReader();
            if (dtrReader.HasRows)
            {
                if (dtrReader.Read()) { strReturnValue = dtrReader["工程NO"].ToString().Trim(); }
                //クローズ処理
                dtrReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;

            }
            else
            {
                //クローズ処理
                dtrReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;
            }
        }

        //////////////////////////////////////////////////
        //製品コード 取得処理                           //
        //////////////////////////////////////////////////
        public string Search_ProductCode(string strWorklineNo)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtrReader;
            string strReturnValue = "";
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 製品コード ";
            strSQL += "FROM ";
            strSQL += " WORKLINE_MS ";
            strSQL += "WHERE ";
            strSQL += " 作業ラインNO = '" + strWorklineNo + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtrReader = cd.ExecuteReader();
            if (dtrReader.HasRows)
            {
                if (dtrReader.Read()) { strReturnValue = dtrReader["製品コード"].ToString().Trim(); }
                //クローズ処理
                dtrReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;

            }
            else
            {
                //クローズ処理
                dtrReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;
            }
        }
    }
}

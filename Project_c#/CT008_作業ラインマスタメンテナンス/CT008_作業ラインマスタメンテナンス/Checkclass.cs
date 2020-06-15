using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CT008_作業ラインマスタメンテナンス
{
    class CheckClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //作業ラインNO MAX値取得処理                    //
        //////////////////////////////////////////////////
        public string Search_WorkLineNoMAX(){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            int intCount = 0;
            string strReturnValue = "";
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " COALESCE(MAX(作業ラインNO), 0) AS 作業ラインNO ";
            strSQL += "FROM ";
            strSQL += " WORKLINE_MS ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                //値を取得後、カウント＋１
                if (dtReader.Read()) { intCount = Convert.ToInt32(dtReader["作業ラインNO"].ToString().Trim()); }
                intCount += 1;
                //取得した値に０埋め処理
                strReturnValue = intCount.ToString().PadLeft(3, '0');
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;



            }else{
                //ありえないが、001をかえす
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                strReturnValue = "001";
                return strReturnValue;

            }


        }

        //////////////////////////////////////////////////
        //工程NO チェック処理                           //
        //////////////////////////////////////////////////
        public Boolean Check_ProcessNo(string strProcessNo)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 工程NO ";
            strSQL += "FROM ";
            strSQL += " PROCESS_MS ";
            strSQL += "WHERE ";
            strSQL += " 工程NO = '" + strProcessNo + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows)
            {
                //存在する場合は、エラー
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }
            else
            {
                //存在しない場合は、エラー
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;

            }


        }

        //////////////////////////////////////////////////
        //製品コード チェック処理                       //
        //////////////////////////////////////////////////
        public Boolean Check_ProductCode(string strProductCode)
        {
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
            strSQL += " 製品コード = '" + strProductCode + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                //存在する場合は、エラー
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }else{
                //存在しない場合は、エラー
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;

            }


        }


        //////////////////////////////////////////////////
        //更新担当者 チェック処理                       //
        //////////////////////////////////////////////////
        public Boolean Check_HumanNo(string strHumanNo)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 名前 ";
            strSQL += "FROM ";
            strSQL += " HUMAN_MS ";
            strSQL += "WHERE ";
            strSQL += " 名前 = '" + strHumanNo + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows)
            {
                //存在する場合は、エラー
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }
            else
            {
                //存在しない場合は、エラー
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;

            }


        }

    }
}

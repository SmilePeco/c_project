using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CT002_受注登録画面
{

    //検索前、登録前に呼び出されるチェッククラス
    class CheckClass
    {

        ///////////////////////////////////////////////////
        //検索チェック：受注先NO                         //
        //////////////////////////////////////////////////
        public Boolean OrderMS_Check(string strOrderMSNo)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strSQL;
            //DB接続
            CTCommon.DBConnect.DBConect_Main();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 受注先NO ";
            strSQL += "FROM ";
            strSQL += " ORDER_MS ";
            strSQL += "WHERE ";
            strSQL += " 受注先NO = '" + strOrderMSNo + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
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

        ///////////////////////////////////////////////////
        //検索チェック：受注NO                         //
        //////////////////////////////////////////////////
        public Boolean OrderNO_Check(string strOrderNo)
        {
            //変数定義
            SqlDataReader dtReader;
            string strSQL;
            SqlCommand cd = null;
            //受け取り値が空欄の場合は、０を代入
            if (strOrderNo == ""){
                strOrderNo = "0";
            }

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 受注NO ";
            strSQL += "FROM ";
            strSQL += " ORDER_TBL ";
            strSQL += "WHERE ";
            strSQL += " 受注NO = " + strOrderNo + " ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
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


        ///////////////////////////////////////////////////
        //登録チェック：更新担当者                      //
        //////////////////////////////////////////////////
        public Boolean HumanMS_Check(string strHumanNo){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strSQL;
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
            //dtReader読込
            if (dtReader.HasRows){
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }else{
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }




        }

    }

}


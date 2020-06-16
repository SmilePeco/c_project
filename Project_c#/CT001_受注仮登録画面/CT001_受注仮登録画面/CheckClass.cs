using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CT001_受注仮登録画面
{
    class CheckClass
    {

        //////////////////////////////////////////////////
        //受注先NOチェック処理                          //
        //////////////////////////////////////////////////
        public Boolean smCheck_OrderMS(string strOrderMSNo){

            //変数定義
            string strSQL;
            SqlDataReader dtReader;
            SqlCommand cd = null;
            

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
            //DataReader読込
            if(dtReader.HasRows){
                //存在した場合はTRUEを返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }else{
                //存在しなかった場合はエラーを返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }
            
        }

        //////////////////////////////////////////////////
        //製品コードチェック処理                        //
        //////////////////////////////////////////////////
        public Boolean smCheck_ProductMS(string strProductCode)
        {
            //変数定義
            string strSQL;
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
            //dtReader読込
            if (dtReader.HasRows)
            {
                //存在した場合はTRUEを返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }
            else
            {
                //存在しなかった場合はエラーを返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;

            }
        }



        //////////////////////////////////////////////////
        //作業ラインNOチェック処理                        //
        //////////////////////////////////////////////////
        public Boolean smCheck_WorklineMS(string strWorklineMS){
            //変数定義
            string strSQL;
            SqlCommand cd = null;
            SqlDataReader dtReader;

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 作業ラインNO ";
            strSQL += "FROM ";
            strSQL += " WORKLINE_MS ";
            strSQL += "WHERE ";
            strSQL += " 作業ラインNO = '" + strWorklineMS +  "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
            if (dtReader.HasRows){
                //存在した場合はTRUEを返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }else {
                //存在しなかった場合はエラーを返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
                       
            }


        }

        //////////////////////////////////////////////////
        //更新担当者チェック処理                        //
        //////////////////////////////////////////////////
        public Boolean smCheck_HumanMS(string strHumanMSNo){
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
            strSQL += " 名前 = '" + strHumanMSNo + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReaderの読込
            if (dtReader.HasRows){
                //存在した場合はTRUEを返す
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }else{
                //存在しなかった場合はエラーを返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }
        }




    }
}

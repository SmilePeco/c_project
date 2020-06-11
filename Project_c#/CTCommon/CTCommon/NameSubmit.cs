using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CTCommon
{
    public class NameSubmit
    {

        //////////// 概要 ////////////
       //
 
        public string strSQL;
        public string strReturnName = ""; //返却用変数 


        //////////////////////////////////////////////////
        //受注先名 名前代入処理                         //
        //////////////////////////////////////////////////
        public string OrderMSName_Submit(string strOrderMSNo){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            //DB接続
            DBConnect.DBConect_Main();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 受注先名 ";
            strSQL += "FROM ";
            strSQL += " ORDER_MS ";
            strSQL += "WHERE ";
            strSQL += " 受注先NO = '" + strOrderMSNo + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, DBConnect.cn);
            DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
            if (dtReader.HasRows){
                while (dtReader.Read()){
                    //取得した値を変数に代入
                    strReturnName = dtReader["受注先名"].ToString().Trim();
                    
                }
                //クローズ処理
                dtReader.Close();
                DBConnect.DBConnect_Close(DBConnect.cn);
                return strReturnName;
                
            }else{
                //クローズ処理
                dtReader.Close();
                DBConnect.DBConnect_Close(DBConnect.cn);
                return strReturnName;
            }

        }

        //////////////////////////////////////////////////
        //作業工程名 名前代入処理                       //
        //////////////////////////////////////////////////
        public string WorkProcessMSName_Submit(string strWorkProcessNo){
            //変数定義
            SqlDataReader dtReader;
            SqlCommand cd = null;
            //DB接続
            DBConnect.DBConect_Main();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 作業工程名 ";
            strSQL += "FROM ";
            strSQL += " WORKPROCESS_MS ";
            strSQL += "WHERE ";
            strSQL += " 作業工程NO = '" + strWorkProcessNo + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, DBConnect.cn);
            DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                while (dtReader.Read()){
                    strReturnName = dtReader["作業工程名"].ToString().Trim();
                }
                //クローズ処理
                dtReader.Close();
                DBConnect.DBConnect_Close(DBConnect.cn);
                return strReturnName;

            }else{
                //クローズ処理
                dtReader.Close();
                DBConnect.DBConnect_Close(DBConnect.cn);
                return strReturnName;
            }
        }


        //////////////////////////////////////////////////
        //部品名 名前代入処理                           //
        //////////////////////////////////////////////////
        public string PartsName_Submit(string strPartsCode)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
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
            //dtReader読込
            if (dtReader.HasRows){
                if (dtReader.Read()) { strReturnName = dtReader["部品名"].ToString().Trim(); }
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnName;

            }else{
                //ありえないが、空白をかえす
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnName;

            }



        }

    }
}

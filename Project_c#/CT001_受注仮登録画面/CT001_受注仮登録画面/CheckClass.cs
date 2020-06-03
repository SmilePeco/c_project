using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CT001_受注登録画面
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
            //DataReader読込
            if(dtReader.HasRows){
                //存在した場合はTRUEを返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }else{
                //存在しなかった場合はエラーを返す
                MessageBox.Show("入力した受注先NOは存在しません。 \r\n確認してください。","エラー",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }
            
        }

        //////////////////////////////////////////////////
        //作業工程NOチェック処理                        //
        //////////////////////////////////////////////////
        public Boolean smCheck_ShipmentMS(string strShipmentMSNo){
            //変数定義
            string strSQL;
            SqlCommand cd = null;
            SqlDataReader dtReader;

            //DB接続
            CTCommon.DBConnect.DBConect_Main();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 作業工程NO ";
            strSQL += "FROM ";
            strSQL += " WORKPROCESS_MS ";
            strSQL += "WHERE ";
            strSQL += " 作業工程NO = '" + strShipmentMSNo +  "' ";
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
                MessageBox.Show("入力した作業工程NOは存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            string strSQL;
            SqlDataReader dtReader;
            //DB接続
            CTCommon.DBConnect.DBConect_Main();
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
                MessageBox.Show("入力した更新担当者は存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;

            }




        }

    }
}

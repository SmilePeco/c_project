using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CT007_製品マスタメンテナンス
{
    class CheckClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //製品NO MAX値取得処理                          //
        //////////////////////////////////////////////////
        public int Check_ProductNoMAX()
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            int intReturnValue = 0;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " COALESCE(MAX(製品NO), 0) AS 製品NO ";
            strSQL += "FROM ";
            strSQL += " PRODUCT_MS ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
            if (dtReader.HasRows){
                if (dtReader.Read()) { intReturnValue = Convert.ToInt32(dtReader["製品NO"].ToString()); }
                intReturnValue += 1;
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return intReturnValue;

            }else{
                //ありえないが、１をかえす
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                intReturnValue += 1;
                return intReturnValue;
            }
        }

        //////////////////////////////////////////////////
        //倉庫NO 存在チェック処理                       //
        //////////////////////////////////////////////////
        public Boolean Check_WarehouseNo(string strWarehouseNo)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 倉庫NO ";
            strSQL += "FROM ";
            strSQL += " WAREHOUSE_MS ";
            strSQL += "WHERE ";
            strSQL += " 倉庫NO = " + strWarehouseNo + " ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                //存在した場合、TRUE
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }else{
                //存在しない場合、false
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }
        }


        //////////////////////////////////////////////////
        //部品コード 存在チェック処理                   //
        //////////////////////////////////////////////////
        public Boolean Check_PartsCode(string strPartsCode)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
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
            if (dtReader.HasRows)
            {
                //存在した場合、TRUE
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }
            else
            {
                //存在しない場合、false
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }



        }

        //////////////////////////////////////////////////
        //更新担当者 存在チェック処理                   //
        //////////////////////////////////////////////////
        public Boolean Check_HumanMS(string strHumanNo)
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
                //存在した場合、TRUE
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }
            else
            {
                //存在しない場合、false
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }



        }

        //////////////////////////////////////////////////
        //製品コード 存在チェック処理                   //
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
                //存在した場合、false
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;

            }else{
                //存在しない場合、TRUE
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;
            }
        }



    }
}

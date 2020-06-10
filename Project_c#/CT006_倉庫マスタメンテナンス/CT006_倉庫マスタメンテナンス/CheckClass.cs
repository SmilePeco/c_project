using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CT006_倉庫マスタメンテナンス
{
    class CheckClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //倉庫NO 最大値取得処理                         //
        //////////////////////////////////////////////////
        public int Check_WarehouseNoMAX()
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            int intRetunValue = 0;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " COALESCE(MAX(倉庫NO), 0) AS 倉庫NO ";
            strSQL += "FROM ";
            strSQL += " WAREHOUSE_MS ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
            if (dtReader.HasRows)
            {
                if (dtReader.Read()) { intRetunValue = Convert.ToInt32(dtReader["倉庫NO"].ToString().Trim()); }

                //クローズ処理
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                dtReader.Close();
                intRetunValue += 1;
                return intRetunValue;

            }
            else
            {
                //ありえないが、１を返す
                //クローズ処理
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                dtReader.Close();
                intRetunValue += 1;
                return intRetunValue;

            }
        }

        //////////////////////////////////////////////////
        //更新担当者 存在チェック                       //
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
            //dtReader読込
            if (dtReader.HasRows){
                //存在した場合はTRUE
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }else{
                //存在しない場合はFALSE
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;

            }

        }

        //////////////////////////////////////////////////
        //倉庫NO 存在チェック                           //
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
            //dtReader読込
            if (dtReader.HasRows)
            {
                //存在する場合は、TRUE
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }
            else
            {
                //存在しない場合は、FALSE
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }



        }

        //////////////////////////////////////////////////
        //倉庫名 取得                                   //
        //////////////////////////////////////////////////
        public String Check_WarehouseName(string strWarehouseNo)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnvalue = "";
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 倉庫名 ";
            strSQL += "FROM ";
            strSQL += " WAREHOUSE_MS ";
            strSQL += "WHERE ";
            strSQL += " 倉庫NO = " + strWarehouseNo + " ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
            if (dtReader.HasRows)
            {
                if (dtReader.Read()) { strReturnvalue = dtReader["倉庫名"].ToString().Trim(); }
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnvalue;

            }
            else
            {
                //ありえないが、ブランクをかえす
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnvalue;
            }



        }

        //////////////////////////////////////////////////
        //倉庫NO 製品マスタに存在するかチェック         //
        //////////////////////////////////////////////////
        public Boolean Check_ProductMS(string strWarehouseNo) {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += "  A.倉庫NO ";
            strSQL += "FROM ";
            strSQL += " PRODUCT_MS A, ";
            strSQL += " WAREHOUSE_MS B ";
            strSQL += "WHERE ";
            strSQL += "    B.倉庫NO = " + strWarehouseNo + " ";
            strSQL += "AND A.倉庫NO = B.倉庫NO ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
            if (dtReader.HasRows){
                //存在した場合は、FALSE
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }else{
                //存在しない場合は、TRUE
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;


            }

        

        
        
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CT009_受注先マスタメンテナンス
{
    class SearchClass
    {

        public string strSQL;

        //////////////////////////////////////////////////
        //受注先NO 存在チェック処理                     //
        //////////////////////////////////////////////////
        public Boolean Search_Check(string strSearchOrderMSNO){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 受注先NO ";
            strSQL += "FROM ";
            strSQL += " ORDER_MS ";
            strSQL += "WHERE ";
            strSQL += " 受注先NO = '" + strSearchOrderMSNO + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
            if (dtReader.HasRows){
                //存在していた場合、TRUE
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;
            }else{
                //存在していない場合、false
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }
        }

        //////////////////////////////////////////////////
        //受注先NO MAX値取得                     //
        //////////////////////////////////////////////////
        public string Search_OrderMSNoMAX()
        {
            //SQL発行
            string strReturnValue = "";
            SqlCommand cd = null;
            SqlDataReader dtReader;
            int intCount = 0;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " COALESCE(MAX(受注先NO), 0) AS 受注先NO ";
            strSQL += "FROM ";
            strSQL += " ORDER_MS ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                //取得し、＋１
                if (dtReader.Read()) { intCount = Convert.ToInt32(dtReader["受注先NO"].ToString().Trim()); }
                intCount += 1;
                //０埋め
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
        //値検索処理                                    //
        //////////////////////////////////////////////////
        public string Search_Values(string strCount, string strOrderMSNo){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnValue = "";
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 受注先名, ";
            strSQL += " 受注先担当者名, ";
            strSQL += " 受注先電話番号, ";
            strSQL += " 受注先住所１, ";
            strSQL += " 受注先住所２ ";
            strSQL += "FROM ";
            strSQL += " ORDER_MS ";
            strSQL += "WHERE ";
            strSQL += " 受注先NO = '" + strOrderMSNo +"' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows)
            {
                if (dtReader.Read())
                {
                    if (strCount == "1") { strReturnValue = dtReader["受注先名"].ToString().Trim(); }//Count=1、受注先名の場合
                    if (strCount == "2") { strReturnValue = dtReader["受注先担当者名"].ToString().Trim(); }//Count=2、受注先担当者名の場合
                    if (strCount == "3") { strReturnValue = dtReader["受注先電話番号"].ToString().Trim(); }//Count=3、受注先電話番号の場合
                    if (strCount == "4") { strReturnValue = dtReader["受注先住所１"].ToString().Trim(); }//Count=4、受注先住所１の場合
                    if (strCount == "5") { strReturnValue = dtReader["受注先住所２"].ToString().Trim(); }//Count=5、受注先住所２の場合
                }

                    //クローズ処理
                    dtReader.Close();
                    CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                    return strReturnValue;


                }else{
                    //ありえないが、空をかえす
                    //クローズ処理
                    dtReader.Close();
                    CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                    return strReturnValue;
                }

            
        }




    }
}

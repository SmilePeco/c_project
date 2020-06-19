using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CT012_製品生産画面
{
    class SubmitClass
    {

        public string strSQL;

        //////////////////////////////////////////////////
        //部品登録テーブル 計算判定・SQL生成処理        //
        //////////////////////////////////////////////////
        public string Submit_Calc_PartsTBL(SqlTransaction tran, string strPartsNo, string strConsumeNumber)
        {
            //変数定義
            SqlDataReader dtReader;
            SqlCommand cd = null;
            string strCheckValue = "";
            int intConsumeNumber; //数値変換用
            int intCheckValue; //数値変換用
            ////登録数－使用数＝０だった場合は、DELETEする
            ////それ以外の場合は、UPDATEで減算する
            //現在の登録数を取得する
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 登録数 ";
            strSQL += "FROM ";
            strSQL += " PARTS_TBL ";
            strSQL += "WHERE ";
            strSQL += " 部品登録NO = " + strPartsNo + " ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            cd.Transaction = tran;
            dtReader = cd.ExecuteReader();
            if (dtReader.Read()) { strCheckValue = dtReader["登録数"].ToString(); }
            dtReader.Close();
            //文字列→数値変換
            int.TryParse(strConsumeNumber, out intConsumeNumber);
            int.TryParse(strCheckValue, out intCheckValue);
            ////確認処理
            if (intCheckValue - intConsumeNumber != 0){
                //UPDATEで減算処理
                //SQL発行
                strSQL = "";
                strSQL += "UPDATE PARTS_TBL ";
                strSQL += "SET ";
                strSQL += " 登録数 -= " + strConsumeNumber + " ";
                strSQL += "WHERE ";
                strSQL += " 部品登録NO = " + strPartsNo + " ";
                //SQLをかえす
                return strSQL;
            }else{
                //DELETE処理
                //DELETE処理の場合は、PARTS_TBLとPARTS_HISTORY_TBLの２つを削除するため、
                //一旦そのままかえす
                return "DELETE";
                //SQL発行
                //strSQL = "";
                //strSQL += "DELETE FROM PARTS_TBL ";
                //strSQL += "WHERE 部品登録NO = " + strPartsNo + " ";
                //SQLをかえす
            }
        }

        //////////////////////////////////////////////////
        //部品登録テーブル 削除SQL生成処理              //
        //////////////////////////////////////////////////
        public string Submit_PartsTBLDelete(string strPartsNo){
            //SQL発行
            strSQL = "";
            strSQL += "DELETE FROM PARTS_TBL ";
            strSQL += "WHERE 部品登録NO = " + strPartsNo + " ";
            //SQLをかえす
            return strSQL;
        }

        //////////////////////////////////////////////////
        //部品履歴登録テーブル 削除SQL生成処理          //
        //////////////////////////////////////////////////
        public string Submit_PartsHistoryTBLDelete(string strPartsNo)
        {
            //SQL発行
            strSQL = "";
            strSQL += "DELETE FROM PARTS_HISTORY_TBL ";
            strSQL += "WHERE 部品登録NO = " + strPartsNo + " ";
            //SQLをかえす
            return strSQL;
        }

        //////////////////////////////////////////////////
        //部品消費履歴テーブル SQL発行                  //
        //////////////////////////////////////////////////
        public string Submit_PartsConsume(SqlTransaction tran, int intConsumeNo, string strPartsNo, string strPartsCode, int intReNumber, string strConsumeNumber, string strHumanNo){

            //SQL発行
            strSQL = "";
            strSQL += "INSERT INTO PARTS_CONSUME_HISTORY_TBL VALUES ";
            strSQL += "( ";
            strSQL += " " + intConsumeNo +", "; // 部品消費登録NO
            strSQL += " " + strPartsNo + ", "; //部品登録NO
            strSQL += " '" + strPartsCode + "', "; //使用部品コード
            strSQL += " " + strConsumeNumber + ", "; //消費数
            strSQL += " " + intReNumber +", "; //消費後残数
            strSQL += " '" + strHumanNo + "', "; //更新担当者
            strSQL += " SYSDATETIME(), "; //更新日
            strSQL += " SYSDATETIME() "; //登録日
            strSQL += ") ";
            //SQLをかえす
            return strSQL;

        }

        //////////////////////////////////////////////////
        //部品消費履歴テーブル MAX値取得処理            //
        //////////////////////////////////////////////////
        public int Submit_PartsConsumeMAX(SqlTransaction tran){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strCount = "";
            int intCount = 0;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " COALESCE(MAX(部品消費登録NO), 0) AS 部品消費登録NO ";
            strSQL += "FROM ";
            strSQL += " PARTS_CONSUME_HISTORY_TBL ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            cd.Transaction = tran;
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                if (dtReader.Read()) { strCount = dtReader["部品消費登録NO"].ToString(); }
                int.TryParse(strCount, out intCount);
                intCount += 1;
                dtReader.Close();
                return intCount;
            }else{
                //ありえないが、１をかえす
                dtReader.Close();
                intCount = 1;
                return intCount;

            }
        }

        //////////////////////////////////////////////////
        //部品登録テーブル 残数取得処理                 //
        //////////////////////////////////////////////////
        public int Submit_PartsTBLReNumber(SqlTransaction tran, string strPartsNo){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strCount = "";
            int intCount = 0;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 登録数 ";
            strSQL += "FROM ";
            strSQL += " PARTS_TBL ";
            strSQL += "WHERE ";
            strSQL += " 部品登録NO = " + strPartsNo + " ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            cd.Transaction = tran;
            dtReader = cd.ExecuteReader();
            if (dtReader.Read()) { strCount = dtReader["登録数"].ToString(); }
            dtReader.Close();
            //文字列→数値変換
            int.TryParse(strCount, out intCount);
            return intCount;

        }

        //////////////////////////////////////////////////
        //部品テーブル SQL発行                          //
        //////////////////////////////////////////////////
        public string Submit_ProductTBL(int intProductNoMAX, string strProductCode, string strProductNumber, string strHumanNO){
            //SQL発行
            strSQL = "";
            strSQL += "INSERT INTO PRODUCT_TBL VALUES ";
            strSQL += "( ";
            strSQL += " " + intProductNoMAX + ", "; //生産NO
            strSQL += " '" + strProductCode + "', "; //製品コード
            strSQL += " " + strProductNumber + ", "; //生産数
            strSQL += " '" + strHumanNO + "', "; //最終更新者
            strSQL += " SYSDATETIME(), "; //更新日
            strSQL += " SYSDATETIME() "; //登録日
            strSQL += ") ";
            //SQLをかえす
            return strSQL;

        }

        //////////////////////////////////////////////////
        //部品履歴テーブル SQL発行                          //
        //////////////////////////////////////////////////
        public string Submit_ProductHistoryTBL(int intProductNoMAX,string strProductCode, string strProductNumber, string strDTPSubmit, string strPartsCode1, string strPartsNo1, string strPartsCode2, string strPartsNo2,string strPartsCode3, string strPartsNo3, string strHumanNo){
            //SQL発行
            strSQL = "";
            strSQL += "INSERT INTO PRODUCT_HISTORY_TBL VALUES ";
            strSQL += "( ";
            strSQL += " " + intProductNoMAX +", "; //生産NO
            strSQL += " '" + strProductCode + "', "; //製品コード
            strSQL += " " + strProductNumber + ", "; //生産数
            strSQL += " '" + strDTPSubmit + "', "; //生産日
            strSQL += " '" + strPartsCode1 + "', "; //使用部品コード１
            strSQL += " '" + strPartsNo1 + "', "; //使用部品登録NO１
            strSQL += " '" + strPartsCode2 + "',"; //使用部品コード２
            strSQL += " '" + strPartsNo2 + "', "; //使用部品登録NO２
            strSQL += " '" + strPartsCode3 + "', "; //使用部品コード３
            strSQL += " '" + strPartsNo3 + "', "; //使用部品登録NO３
            strSQL += " '" + strHumanNo + "', "; //最終更新者
            strSQL += " SYSDATETIME(), "; //更新日
            strSQL += " SYSDATETIME() "; //登録日
            strSQL += ") ";
            //SQLをかえす
            return strSQL;

        }


        //////////////////////////////////////////////////
        //部品テーブル MAX値取得処理                    //
        //////////////////////////////////////////////////
        public int Submit_ProductNoMAX(SqlTransaction tran){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strCount = "";
            int intCount = 0;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " COALESCE(MAX(生産NO), 0) AS 生産NO ";
            strSQL += "FROM ";
            strSQL += " PRODUCT_TBL ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            cd.Transaction = tran;
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                if (dtReader.Read()) { strCount = dtReader["生産NO"].ToString(); }
                int.TryParse(strCount, out intCount);
                intCount += 1;
                dtReader.Close();
                return intCount;
            }else{
                //ありえないが、１をかえす
                dtReader.Close();
                intCount = 1;
                return intCount;

            }
        }






    }
}

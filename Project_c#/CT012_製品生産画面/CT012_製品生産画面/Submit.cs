using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CT012_製品生産画面
{
    class Submit
    {

        public string strSQL;

        //////////////////////////////////////////////////
        //部品登録テーブル 計算判定・SQL生成処理        //
        //////////////////////////////////////////////////
        //public string JUDGE_PARTS_TBL(SqlTransaction tran, string strPartsNo, string strConsumeNumber)
        public string JUDGE_PARTS_TBL(SqlTransaction tran,  string strPartsNo, string strConsumeNumber)
        {
            //変数定義
            SqlDataReader dtReader;
            SqlCommand cd = null;
            string strCheckValue = "";

            //【備考】：登録数－使用数＝０だった場合は、DELETEする。それ以外の場合は、UPDATEで減算する
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 登録数 ";
            strSQL += "FROM ";
            strSQL += " PARTS_TBL ";
            strSQL += "WHERE ";
            strSQL += " 部品登録NO = " + strPartsNo + " ";

            try{
                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                cd.Transaction = tran;
                dtReader = cd.ExecuteReader();
                if (dtReader.Read()) { strCheckValue = dtReader["登録数"].ToString(); }
                dtReader.Close();
                //【備考】：計算するための数値変換
                int intConsumeNumber;
                int intCheckValue;
                int.TryParse(strConsumeNumber, out intConsumeNumber);
                int.TryParse(strCheckValue, out intCheckValue);
                if (intCheckValue - intConsumeNumber != 0)
                {
                    //【備考】：計算処理SQLをここで作成しておく
                    strSQL = "";
                    strSQL += "UPDATE PARTS_TBL ";
                    strSQL += "SET ";
                    strSQL += " 登録数 -= " + intConsumeNumber + " ";
                    strSQL += "WHERE ";
                    strSQL += " 部品登録NO = " + strPartsNo + " ";
                    return strSQL;
                }else{
                    return "DELETE";
                }
            }catch (Exception e){
                MessageBox.Show(e.Message);
                return strSQL;

            }finally{
                //CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
            }

        }

        //////////////////////////////////////////////////
        //部品登録テーブル 削除SQL生成処理              //
        //////////////////////////////////////////////////
        public string DELETE_PARTS_TBL(string strPartsNo){
            strSQL = "";
            strSQL += "DELETE FROM PARTS_TBL ";
            strSQL += "WHERE 部品登録NO = " + strPartsNo + " ";
            return strSQL;
        }

        //////////////////////////////////////////////////
        //部品履歴登録テーブル 削除SQL生成処理          //
        //////////////////////////////////////////////////
        public string DELETE_PARTS_HISTORY_TBL(string strPartsNo)
        {
            strSQL = "";
            strSQL += "DELETE FROM PARTS_HISTORY_TBL ";
            strSQL += "WHERE 部品登録NO = " + strPartsNo + " ";
            return strSQL;
        }

        //////////////////////////////////////////////////
        //部品消費履歴テーブル SQL発行                  //
        //////////////////////////////////////////////////
        public string INSERT_PARTS_CONSUME_HISTORY_TBL(SqlTransaction tran, int SQL_HISTORYTBL_MaxNo, string[] ConsumeParts, int SQL_HISTORYTBL_ReNumber, string[] OthersName)
        {
            strSQL = "";
            strSQL += "INSERT INTO PARTS_CONSUME_HISTORY_TBL VALUES ";
            strSQL += "( ";
            strSQL += " " + SQL_HISTORYTBL_MaxNo + ", "; // 部品消費登録NO
            strSQL += " " + ConsumeParts[0] + ", "; //部品登録NO
            strSQL += " '" + ConsumeParts[1] + "', "; //使用部品コード
            strSQL += " " + OthersName[0] + ", "; //消費数
            strSQL += " " + SQL_HISTORYTBL_ReNumber + ", "; //消費後残数
            strSQL += " '" + OthersName[1] + "', "; //更新担当者
            strSQL += " SYSDATETIME(), "; //更新日
            strSQL += " SYSDATETIME() "; //登録日
            strSQL += ") ";
            return strSQL;

        }

        //////////////////////////////////////////////////
        //部品消費履歴テーブル MAX値取得処理            //
        //////////////////////////////////////////////////
        public int Submit_PartsConsumeMAX(SqlTransaction tran)
        {
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strCount = "";
            int intCount = 1;
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " COALESCE(MAX(部品消費登録NO), 0) AS 部品消費登録NO ";
            strSQL += "FROM ";
            strSQL += " PARTS_CONSUME_HISTORY_TBL ";

            try{
                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                cd.Transaction = tran;
                dtReader = cd.ExecuteReader();
                if (dtReader.HasRows)
                {
                    if (dtReader.Read()) { strCount = dtReader["部品消費登録NO"].ToString(); }
                    int.TryParse(strCount, out intCount);
                    intCount += 1;
                    dtReader.Close();
                    return intCount;
                }else{
                    //【備考】：ありえないが、１をかえす
                    dtReader.Close();
                    return intCount;
                }
            }catch (Exception e){
                MessageBox.Show(e.Message);
                return intCount;
            }finally{
                //CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
            }


        }

        //////////////////////////////////////////////////
        //部品登録テーブル 残数取得処理                 //
        //////////////////////////////////////////////////
        public int Submit_PartsTBLReNumber(SqlTransaction tran, string strPartsNo)
        {
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strCount = "";
            int intCount = 0;
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 登録数 ";
            strSQL += "FROM ";
            strSQL += " PARTS_TBL ";
            strSQL += "WHERE ";
            strSQL += " 部品登録NO = " + strPartsNo + " ";

            try{
                
                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                cd.Transaction = tran;
                dtReader = cd.ExecuteReader();
                if (dtReader.Read()) { strCount = dtReader["登録数"].ToString(); }
                dtReader.Close();
                int.TryParse(strCount, out intCount);
                return intCount;

            }catch (Exception e){
                MessageBox.Show(e.Message);
                return intCount;
            }finally{
                //CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
            }



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
            return strSQL;

        }

        //////////////////////////////////////////////////
        //部品履歴テーブル SQL発行                          //
        //////////////////////////////////////////////////
        public string Submit_ProductHistoryTBL(int intProductNoMAX,string strProductCode, string strProductNumber, string strDTPSubmit, string strPartsCode1, string strPartsNo1, string strPartsCode2, string strPartsNo2,string strPartsCode3, string strPartsNo3, string strHumanNo){
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
            return strSQL;

        }


        //////////////////////////////////////////////////
        //部品テーブル MAX値取得処理                    //
        //////////////////////////////////////////////////
        public int Submit_ProductNoMAX(SqlTransaction tran){
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strCount = "";
            int intCount = 0;
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " COALESCE(MAX(生産NO), 0) AS 生産NO ";
            strSQL += "FROM ";
            strSQL += " PRODUCT_TBL ";
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
                //【備考】：ありえないが、１をかえす
                dtReader.Close();
                intCount = 1;
                return intCount;

            }
        }






    }
}

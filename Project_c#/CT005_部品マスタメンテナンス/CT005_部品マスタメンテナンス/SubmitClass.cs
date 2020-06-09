using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CT005_部品マスタメンテナンス
{
    class SubmitClass{

        public string strSQL;


        ///////////////////////////////////////////////////
        //部品マスタ：SQL生成処理                       //
        //////////////////////////////////////////////////
        public string Submit_Main_PARTS_MS(string strMode, string strPartsNo, string strPartsCode, string strPartsName, string strPartsClassNo, string strMoney, string strHumanNo){
                
           //更新モードか登録モードか判定
            if (strMode == "更新")
            {
                //更新の場合
                //PARTS_MS登録のSQL発行
                strSQL = "";
                strSQL += "UPDATE PARTS_MS ";
                strSQL += "SET ";
                strSQL += " 部品名 = '" + strPartsName +"', ";
                strSQL += " 部品分類NO = " + strPartsClassNo +", ";
                strSQL += " 最終更新者 = '" + strHumanNo + "', ";
                strSQL += " 更新日 = SYSDATETIME() ";
                strSQL += "WHERE ";
                strSQL += " 部品コード = '" + strPartsCode +"' ";
                //SQL文を返す
                return strSQL;

            }else{
                //登録の場合
                //PARTS_MS登録のSQL発行
                strSQL = "";
                strSQL += "INSERT INTO PARTS_MS VALUES ";
                strSQL += "( ";
                strSQL += " " + strPartsNo + ", "; //部品NO
                strSQL += " '" + strPartsCode + "', "; //部品コード
                strSQL += " '" + strPartsName + "', "; //部品名
                strSQL += " " + strPartsClassNo + ", "; //部品分類NO
                strSQL += " '" + strHumanNo + "', "; //最終更新者
                strSQL += " SYSDATETIME(), "; //更新日
                strSQL += " SYSDATETIME() "; //登録日
                strSQL += ") ";
                //strSQLを返す
                return strSQL;




            }



        }


        ///////////////////////////////////////////////////
        //部品マスタ：SQL生成処理                       //
        //////////////////////////////////////////////////

        public string Submit_Main_PARTS_HISORY_MS(string strMode, string strPartsNo, string strPartsCode, string strPartsName, string strPartsClassNo, string strMoney, string strHumanNo)
        {

            //更新モードか登録モードか判定
            if (strMode == "更新")
            {
                //更新の場合
                //PARTS_HISTORY_MSのSQL
                strSQL = "";
                strSQL += "INSERT INTO PARTS_HISTORY_MS VALUES ";
                strSQL += "( ";
                strSQL += " '" + strPartsCode + "', "; //部品コード
                strSQL += " SYSDATETIME(), "; //更新日
                strSQL += " " + strMoney + ", "; //単価
                strSQL += " '" + strHumanNo + "' ";  //更新担当者
                strSQL += ") ";
                //strSQLを返す
                return strSQL;

            }
            else
            {
                //登録の場合
                //PARTS_HISTORY_MSのSQL
                strSQL = "";
                strSQL += "INSERT INTO PARTS_HISTORY_MS VALUES ";
                strSQL += "( ";
                strSQL += " '" + strPartsCode + "', "; //部品コード
                strSQL += " SYSDATETIME(), "; //更新日
                strSQL += " " + strMoney + ", "; //単価
                strSQL += " '" + strHumanNo + "' ";  //更新担当者
                strSQL += ") ";
                //strSQLを返す
                return strSQL;
            }

            
        }

    }
}

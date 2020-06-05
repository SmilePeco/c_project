using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CT003_社員マスタメンテナンス
{
    class SubmitClass
    {
        string strSQL; //SQL発行用

        //////////////////////////////////////////////////
        //ログインID 登録(INSERT)処理                   //
        //////////////////////////////////////////////////
        public string Submit_Main(string strMode, string strHumanNo, string strLoginID, string strPassword, string strHumanName, int intAdminFLG){

            if (strMode == "登録"){
                //登録モードの場合
                //SQL発行
                strSQL = "";
                strSQL += "INSERT INTO HUMAN_MS VALUES ";
                strSQL += "( ";
                strSQL += " " + strHumanNo + ", "; //社員NO
                strSQL += " '" + strLoginID + "', "; //名前
                strSQL += " '" + strPassword + "', "; //パスワード
                strSQL += " '" + strHumanName + "', "; //更新担当者名
                strSQL += " " + intAdminFLG + ", "; //管理者フラグ
                strSQL += " SYSDATETIME(), "; //更新日
                strSQL += " SYSDATETIME() "; //登録日
                strSQL += ") ";
                //strSQLを返す
                return strSQL;

            }else{
                //更新モードの場合
                //SQL発行
                strSQL = "UPDATE HUMAN_MS ";
                strSQL += "SET ";
                strSQL += " 名前 = '" + strLoginID + "', ";
                strSQL += " パスワード  = '" + strPassword + "', ";
                strSQL += " 更新担当者名 = '" + strHumanName + "', ";
                strSQL += " 管理者フラグ = " + intAdminFLG + ", ";
                strSQL += " 更新日 = SYSDATETIME() ";
                strSQL += "WHERE ";
                strSQL += " 社員NO = 1 ";
                //strSQLを返す
                return strSQL;

            }
            

        }


    }
}

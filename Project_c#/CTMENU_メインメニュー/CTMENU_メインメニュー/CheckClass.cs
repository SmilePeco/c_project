using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CTMENU_メインメニュー
{
    class CheckClass
    {

        public string strSQL;

        //////////////////////////////////////////////////
        //ログインID 存在チェック処理                   //
        //////////////////////////////////////////////////
        public Boolean Check_HumanNo(string strHumanNo, string strPassword)
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
            strSQL += "    名前 = '" + strHumanNo +"' ";
            strSQL += "AND パスワード = '" + strPassword + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
            if (dtReader.HasRows){
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }else{
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;

            }

        }

        //////////////////////////////////////////////////
        //パスワードチェック                            //
        //////////////////////////////////////////////////
        public Boolean Check_Password(string strHumanNo, string strPassword)
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
            strSQL += "    名前 = '" + strHumanNo + "' ";
            strSQL += "AND パスワード = '" + strPassword + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }else{
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }

        }

        //////////////////////////////////////////////////
        //管理者フラグ 取得                            //
        //////////////////////////////////////////////////
        public string Get_AdminFLG(string strHumanNo, string strPassword){
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            string strReturnValue = "0";
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 管理者フラグ ";
            strSQL += "FROM ";
            strSQL += " HUMAN_MS ";
            strSQL += "WHERE ";
            strSQL += "    名前 = '" + strHumanNo + "' ";
            strSQL += "AND パスワード = '" + strPassword + "' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
            if (dtReader.HasRows){
                while (dtReader.Read()) { strReturnValue = dtReader["管理者フラグ"].ToString(); }
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturnValue;
            }else{
                //ありえないが、０を返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                strReturnValue = "0";
                return strReturnValue;
            }
        }



    }
}

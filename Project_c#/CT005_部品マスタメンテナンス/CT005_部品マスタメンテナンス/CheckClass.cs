using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CT005_部品マスタメンテナンス
{
    class CheckClass
    {

        public string strSQL;


        ///////////////////////////////////////////////////
        //部品コード チェック処理                       //
        //////////////////////////////////////////////////
        public Boolean Check_PartsCode(string strPartsCode){

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
            strSQL += " 部品コード = '" + strPartsCode +"' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                //存在した場合はエラー、FALSE返す
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }else{
                //存在しない場合は問題なし、TRUE返す
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;
            }

        }



        ///////////////////////////////////////////////////
        //部品分類NO チェック処理                       //
        //////////////////////////////////////////////////
        public Boolean Check_PartsClass(string strPartsClass)
        {
            //変数定義
            SqlCommand cd = null;
            SqlDataReader dtReader;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 部品分類NO ";
            strSQL += "FROM ";
            strSQL += " PARTS_CLASS_MS ";
            strSQL += "WHERE ";
            strSQL += " 部品分類NO = " + strPartsClass +" ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows)
            {
                //存在した場合は問題なし、TRUE返す
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;
            }
            else
            {
                //存在しない場合は問題なし、TRUE返す
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }
                       

        }

        ///////////////////////////////////////////////////
        //更新担当者 チェック処理                       //
        //////////////////////////////////////////////////
        public Boolean Check_HumanMS(string strHumanMS)
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
            strSQL += " 名前 = '" + strHumanMS + " ' ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                //存在する場合は問題なし
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;


            }else{
                //存在しない場合はエラー
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;


            }

            


        }


    }
}

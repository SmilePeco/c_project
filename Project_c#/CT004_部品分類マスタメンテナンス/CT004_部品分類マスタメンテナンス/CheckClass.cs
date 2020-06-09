using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CT004_部品分類マスタメンテナンス
{
    class CheckClass
    {

        public string strSQL;

        //////////////////////////////////////////////////
        //チェック処理 更新担当者                       //
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
            if (dtReader.HasRows)
            {
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }
            else
            {
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;
            }






        }

    }
}

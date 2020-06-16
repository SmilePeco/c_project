using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CTCommon
{
    public class ValueCheck
    {
        //変数定義
        public string strSQL;

        //////////////////////////////////////////////////
        //更新担当者存在チェック                              //
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
            if (dtReader.HasRows){
                //存在しない場合は、FALSEをかえす
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;

            }else{
                //存在しない場合は、FALSEをかえす
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;

            }

        }

    }
}

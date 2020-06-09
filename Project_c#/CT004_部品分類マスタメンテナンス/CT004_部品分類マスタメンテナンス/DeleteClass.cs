using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CT004_部品分類マスタメンテナンス
{
    class DeleteClass
    {

        public string strSQL;

        //////////////////////////////////////////////////
        //削除前チェック処理                            //
        //////////////////////////////////////////////////
        public Boolean Delete_Check(string strPartsClassNo){
            ////PARTS_MSに部品分類NOが登録されていないか確認する
            ////登録されている場合は、削除不可とする
            //変数定義
            SqlDataReader dtReader;
            SqlCommand cd = null;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 部品分類NO ";
            strSQL += "FROM ";
            strSQL += " PARTS_MS ";
            strSQL += "WHERE ";
            strSQL += " 部品分類NO = " + strPartsClassNo + " ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                ////存在した場合はエラー
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return false;

            }else{
                ////存在しない場合は問題なし
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;
            }
        }

        //////////////////////////////////////////////////
        //削除用SQL発行                                 //
        //////////////////////////////////////////////////
        public string Delete_Main(string strPartsClassNo)
        {
            //SQL発行
            strSQL = "";
            strSQL += "DELETE FROM PARTS_CLASS_MS ";
            strSQL += "WHERE 部品分類NO = " + strPartsClassNo +" ";
            //SQLを返す
            return strSQL;

        }

    }
}

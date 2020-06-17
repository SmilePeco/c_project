using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT011_部品本登録画面
{
    class DeleteClass
    {
        string strSQL;

        //////////////////////////////////////////////////
        //部品登録テーブル 削除SQL発行処理              //
        //////////////////////////////////////////////////
        public string Delete_PartsMS(string strPartsNo){
            //SQL発行
            strSQL = "";
            strSQL += "DELETE FROM PARTS_TBL ";
            strSQL += "WHERE 部品登録NO = " + strPartsNo + " ";
            //SQLをかえす
            return strSQL;

        }



        //////////////////////////////////////////////////
        //部品登録履歴テーブル 削除SQL発行処理          //
        //////////////////////////////////////////////////
        public string Delete_PartsHistoryMS(string strPartsNo){
            //SQL発行
            strSQL = "";
            strSQL += "DELETE FROM PARTS_HISTORY_TBL ";
            strSQL += "WHERE 部品登録NO = " + strPartsNo + " ";
            //SQLをかえす
            return strSQL;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT011_部品本登録画面
{
    class SubmitClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //部品登録テーブル 登録SQL発行処理              //
        //////////////////////////////////////////////////
        public string Submit_PartsTBL(string strPartsNo, string strHumanNo){
            //SQL発行
            strSQL = "";
            strSQL += "UPDATE PARTS_TBL ";
            strSQL += "SET ";
            strSQL += " 登録済フラグ = 1, ";
            strSQL += " 最終更新者 = '" + strHumanNo + "', ";
            strSQL += " 更新日 = SYSDATETIME() ";
            strSQL += "WHERE ";
            strSQL += " 部品登録NO = " + strPartsNo + " ";
            //SQLをかえす
            return strSQL;
        }


        //////////////////////////////////////////////////
        //部品登録履歴テーブル 登録SQL発行処理          //
        //////////////////////////////////////////////////
        public string Submit_PartsHistoryTBL(string strPartsNo, string strHumanNo)
        {
            //SQL発行
            strSQL = "";
            strSQL += "UPDATE PARTS_HISTORY_TBL ";
            strSQL += "SET ";
            strSQL += " 登録済フラグ = 1, ";
            strSQL += " 本登録者 = '" + strHumanNo + "', ";
            strSQL += " 更新日 = SYSDATETIME() ";
            strSQL += "WHERE ";
            strSQL += " 部品登録NO = " + strPartsNo + " ";
            //SQLをかえす
            return strSQL;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT010_部品仮登録画面
{
    class SubmitClass
    {

        public string strSQL;

        //////////////////////////////////////////////////
        //PartsTBL 登録SQL生成                              //
        //////////////////////////////////////////////////
        public string Submit_PartsTBL(string strPartsNo, string strPartsCode, string strPartsNumber, string strHumanNo){
            //SQL発行
            strSQL = "";
            strSQL += "INSERT INTO PARTS_TBL VALUES ";
            strSQL += "( ";
            strSQL += " " + strPartsNo + ", "; //部品登録NO
            strSQL += " '" + strPartsCode +"', "; //部品コード
            strSQL += " " + strPartsNumber + ", "; //登録数
            strSQL += " 0,"; //登録済フラグ
            strSQL += " '" + strHumanNo + "',"; //更新担当者
            strSQL += " SYSDATETIME(), "; //更新日
            strSQL += " SYSDATETIME() "; //登録日
            strSQL += ") ";
            //SQLをかえす
            return strSQL;




        }


        //////////////////////////////////////////////////
        //PartsHistoryTBL 登録SQL生成                   //
        //////////////////////////////////////////////////
        public string Submit_PartsHistoryTBL(string strPartsNo, string strPartsCode, string strPartsNumber, string strHumanNo)
        {
            //SQL発行
            strSQL = "";
            strSQL += "INSERT INTO PARTS_HISTORY_TBL VALUES ";
            strSQL += "( ";
            strSQL += " " + strPartsNo + ", "; //部品登録NO
            strSQL += " '" + strPartsCode + "', "; //部品コード
            strSQL += " " + strPartsNumber + ", "; //登録数
            strSQL += " 0,"; //登録済フラグ
            strSQL += " '" + strHumanNo + "',"; //仮登録者
            strSQL += " '',"; //本登録者
            strSQL += " SYSDATETIME(), "; //更新日
            strSQL += " SYSDATETIME() "; //登録日
            strSQL += ") ";
            //SQLをかえす
            return strSQL;




        }




    }
}

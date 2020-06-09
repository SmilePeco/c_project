using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT004_部品分類マスタメンテナンス
{

    class SubmitClass
    {

        public string strSQL;


        //////////////////////////////////////////////////
        //更新用SQL生成                                 //
        //////////////////////////////////////////////////
        public string Submit_Main(string strCount,string strPartsClassNo, string strPartsClassName, string strHumanNo){

            //登録か更新か判定
            if (strCount == "登録"){
                //「登録」モードの場合
                strSQL = "";
                strSQL += "INSERT INTO PARTS_CLASS_MS VALUES ";
                strSQL += "( ";
                strSQL += " " + strPartsClassNo + ", "; //部品分類NO
                strSQL += " '" + strPartsClassName + "', "; //部品分類名
                strSQL += " '" + strHumanNo + "', "; //最終更新者
                strSQL += " SYSDATETIME(), "; //更新日
                strSQL += " SYSDATETIME() "; //登録日
                strSQL += ") ";
                //SQL文を返す
                return strSQL;

            }else{
                //「更新」モードの場合
                strSQL = "";
                strSQL += "UPDATE PARTS_CLASS_MS ";
                strSQL += "SET ";
                strSQL += " 部品分類名 = '" + strPartsClassName + "', ";
                strSQL += " 最終更新者 = '" + strHumanNo + "', ";
                strSQL += " 更新日 = SYSDATETIME() ";
                strSQL += "WHERE ";
                strSQL += " 部品分類NO = " + strPartsClassNo + " ";
                //SQL文を返す
                return strSQL;

            }

        }


    }
}

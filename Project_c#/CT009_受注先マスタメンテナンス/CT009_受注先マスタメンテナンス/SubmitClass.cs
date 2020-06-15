using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT009_受注先マスタメンテナンス
{
    class SubmitClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //更新 SQL生成処理                              //
        //////////////////////////////////////////////////
        public string Submit_Main(string strMode, string strOrderNo, string strOrderName, string strOrderParson, string strOrderTELL, string strOrderAdress1, string strOrderAdress2){

            if (strMode == "更新")
            {
                //更新モードの場合
                strSQL = "";
                strSQL += "UPDATE ORDER_MS ";
                strSQL += "SET ";
                strSQL += " 受注先名 = '" + strOrderName +"', ";
                strSQL += " 受注先担当者名 = '" + strOrderParson +"', ";
                strSQL += " 受注先電話番号 = '" + strOrderTELL +"', ";
                strSQL += " 受注先住所１ = '" + strOrderAdress1 + "', ";
                strSQL += " 受注先住所２ = '" + strOrderAdress2 + "', ";
                strSQL += " 更新日 = SYSDATETIME() ";
                strSQL += "WHERE ";
                strSQL += " 受注先NO = '" + strOrderNo + "' ";
                //SQLをかえす
                return strSQL;


            }else{
                //登録モードの場合
                strSQL = "";
                strSQL += "INSERT INTO ORDER_MS VALUES ";
                strSQL += "( ";
                strSQL += " '" + strOrderNo +"', "; //受注先NO
                strSQL += " '" + strOrderName +"', "; //受注先名
                strSQL += " '" + strOrderParson +"', "; //受注先担当者名
                strSQL += " '" + strOrderTELL +"', "; //受注先電話番号
                strSQL += " '" + strOrderAdress1 +"', "; //受注先住所１
                strSQL += " '" + strOrderAdress2 + "', "; //受注先住所２
                strSQL += " SYSDATETIME(), "; //更新日
                strSQL += " SYSDATETIME() "; //登録日
                strSQL += ") ";
                //SQLをかえす
                return strSQL;


            }

        }



    }
}

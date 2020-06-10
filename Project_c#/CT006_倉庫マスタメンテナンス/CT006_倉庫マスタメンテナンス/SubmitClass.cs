using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT006_倉庫マスタメンテナンス
{
    class SubmitClass
    {

        public string strSQL;

        //////////////////////////////////////////////////
        //SQL発行処理                                   //
        //////////////////////////////////////////////////
        public string Submit_Main(string strMode, string strWarehouseNo, string strWarehouseName, string strHumanNo)
        {
            if (strMode == "更新"){
                //更新モード
                //SQL発行
                strSQL = "";
                strSQL += "UPDATE WAREHOUSE_MS  ";
                strSQL += "SET ";
                strSQL += " 倉庫名 = '" + strWarehouseName +"', ";
                strSQL += " 最終更新者 = '" + strHumanNo + "', ";
                strSQL += " 更新日 = SYSDATETIME() ";
                strSQL += "WHERE ";
                strSQL += " 倉庫NO = " + strWarehouseNo +" ";
                //SQLをかえす
                return strSQL;
            }
            else
            {
                //登録モードの場合
                //SQL発行
                strSQL = "";
                strSQL += "INSERT INTO WAREHOUSE_MS VALUES ";
                strSQL += "( ";
                strSQL += " " + strWarehouseNo + ", ";　//倉庫NO
                strSQL += " '" + strWarehouseName + "', "; //倉庫名
                strSQL += " '" + strHumanNo + "', "; //更新担当者
                strSQL += " SYSDATETIME(), "; //更新日
                strSQL += " SYSDATETIME() ";
                strSQL += ") ";
                //SQLをかえす
                return strSQL;
            }

        }


    }
}

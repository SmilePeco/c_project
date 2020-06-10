using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT006_倉庫マスタメンテナンス
{
    class DeleteClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //SQL発行処理                                   //
        //////////////////////////////////////////////////
        public string Delete_Main(string strWarehouseNo)
        {
            //SQL発行
            strSQL = "";
            strSQL += "DELETE FROM WAREHOUSE_MS ";
            strSQL += "WHERE 倉庫NO = " + strWarehouseNo + " ";
            //SQLをかえす
            return strSQL;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT009_受注先マスタメンテナンス
{
    class DeleteClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //削除 SQL生成処理                              //
        //////////////////////////////////////////////////
        public string Delete_Main(string strOrderNo){
            //SQL発行
            strSQL = "";
            strSQL += "DELETE FROM ORDER_MS ";
            strSQL += "WHERE 受注先NO = '" + strOrderNo + "' ";
            //SQLをかえす
            return strSQL;

        }


    }
}

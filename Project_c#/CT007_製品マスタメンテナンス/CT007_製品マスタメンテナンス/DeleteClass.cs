using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT007_製品マスタメンテナンス
{
    class DeleteClass
    {
        public string strSQL;

        public string Delete_Main(string strCount, string strProductCode){
            //strCount=1：Product_MS
            //strCount=2：Product_History_MS
            //SQL発行
            if (strCount == "1"){
                //Product_MS削除SQL
                strSQL = "";
                strSQL += "DELETE FROM PRODUCT_MS ";
                strSQL += "WHERE 製品コード = '" + strProductCode +"' ";
                //SQLをかえす
                return strSQL;
            }else{
                //Product_History_MS削除SQL
                strSQL = "";
                strSQL += "DELETE FROM PRODUCT_HISTORY_MS ";
                strSQL += "WHERE 製品コード = '" + strProductCode + "' ";
                //SQLをかえす
                return strSQL;
            }


        }

    }
}

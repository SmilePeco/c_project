using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT005_部品マスタメンテナンス
{
    class DeleteClass
    {

        public string strSQL;

        ///////////////////////////////////////////////////
        //部品マスタ 削除SQL発行                        //
        //////////////////////////////////////////////////
        public string Delete_PartsMS(string strPartsCode){
            //SQL発行
            strSQL = "";
            strSQL += "DELETE FROM PARTS_MS ";
            strSQL += "WHERE 部品コード = '" + strPartsCode + "' ";
            //SQLを返す
            return strSQL;
        }


        ///////////////////////////////////////////////////
        //部品履歴マスタ 削除SQL発行                    //
        //////////////////////////////////////////////////
        public string Delete_PartsHistoryMS(string strPartsCode)
        {
            //SQL発行
            strSQL = "";
            strSQL += "DELETE FROM PARTS_HISTORY_MS ";
            strSQL += "WHERE 部品コード = '" + strPartsCode + "' ";
            //SQLを返す
            return strSQL;
        }

    }
}

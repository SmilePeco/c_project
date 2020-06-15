using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT008_作業ラインマスタメンテナンス
{
    class DeleteClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //削除メイン処理                                //
        //////////////////////////////////////////////////
        public string Delete_Main(string strWorklineNo)
        {
            //SQL発行
            strSQL = "";
            strSQL += "DELETE FROM WORKLINE_MS ";
            strSQL += "WHERE 作業ラインNO = '" + strWorklineNo + "' ";
            //SQLをかえす
            return strSQL;
        }
    }
}

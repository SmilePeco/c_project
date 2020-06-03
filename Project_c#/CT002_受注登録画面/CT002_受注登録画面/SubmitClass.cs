using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT002_受注登録画面
{
    //登録、削除時に呼び出されるクラス
    //このクラスで/SQLを生成し、元のフォームに返す
    class SubmitClass{

        public string Submit_Main(int intCount, string strOrderNo){
            //変数定義
            string strSQL;

            //intCount = 1：UPDATE
            //intCount = 2：DELETE
            if (intCount == 1){
                //登録の場合
                strSQL = "";
                strSQL += "UPDATE ORDER_TBL ";
                strSQL += "SET  受注チェックフラグ = 1,";
                strSQL += "     更新日 = SYSDATETIME() ";
                strSQL += "WHERE 受注NO = " + strOrderNo + " ";
                //作成したSQLを返す
                return strSQL;

            }else{
                //削除の場合
                strSQL = "";
                strSQL += "DELETE FROM ORDER_TBL ";
                strSQL += "WHERE 受注NO = " + strOrderNo + " ";
                //作成したSQLを返す
                return strSQL;


            }
            
        }

    }
}

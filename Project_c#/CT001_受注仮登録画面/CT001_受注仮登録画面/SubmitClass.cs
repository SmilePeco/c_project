using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CT001_受注仮登録画面
{
    class SubmitClass
    {

        //////////////////////////////////////////////////
        //登録処理                                      //
        //////////////////////////////////////////////////
        public string Submit_Main(string strOrderNo, string strOrderMSNo,string strProductCode, string strWorklineNo, string strOrderNumber, string strOrderUnitPrice, string strOrderPrice, string strHumanNo)
        {
            //変数定義
            string strSQL;

            //DB接続
            CTCommon.DBConnect.DBConect_Main();
            //SQL発行
            strSQL = "";
            strSQL += "INSERT INTO RECEIVE_TBL VALUES ";
            strSQL += " ( ";
            strSQL += " " + strOrderNo + ", "; //受注NO
            strSQL += " '" + strOrderMSNo + "', "; //受注先NO
            strSQL += " '" + strProductCode + "', "; //製品コード
            strSQL += " '" + strWorklineNo + "', "; //作業ラインNO
            strSQL += " " + strOrderNumber + ", "; //受注数
            strSQL += " " + strOrderUnitPrice + ", "; //受注単価
            strSQL += " " + strOrderPrice + ", "; //受注金額
            strSQL += " SYSDATETIME(), "; //受注日
            strSQL += " '" + strHumanNo + "', "; //最終更新者
            strSQL += " 0, "; //受注チェックフラグ
            strSQL += " 0, "; //出荷チェックフラグ
            strSQL += " SYSDATETIME(), "; //更新日
            strSQL += " SYSDATETIME() "; //登録日
            strSQL += " ) ";
            //SQLをかえす
            return strSQL;
                




        }

        //////////////////////////////////////////////////
        //単価計算処理                                  //
        //////////////////////////////////////////////////
        public string Submit_OrderPrice(string strOrderNumber, string strOrderUnitPrice){
            //変数定義

            //受注数、受注単価が空欄だった場合は、０とする
            if (strOrderNumber == "") { strOrderNumber = "0"; }
            if (strOrderUnitPrice == "") { strOrderUnitPrice = "0"; }
            //単価*受注数
            int intOrderPrice = int.Parse(strOrderNumber) * int.Parse(strOrderUnitPrice);
            string strOrderPrice = Convert.ToString(intOrderPrice);
            return strOrderPrice;
            


        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CT002_受注登録画面
{
    //検索ボタン押下時に呼び出される検索クラス
    class SearchClass
    {


        ///////////////////////////////////////////////////
        //検索処理                                      //
        //////////////////////////////////////////////////
        public DataSet Search_Main(int intCount, string strOrder, string dtpFrom, string dtpTo){
            //変数定義
            string strSQL;
            CTCommon.DataGridViewConnect DataGridViewConnect = new CTCommon.DataGridViewConnect();
            //DB接続
            //CTCommon.DBConnect.DBConect_Main();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " A.受注NO, ";
            strSQL += " A.受注先NO, ";
            strSQL += " B.受注先名, ";
            strSQL += " A.受注日, ";
            strSQL += " A.受注数, ";
            strSQL += " A.作業工程NO, ";
            strSQL += " C.作業工程名 ";
            strSQL += "FROM ";
            strSQL += " ORDER_TBL A, ";
            strSQL += " ORDER_MS B, ";
            strSQL += " WORKPROCESS_MS C ";
            strSQL += "WHERE ";
            strSQL += "    A.受注先NO = B.受注先NO ";
            strSQL += "AND A.作業工程NO = C.作業工程NO ";
            strSQL += "AND A.受注チェックフラグ = 0 ";
            //検索条件：受注先NOの場合
            if (intCount == 1){
                strSQL += "AND A.受注先NO = '" + strOrder +"' ";
                strSQL += "AND A.受注日 BETWEEN ";
                strSQL += "    '" + dtpFrom + "' AND '" + dtpTo +"' ";
                                
            //検索条件：受注NOの場合
            }else if (intCount == 2){
                strSQL += "AND A.受注NO = " + strOrder + "　";
            } 

            //SQL実行、DataSetを取得する
            DataSet dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            //DataSetを返す
            return dsDataset;


        }





    }
}

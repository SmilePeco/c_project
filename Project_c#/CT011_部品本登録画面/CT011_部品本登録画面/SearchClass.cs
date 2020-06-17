using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CT011_部品本登録画面
{
    class SearchClass
    {

        public string strSQL;

        //////////////////////////////////////////////////
        //DataSet取得処理                               //
        //////////////////////////////////////////////////
        public DataSet Search_Dataset(string strPartsCode, string strSubmitFrom, string strSubmitTo){
            //変数定義
            DataSet dsDataset = new DataSet();
            CTCommon.DataGridViewConnect DataGridViewConnect = new CTCommon.DataGridViewConnect();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 部品登録NO, ";
            strSQL += " 部品コード, ";
            strSQL += " FORMAT(登録日, 'yyyy/MM/dd') AS 登録日, ";
            strSQL += " 登録数 ";
            strSQL += "FROM ";
            strSQL += " PARTS_TBL ";
            strSQL += "WHERE ";
            strSQL += "    登録済フラグ = 0 ";
            strSQL += "AND 部品コード = '" + strPartsCode + "' ";
            strSQL += "AND 登録日 BETWEEN ";
            strSQL += "    '" + strSubmitFrom + " 00:00:00' AND '" + strSubmitTo + " 23:59:59' ";
            strSQL += "ORDER BY ";
            strSQL += " 部品コード, ";
            strSQL += " 登録日 DESC ";
            //DataSet取得
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            //DataSetをかえす
            return dsDataset;

        }

    }
}

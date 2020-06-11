using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT007_製品マスタメンテナンス
{
    class SubmitClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //SQL生成 製品マスタ更新SQL                     //
        //////////////////////////////////////////////////
        public string Submit_ProductMS(string strMode, string strProductNo, string strProductCode, string strProductName, string str01PartsCode, string str02PartsCode, string str03PartsCode, string strWarehouseNo, string strRemark, string strHumanNo)
        {
            //更新モードか登録モードか判定
            if (strMode == "更新")
            {
                //更新モードの場合
                strSQL = "";
                strSQL += "UPDATE PRODUCT_MS ";
                strSQL += "SET ";
                strSQL += " 製品名 = '" + strProductName + "', ";
                strSQL += " 使用部品コード1 = '" + str01PartsCode + "', ";
                strSQL += " 使用部品コード2 = '" + str02PartsCode + "', ";
                strSQL += " 使用部品コード3 = '" + str03PartsCode + "', ";
                strSQL += " 倉庫NO = '" + strWarehouseNo + "', ";
                strSQL += " 備考 = '" + strRemark + "', ";
                strSQL += " 最終更新者 = '" + strHumanNo + "', ";
                strSQL += " 更新日 = SYSDATETIME() ";
                strSQL += "WHERE ";
                strSQL += " 製品コード = '" + strProductCode + "' ";
                return strSQL;
            }else{
                //登録モードの場合
                strSQL = "";
                strSQL += "INSERT INTO PRODUCT_MS VALUES ";
                strSQL += "( ";
                strSQL += " " + strProductNo + ", "; //製品NO
                strSQL += " '" + strProductCode + "', "; //製品コード
                strSQL += " '" + strProductName + "', "; //製品名
                strSQL += " '" + str01PartsCode + "', "; //部品コード１
                strSQL += " '" + str02PartsCode + "', "; //部品コード２
                strSQL += " '" + str03PartsCode + "', "; //部品コード３
                strSQL += " " + strWarehouseNo + ", "; //倉庫No
                strSQL += " '" + strRemark + "', "; //備考
                strSQL += " '" + strHumanNo + "', "; //更新担当者
                strSQL += " SYSDATETIME(), "; //更新日
                strSQL += " SYSDATETIME() "; //登録日
                strSQL += ") ";

                return strSQL;

            }

        }

        //////////////////////////////////////////////////
        //SQL生成 製品単価履歴マスタ更新SQL             //
        //////////////////////////////////////////////////
        public string Submit_ProductHistoryMS(string strProductCode, string strUpdateMoney, string strHumanNo)
        {
            //SQL発行
            strSQL = "";
            strSQL += "INSERT INTO PRODUCT_HISTORY_MS VALUES ";
            strSQL += "( ";
            strSQL += " '" + strProductCode +"', ";
            strSQL += " SYSDATETIME(), ";
            strSQL += " " + strUpdateMoney +", ";
            strSQL += " '" + strHumanNo +"' ";
            strSQL += ") ";
            //SQLをかえす
            return strSQL;
        }

    }
}

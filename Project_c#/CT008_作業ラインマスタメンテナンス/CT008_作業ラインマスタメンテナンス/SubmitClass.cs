using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CT008_作業ラインマスタメンテナンス
{
    class SubmitClass
    {

        public string strSQL;


        //////////////////////////////////////////////////
        //更新メイン処理                                //
        //////////////////////////////////////////////////

        public string Submit_Main(string strMode, string strWorklineNo, string strWorklineName, string strProcessNo, string strProductCode, string strHumanNo)
        {
            if (strMode == "更新")
            {
                //更新モードの場合
                //SQL発行
                strSQL = "";
                strSQL += "UPDATE WORKLINE_MS ";
                strSQL += "SET ";
                strSQL += " 作業ライン名 = '" + strWorklineName + "', ";
                strSQL += " 工程NO = '" + strProcessNo + "', ";
                strSQL += " 製品コード = '" + strProductCode + "', ";
                strSQL += " 最終更新者 = '" + strHumanNo + "', ";
                strSQL += " 更新日 = SYSDATETIME() ";
                strSQL += "WHERE ";
                strSQL += " 作業ラインNO = '" + strWorklineNo +"' ";
                //SQLをかえす
                return strSQL;


            }else{
                //登録モードの場合
                //SQL発行
                strSQL = "";
                strSQL += "INSERT INTO WORKLINE_MS VALUES ";
                strSQL += "( ";
                strSQL += " '" + strWorklineNo + "', "; //作業ラインNO
                strSQL += "  '" + strWorklineName + "',"; //作業ライン名
                strSQL += " '" + strProcessNo +"', "; //工程NO
                strSQL += " '" + strProductCode +"', "; //製品コード
                strSQL += " '" + strHumanNo +"', "; //最終更新者
                strSQL += " SYSDATETIME(), "; //更新日
                strSQL += " SYSDATETIME() "; //登録日
                strSQL += ") ";
                //SQLをかえす
                return strSQL;
            }


        }

    }
}

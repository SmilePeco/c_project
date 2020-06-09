using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CTMENU_メインメニュー
{
    class SubmitClass
    {
        public string strSQL;
        
        //////////////////////////////////////////////////
        //新パスワード SQL発行                          //
        //////////////////////////////////////////////////
        public String Submit_PassChange(string strHumanNo, string strCurrentPass, string strNewPass)
        {
            //SQL発行
            strSQL = "";
            strSQL += "UPDATE HUMAN_MS ";
            strSQL += "SET ";
            strSQL += " パスワード = '" + strNewPass +"' ";
            strSQL += "WHERE ";
            strSQL += "    名前 = '" + strHumanNo + "' ";
            strSQL += "AND パスワード = '" + strCurrentPass + "' ";
            //SQLを返す
            return strSQL;
        }

    }
}

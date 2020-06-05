using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CT003_社員マスタメンテナンス
{
    class DeleteClass
    {

        public string strSQL;

        public string Delete_Main(string strHumanNo)
        {
            //SQL発行
            strSQL = "";
            strSQL += "DELETE FROM HUMAN_MS ";
            strSQL += "WHERE 社員NO = " + strHumanNo + " ";
            //SQLを返す
            return strSQL;


        }
    }
}

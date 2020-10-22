using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CT012_製品生産画面 {
    class LocalConnect {

        public SqlCommand SqlCommand(String strSQL) {

            SqlCommand cd;

            //【備考】：本番⇔テストの切り替え
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);    　//本番環境
            //cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn_test); //テスト環境

            return cd;

        }

    }
}

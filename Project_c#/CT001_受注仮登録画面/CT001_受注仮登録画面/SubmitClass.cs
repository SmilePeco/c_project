using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CT001_受注登録画面
{
    class SubmitClass
    {

        //////////////////////////////////////////////////
        //登録処理                                      //
        //////////////////////////////////////////////////
        public void Submit_Main(string txtOrderNo, string txtOrderMSNo, string txtWorkProcessMSNo, string txtHumanMSNo, string txtOrderNumber)
        {
            //変数定義
            SqlCommand cd = null;
            string strSQL;

            try
            {
                //DB接続
                CTCommon.DBConnect.DBConect_Main();
                //SQL発行
                strSQL = "";
                strSQL += "INSERT INTO ORDER_TBL VALUES ";
                strSQL += " ( ";
                strSQL += " " + txtOrderNo + ", "; //受注NO
                strSQL += " '" + txtOrderMSNo + "', "; //受注先NO
                strSQL += " '" + txtWorkProcessMSNo + "', "; //作業工程NO
                strSQL += " " + txtOrderNumber + ", "; //受注数
                strSQL += " SYSDATETIME(), "; //受注日
                strSQL += " '" + txtHumanMSNo + "', "; //最終更新者
                strSQL += " 0, "; //受注チェックフラグ
                strSQL += " 0, "; //出荷チェックフラグ
                strSQL += " SYSDATETIME(), "; //更新日
                strSQL += " SYSDATETIME() "; //登録日
                strSQL += " ) ";
                //SQL実行
                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                CTCommon.DBConnect.cn.Open();
                cd.ExecuteNonQuery();
                MessageBox.Show("登録できました。", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                


            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                //後処理
                //クローズ処理
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
            }



            

        }


    }
}

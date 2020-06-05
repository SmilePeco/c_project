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
    class CheckClass
    {
        public string strSQL;

        //////////////////////////////////////////////////
        //チェックメイン処理                            //
        //////////////////////////////////////////////////
        public Boolean Check_Main(string strMode, string strHumanNo, string strLoginID, string strPassword, string strHumanName)
        {

            //ログインID、パスワード、更新担当者名チェック
            //未入力の場合はエラー
            if (strLoginID == "") { MessageBox.Show("ログインIDが未入力です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (strPassword == "") { MessageBox.Show("パスワードが未入力です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (strHumanName == "") { MessageBox.Show("更新担当者名が未入力です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            
            //問題なければ,TRUEを返す
            return true;
                
         }
        
        //////////////////////////////////////////////////
        //社員Noチェック処理                            //
        //////////////////////////////////////////////////
        public Boolean Check_HumanNo(string strHumanNo){

            //変数定義
            CTCommon.DataGridViewConnect DataGridViewConnect = new CTCommon.DataGridViewConnect();
            SqlDataReader dtReader;
            SqlCommand cd = null;

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 社員NO ";
            strSQL += "FROM ";
            strSQL += " HUMAN_MS ";
            strSQL += "WHERE ";
            strSQL += " 社員NO = " + strHumanNo  +" ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReaderの読込
            //存在した場合はエラー
            if (dtReader.HasRows){
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                //メッセージ表示
                MessageBox.Show("入力した社員Noは既に存在しています。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }else{
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return true;
            }

        }



    }



}

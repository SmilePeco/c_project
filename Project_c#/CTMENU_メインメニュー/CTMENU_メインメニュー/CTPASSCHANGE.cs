using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CTMENU_メインメニュー
{
    public partial class CTPASSCHANGE : Form
    {

        public string strSQL;
        public string strPublicHumanNo;
        public string strReciveValue;



        public CTPASSCHANGE()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////
        //ボタン押下処理                                //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(this.btnChange)) { PassChange_Main(); } //変更ボタン押下
            if (sender.Equals(this.btnCancel)) { this.Close(); } //キャンセルボタン押下

            

        }

        //////////////////////////////////////////////////
        //パスワード変更メイン処理                      //
        //////////////////////////////////////////////////
        private void PassChange_Main()
        {
            //変数定義
            SubmitClass SubmitClass = new SubmitClass();
            SqlCommand cd = null;

            //変更前チェック
            if (true == Check_Main()){
                //変更処理開始
                try {
                    //変更用SQLを生成
                    strSQL = SubmitClass.Submit_PassChange(strPublicHumanNo, txtCurrentPass.Text.Trim(), txtNewPass.Text.Trim());
                    //変更処理
                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                    CTCommon.DBConnect.cn.Open();
                    cd.ExecuteNonQuery();
                    //変更完了
                    MessageBox.Show("変更完了しました。 \r\n新パスワードでログインしてください。", "変更完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }catch (Exception e){
                    MessageBox.Show(e.Message);
                }finally{
                    //クローズ処理
                    CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                }


            }

        }



        //////////////////////////////////////////////////
        //変更前チェック処理                            //
        //////////////////////////////////////////////////
        private Boolean Check_Main()
        {
            //変数定義
            CheckClass CheckClass = new CheckClass();
            
            //現在のパスワードが合っているか確認
            if (false == CheckClass.Check_Password(strPublicHumanNo, txtCurrentPass.Text.Trim())) { MessageBox.Show("入力した現パスワードが正しくありません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //新パスワードが空欄でないか確認する
            if (txtNewPass.Text.Trim() == "") { MessageBox.Show("新パスワードが空白です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //新しいパスワードの両方に差異が無いか確認する
            if (txtNewPass.Text.Trim() != txtNewPass2.Text.Trim()) { MessageBox.Show("新パスワードに差異があります。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //問題なければ、TRUEを返す
            return true;

        }






        //////////////////////////////////////////////////
        //値取得用フォーマット                          //
        //////////////////////////////////////////////////
        public string Showminiform(string strHumanNo)
        {
            //変数定義
            CTPASSCHANGE frmSearch = new CTPASSCHANGE();
            frmSearch.strPublicHumanNo = strHumanNo;
            frmSearch.ShowDialog();
            frmSearch.strReciveValue = txtNewPass.Text.Trim();
            return strReciveValue;

        }




    }
}

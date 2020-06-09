using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTMENU_メインメニュー
{
    public partial class CTLOGIN : Form
    {
        public CTLOGIN()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////////////
        //ボタン押下処理                                //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(this.btnLogin)) { smLogin(); } //ログインボタン
            if (sender.Equals(this.btnPasswordChange)) { smPassChange(); } //パスワード変更ボタン


        }


        //////////////////////////////////////////////////
        //ログイン ボタン処理                           //
        //////////////////////////////////////////////////
        private void smLogin()
        {
            //変数定義
            CheckClass CheckClass = new CheckClass();
            string strReciveValue;
            //ログインチェック
            if (true == CheckClass.Check_HumanNo(txtHumanNo.Text.Trim(), txtPassword.Text.Trim())){
                //変数定義
                CTMENU frmMain = new CTMENU();
                //管理者フラグを取得
                strReciveValue = CheckClass.Get_AdminFLG(txtHumanNo.Text.Trim(), txtPassword.Text.Trim());
                //メインメニュー表示
                frmMain.Showminiform(strReciveValue);
                frmMain.Dispose();

            }


        }

        //////////////////////////////////////////////////
        //パスワード変更ボタン処理                      //
        //////////////////////////////////////////////////
        private void smPassChange()
        {
            //変数定義
            CheckClass CheckClass = new CheckClass();

            //パスワード変更前にログインIDのチェック
            if (true == CheckClass.Check_HumanNo(txtHumanNo.Text.Trim(), txtPassword.Text.Trim()))
            {
                //変数定義
                CTPASSCHANGE CTPASSCHANGE = new CTPASSCHANGE();
                //ログインIDを準備
                string strReciveValue = txtHumanNo.Text.Trim();
                CTPASSCHANGE.Showminiform(strReciveValue);
                CTPASSCHANGE.Dispose();

            }
            else { MessageBox.Show("ログインIDかパスワードが誤っています。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);  }

        }



    }
}

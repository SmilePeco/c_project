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

namespace CT004_部品分類マスタメンテナンス
{
    public partial class CT004 : Form
    {
        public CT004()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////
        //Load処理                                    //
        //////////////////////////////////////////////////
        private void CT004_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();

        }

        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CT004_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    //検索処理
                    Search_Main();
                    break;
                case Keys.F2:
                    //更新処理
                    if (btnSubmit.Enabled == true) { Submit_Main(); }
                    break;
                case Keys.F3:
                    if (btnDelete.Enabled == true) { Delete_Main(); }
                    break;
                case Keys.F4:
                    smClear();
                    break;
                case Keys.F5:
                    this.Close();
                    break;

            }

        }


        //////////////////////////////////////////////////
        //ボタン押下処理                                //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e)
        {
            //変数定義
            string strReciveValue;
            CTCommon.CTHumanMSSearch frmSearch = new CTCommon.CTHumanMSSearch();

            if (sender.Equals(this.btnSerach)) { Search_Main(); } //検索処理
            if (sender.Equals(this.btnSubmit)) { Submit_Main(); } //更新処理
            if (sender.Equals(this.btnDelete)) { Delete_Main(); } //削除処理
            if (sender.Equals(this.btnClear)) { smClear(); } //クリア処理
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了処理

            //更新担当者ボタンが押下された場合
            if (sender.Equals(this.btnHumanMSSearch)){
                //ログインIDを取得する
                strReciveValue = frmSearch.ShowminiForm();
                txtHumanMSNo.Text = strReciveValue;

            }

        }

        //////////////////////////////////////////////////
        //テキストボックス KeyPress処理                 //
        //////////////////////////////////////////////////
        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //部品分類NOでキー操作した場合
            if (sender.Equals(this.txtHumanMSNo)){
                if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b') { e.Handled = true; }　//数値とバックスペース以外入力禁止
            }


        }


        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main()
        {
            //変数定義
            SearchClass frmSearch = new SearchClass();
            int intCount; //連番

            //空白以外の場合は、DBから検索
            //空白の場合は、新規登録、連番からNOを取得する
            if (txtPartsClassNo.Text.Trim() != "")
            {
                //空白以外の場合
                //入力した部品分類NOのチェック
                if (true == frmSearch.Search_PartsClassNO(txtPartsClassNo.Text.Trim()))
                {
                    //存在した場合
                    //表示設定
                    groupBox3.Enabled = true;
                    txtPartsClassNo.Enabled = false;
                    btnSubmit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSerach.Enabled = false;
                    lblMode.Text = "更新";
                    txtPartsClassName.Text = frmSearch.Search_PartsClassName(txtPartsClassNo.Text.Trim()); //部品分類名の設定

                    

                }else{
                    //存在しなかった場合はエラー
                    MessageBox.Show("入力した部品分類NOは存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }else{
                //空白の場合
                //連番を取得する
                intCount = frmSearch.Search_PartsClassNOMAX();
                //部品分類NOに連番を設定
                txtPartsClassNo.Text = Convert.ToString(intCount);
                //表示設定
                groupBox3.Enabled = true;
                txtPartsClassNo.Enabled = false;
                btnSubmit.Enabled = true;
                btnDelete.Enabled = true;
                btnSerach.Enabled = false;
                lblMode.Text = "登録";

            }

        }


        //////////////////////////////////////////////////
        //更新チェック処理                                //
        //////////////////////////////////////////////////
        private Boolean Submit_Check()
        {
            //変数定義
            CheckClass frmCheck = new CheckClass();

            //部品分類名チェック
            if (txtPartsClassName.Text.Trim() == ""){
                //空白の場合はエラー
                MessageBox.Show("部品分類名が未入力です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //更新担当者チェック
            if (false == frmCheck.Check_HumanNo(txtHumanMSNo.Text.Trim())) { MessageBox.Show("入力した更新担当者が存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return false; }

            //問題なければ、TRUEを返す
            return true;
        }

        //////////////////////////////////////////////////
        //更新メイン処理                                //
        //////////////////////////////////////////////////
        private void Submit_Main()
        {
            //変数定義
            SubmitClass frmSubmit = new SubmitClass();
            SqlCommand cd = null;
            string strSQL;

            if (MessageBox.Show("更新しますか？", "更新確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try
                {
                    //チェック処理
                    if (true == Submit_Check())
                    {
                        //更新処理
                        strSQL = frmSubmit.Submit_Main(lblMode.Text, txtPartsClassNo.Text.Trim(), txtPartsClassName.Text.Trim(), txtHumanMSNo.Text.Trim());
                        //SQL実行
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        CTCommon.DBConnect.cn.Open();
                        cd.ExecuteNonQuery();
                        //メッセージ表示
                        MessageBox.Show("更新完了いたしました。", "更新完了",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        //クローズ処理
                        CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                        //クリア処理
                        smClear();


                    }


                }catch (Exception e){
                    MessageBox.Show(e.Message);

                }finally{
                    //クローズ処理
                    CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);

                }


            }



        }


        //////////////////////////////////////////////////
        //削除メイン処理                                //
        //////////////////////////////////////////////////
        private void Delete_Main()
        {
            //変数定義
            DeleteClass DeleteClass = new DeleteClass();
            SqlCommand cd;


            //削除確認メッセージ
            if (MessageBox.Show("削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                //削除前チェック
                if (true == DeleteClass.Delete_Check(txtPartsClassNo.Text.Trim()))
                {

                    try
                    {
                        //SQL発行
                        string strSQL = DeleteClass.Delete_Main(txtPartsClassNo.Text.Trim());
                        //SQL実行
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        CTCommon.DBConnect.cn.Open();
                        cd.ExecuteNonQuery();
                        //完了処理
                        MessageBox.Show("削除完了いたしました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        smClear();
                    }
                    catch (Exception e)
                    {
                        
                        MessageBox.Show(e.Message);
                    }
                    finally
                    {
                        //クローズ処理
                        CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                    }


                    


                }
                else { MessageBox.Show("部品マスタに部品分類[" + txtPartsClassNo.Text + "]を使用している部品コードが存在するため、 \r\n削除できません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }




        }


        //////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        private void smClear(){
            //テキストボックスの初期化
            txtPartsClassNo.Clear();
            txtPartsClassName.Clear();
            txtHumanMSNo.Clear();
            txtPartsClassNo.Enabled = true;
            //ラベルの初期化
            lblMode.Text = "";
            //GroupBoxの初期化
            groupBox3.Enabled = false;
            //ボタンの初期化
            btnSubmit.Enabled = false;
            btnDelete.Enabled = false;
            btnSerach.Enabled = true;



        }








    }
}

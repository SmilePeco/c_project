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

namespace CT010_部品仮登録画面
{
    public partial class CT010 : Form
    {
        public CT010()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CT010_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();

        }

        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CT010_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode){
                case Keys.F1:
                    //検索処理
                    Search_Main();
                    break;

                case Keys.F2:
                    //更新処理
                    if (btnSubmit.Enabled == true) { Submit_Main(); }
                    break;


                case Keys.F3:
                    //クリア処理
                    smClear();
                    break;

                case Keys.F4:
                    //終了処理
                    this.Close();
                    break;

            }

        }

        //////////////////////////////////////////////////
        //ボタンクリック処理                            //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e)
        {

            if (sender.Equals(this.btnSearch)) { Search_Main(); } //検索ボタン押下
            if (sender.Equals(this.btnSubmit)) { Submit_Main(); } //更新ボタン押下
            if (sender.Equals(this.btnClear)) { smClear(); } //クリア処理
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了処理

            //部品検索ボタン押下処理
            if (sender.Equals(this.btnPartsMSSearch)){
                //変数定義
                CTCommon.CTPartsMSSearch frmSearch = new CTCommon.CTPartsMSSearch();
                CTCommon.NameSubmit NameSubmit = new CTCommon.NameSubmit();
                txtPartsCode.Text = frmSearch.Showminiform();
                //部品名取得
                lblPartsName.Text = NameSubmit.PartsName_Submit(txtPartsCode.Text);
            }

            //更新担当者検索ボタン押下
            if (sender.Equals(this.btnHumanMSSearch)){
                //変数定義
                CTCommon.CTHumanMSSearch frmSearch = new CTCommon.CTHumanMSSearch();
                txtHumanMSNo.Text = frmSearch.ShowminiForm();

            }

        }

        //////////////////////////////////////////////////
        //テキスト 数値のみ入力                         //
        //////////////////////////////////////////////////
        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {

            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }


        }

        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main()
        {
            //変数定義
            CheckClass CheckClass = new CheckClass();

            //チェック処理
            if (true == CheckClass.Check_PartsCode(txtPartsCode.Text.Trim())){
                //見つかった場合
                //部品登録NOを取得
                txtPartsNo.Text = CheckClass.Check_PartsNoMAX();
                //表示設定
                txtPartsCode.Enabled = false;
                btnPartsMSSearch.Enabled = false;
                groupBox3.Enabled = true;
                btnSubmit.Enabled = true;

            }else{
                //見つからなかった場合
                MessageBox.Show("入力した部品コードが存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }


        }

        //////////////////////////////////////////////////
        //登録チェック処理                              //
        //////////////////////////////////////////////////
        private Boolean Submit_Check(){

            //変数定義
            CTCommon.ValueCheck ValueCheck = new CTCommon.ValueCheck();

            //登録数入力確認
            if (txtPartsNumber.Text.Trim() == "") { MessageBox.Show("登録数が入力されていません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; } 
            //更新担当者確認
            if (false == ValueCheck.Check_HumanMS(txtHumanMSNo.Text.Trim())) { MessageBox.Show("入力した担当者は存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //問題なければ、TRUEをかえす
            return true;
        }

        //////////////////////////////////////////////////
        //登録メイン処理                                //
        //////////////////////////////////////////////////
        private void Submit_Main(){

            //変数定義
            SqlTransaction tran = null;
            SqlCommand cd = null;
            string strSQL;
            SubmitClass SubmitClass = new SubmitClass();
            //登録確認メッセージ
            if (MessageBox.Show("登録しますか？", "登録確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                //チェック処理
                if (true == Submit_Check()){
                    try{
                        //トランザクション開始
                        CTCommon.DBConnect.cn.Open();
                        tran = CTCommon.DBConnect.cn.BeginTransaction();
                        //TABLE_TBL：SQL発行
                        strSQL = SubmitClass.Submit_PartsTBL(txtPartsNo.Text.Trim(), txtPartsCode.Text.Trim(), txtPartsNumber.Text.Trim(), txtHumanMSNo.Text.Trim());
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        cd.Transaction = tran;
                        cd.ExecuteNonQuery();
                        //TABLE_HISTORY_TBK：SQL発行
                        strSQL = SubmitClass.Submit_PartsHistoryTBL(txtPartsNo.Text.Trim(), txtPartsCode.Text.Trim(), txtPartsNumber.Text.Trim(), txtHumanMSNo.Text.Trim());
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        cd.Transaction = tran;
                        cd.ExecuteNonQuery();
                        //登録完了
                        MessageBox.Show("登録完了しました。", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        tran.Commit();
                        smClear();

                    }catch (Exception e){
                        tran.Rollback();
                        MessageBox.Show(e.Message);
                    }finally{
                        //クローズ処理
                        CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                    }
                    
                }

            }


        }



        //////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        private void smClear(){
            //テキストボックス初期化
            txtPartsCode.Clear();
            txtPartsNo.Clear();
            txtPartsNumber.Clear();
            txtPartsNo.Enabled = false;
            txtPartsCode.Enabled = true;
            txtHumanMSNo.Clear();
            //ラベル初期化
            lblPartsName.Text = "";
            //ボタン初期化
            btnPartsMSSearch.Enabled = true;
            btnSubmit.Enabled = false;
            //GroupBox初期化
            groupBox3.Enabled = false;




        }









    }
}

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

namespace CT003_社員マスタメンテナンス
{
    public partial class CT003 : Form
    {
        public CT003()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CT003_Load(object sender, EventArgs e){
            //クリア処理
            smClear();
        }


        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CT003_KeyDown(object sender, KeyEventArgs e){

            switch (e.KeyCode){
                case Keys.F1:
                    Search_Main(); //検索処理
                    break;
                case Keys.F2:
                    if (btnUpdate.Enabled == true) { Submit_Main(); } //更新処理
                    break;
                case Keys.F3:
                    if (btnDelete.Enabled == true) { Delete_Main(); } //削除処理
                    break;
                case Keys.F4:
                    smClear(); //クリア処理
                    break;
                case Keys.F5:
                    this.Close();
                    break;
            }

        }


        //////////////////////////////////////////////////
        //ボタン Click処理                              //
        //////////////////////////////////////////////////
        private void button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(this.btnSearch)) { Search_Main(); } //検索ボタン押下処理
            if (sender.Equals(this.btnUpdate)) { Submit_Main(); } //更新ボタン押下処理
            if (sender.Equals(this.btnDelete)) { Delete_Main(); } //削除ボタン押下処理
            if (sender.Equals(this.btnClear)) { smClear(); } //クリアボタン押下処理
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了ボタン押下処理

        }

        //////////////////////////////////////////////////
        //テキストボックス KeyPress処理        //
        //////////////////////////////////////////////////
        private void text_KeyPress(object sender, KeyPressEventArgs e){

            //社員NOでキー操作した場合
            if (sender.Equals(this.txtLoginID)){
                if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b') { e.Handled = true; }　//数値とバックスペース以外入力禁止
            }

            //ログインIDでエンターキーを押下した場合
            if (sender.Equals(this.txtSearchLoginID)){
                if (e.KeyChar == (char)Keys.Enter){ Search_Main(); } //検索処理
            }
        }

 


        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main()
        {
            //変数定義
            DataSet dsDataset = new DataSet();
            SearchClass frmSearch = new SearchClass();
            int intCount = 0;

            //空白チェック
            //空白以外の場合は更新モード、空白の場合は登録モード
            if (txtSearchLoginID.Text.Trim() != ""){
                //フォーカスを外す
                this.ActiveControl = null;
                //Datasetを取得する
                dsDataset = frmSearch.Search_Main(txtSearchLoginID.Text.Trim());
                //DataSetを確認する
                if (dsDataset != null){
                    //入力値が存在した場合
                    //DBから値の取得
                    txtHumanNo.Text = frmSearch.Search_HumanNo(txtSearchLoginID.Text.Trim()); //社員NO取得
                    txtLoginID.Text = frmSearch.Search_LoginID(txtSearchLoginID.Text.Trim()); //ログインID取得
                    txtHumanName.Text = frmSearch.Search_HumanName(txtSearchLoginID.Text.Trim()); //更新担当者名取得
                    int intAdminFLG = frmSearch.Search_AdminFLG(txtSearchLoginID.Text.Trim()); //管理者フラグ取得
                    if (intAdminFLG == 1) { chkAdminFLG.Checked = true; } else { chkAdminFLG.Checked = false; } //管理者フラグ設定
                    //空白以外は更新モード
                    lblMode.Text = "更新";
                    //使用可・不可設定
                    groupBox3.Enabled = true;  //入力欄を使用可能
                    txtHumanNo.Enabled = false;  //社員NOを使用不可
                    btnUpdate.Enabled = true; //更新ボタンを使用可能
                    btnDelete.Enabled = true; //削除ボタンを使用可能

                }else{
                    //入力値が存在しない場合はエラー
                    MessageBox.Show("入力したログインIDは存在しません。 \r\n確認してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }

            }else{
                //空白の場合は登録モード
                lblMode.Text = "登録";
                //連番取得
                intCount = frmSearch.Search_SerialNumber();
                txtHumanNo.Text = Convert.ToString(intCount); //社員NOに連番設定
                //使用可・不可設定
                groupBox3.Enabled = true;  //入力欄を使用可能
                txtHumanNo.Enabled = false;  //社員NOを使用不可
                btnUpdate.Enabled = true; //更新ボタンを使用可能
                btnDelete.Enabled = true; //削除ボタンを使用可能
            }
        }


        //////////////////////////////////////////////////
        //更新メイン処理                                //
        //////////////////////////////////////////////////
        private void Submit_Main(){
            //変数定義
            CheckClass CLCheck = new CheckClass();
            SubmitClass CLSubmit = new SubmitClass();
            SqlCommand cd = null;
            string strSQL;

            if (MessageBox.Show("更新しますか？", "更新確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                try
                {
                    //チェック処理
                    if (true == CLCheck.Check_Main(lblMode.Text, txtHumanNo.Text.Trim(), txtLoginID.Text.Trim(), txtNewPassword.Text.Trim(), txtHumanName.Text.Trim()))
                    {
                        //登録、更新メイン処理
                        strSQL = CLSubmit.Submit_Main(lblMode.Text, txtHumanNo.Text.Trim(), txtLoginID.Text.Trim(), txtNewPassword.Text.Trim(), txtHumanName.Text.Trim(), Convert.ToInt32(chkAdminFLG.Checked));
                        //SQL実行
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        CTCommon.DBConnect.cn.Open();
                        cd.ExecuteNonQuery();
                        MessageBox.Show("更新完了いたしました。", "更新完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //クローズ処理
                        CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                        //クリア処理
                        smClear();


                    }


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
        }


        //////////////////////////////////////////////////
        //削除メイン処理                                //
        //////////////////////////////////////////////////
        private void Delete_Main(){
            //変数定義
            SqlCommand cd = null;
            string strSQL;
            DeleteClass CLDelete = new DeleteClass();

            //最終確認
            if (MessageBox.Show("社員NO:" + txtHumanNo.Text + "を削除しますか？", "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try
                {
                    //削除処理
                    strSQL = CLDelete.Delete_Main(txtHumanNo.Text);
                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                    CTCommon.DBConnect.cn.Open();
                    cd.ExecuteNonQuery();
                    //削除完了
                    MessageBox.Show("削除完了いたしました。", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //クローズ処理
                    CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                    //クリア処理
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

        }

        //////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        private void smClear()
        {
            //テキストボックスの初期化
            txtSearchLoginID.Clear();
            txtHumanNo.Clear();
            txtLoginID.Clear();
            txtNewPassword.Clear();
            txtHumanName.Clear();
            //チェックボックスの初期化
            chkAdminFLG.Checked = false;
            //ラベルの初期化
            lblMode.Text = "";
            //GroupBoxの初期化
            groupBox3.Enabled = false;
            //ボタンの初期化
            btnSearch.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            //フォーカスの初期値
            txtSearchLoginID.Focus();

        }













    }
}

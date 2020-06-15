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

namespace CT008_作業ラインマスタメンテナンス
{
    public partial class CT008 : Form
    {
        public CT008()
        {
            InitializeComponent();
        }





        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CT008_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();

        }


        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CT008_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    //検索処理
                    Search_Main();
                    break;
                case Keys.F2:
                    //更新処理
                    if (btnSubmit.Enabled == true) { Submit_Main();  }
                    break;
                case Keys.F3:
                    //削除処理
                    if (btnDelete.Enabled == true) { Delete_Main(); }
                    break;
                case Keys.F4:
                    //クリア処理
                    smClear();
                    break;
                case Keys.F5:
                    //削除処理
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
            CTCommon.NameSubmit NameSubmit = new CTCommon.NameSubmit();
            CTCommon.CTProcessMSSearch frmProcess = new CTCommon.CTProcessMSSearch();
            CTCommon.CTProductMSSearch frmProduct = new CTCommon.CTProductMSSearch();
            CTCommon.CTHumanMSSearch frmHuman = new CTCommon.CTHumanMSSearch();

            if (sender.Equals(this.btnSerach)) { Search_Main(); } //検索ボタン押下
            if (sender.Equals(this.btnSubmit)) { Submit_Main(); } //更新ボタン押下
            if (sender.Equals(this.btnDelete)) { Delete_Main(); } //削除ボタン押下
            if (sender.Equals(this.btnClear)) { smClear(); } //クリアボタン押下
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了ボタン押下


            
            //工程NOボタン押下
            if (sender.Equals(this.btnProcessNoSearch))
            {
                string strReciveValue = frmProcess.Showminiform();
                txtProcessNo.Text = strReciveValue;
                //工程名の取得
                string strReciveValue2 = NameSubmit.ProcessName_Submit(txtProcessNo.Text.Trim());
                lblProcessName.Text = strReciveValue2;

            }

            //製品コードボタン押下
            if (sender.Equals(this.btnProductCodeSearch))
            {
                string strReciveValue = frmProduct.Showminiform();
                txtProductCode.Text = strReciveValue;
                //製品名の取得
                string strReciveValue2 = NameSubmit.ProductName_Submit(txtProductCode.Text.Trim());
                lblProductName.Text = strReciveValue2;
            }

            //更新担当者ボタン押下
            if (sender.Equals(this.btnHumanMSSearch))
            {
                string strReciveValue = frmHuman.ShowminiForm();
                txtHumanMSNo.Text = strReciveValue;
            }


        }





        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main(){

            //変数定義
            SearchClass SearchClass = new SearchClass();
            CheckClass CheckClass = new CheckClass();

            //空白以外のときは、０埋め処理
            if (txtWorklineNo.Text.Trim() != ""){
                txtWorklineNo.Text = txtWorklineNo.Text.PadLeft(3, '0');
            }

            //空白以外の場合は、更新モード
            //空白の場合は、登録モード
            if (txtWorklineNo.Text.Trim() != "")
            {
                //入力した作業ラインNOが存在するかチェック
                if (true == SearchClass.Search_Check(txtWorklineNo.Text.Trim()))
                {
                    //値の取得
                    txtWorklineName.Text = SearchClass.Search_WorklineName(txtWorklineNo.Text.Trim()); //作業ライン名
                    txtProcessNo.Text = SearchClass.Search_ProcessNo(txtWorklineNo.Text.Trim()); //工程NO
                    txtProductCode.Text = SearchClass.Search_ProductCode(txtWorklineNo.Text.Trim()); //製造コード
                    //表示設定
                    groupBox3.Enabled = true;
                    btnSubmit.Enabled = true;
                    btnDelete.Enabled = true;
                    txtWorklineNo.Enabled = false;
                    lblMode.Text = "更新";

                }else{
                    //存在した場合はエラー
                    MessageBox.Show("入力した作業ラインNOは既にマスタに存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }else{
                //登録モード
                //作業ラインNOのMAX値取得
                txtWorklineNo.Text = CheckClass.Search_WorkLineNoMAX();
                //表示設定
                groupBox3.Enabled = true;
                btnSubmit.Enabled = true;
                txtWorklineNo.Enabled = false;
                lblMode.Text = "登録";


            }
        }


        //////////////////////////////////////////////////
        //更新チェック処理                              //
        //////////////////////////////////////////////////
        private Boolean Submit_Check()
        {
            //変数定義
            CheckClass CheckClass = new CheckClass();

            //作業ライン名チェック処理
            if (txtWorklineName.Text.Trim() == "") { MessageBox.Show("作業ライン名が空白のため、更新できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            //工程NOチェック処理
            if (false == CheckClass.Check_ProcessNo(txtProcessNo.Text.Trim())) { MessageBox.Show("入力した工程NOは存在しないため、更新できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            //製品コードチェック処理
            if (false == CheckClass.Check_ProductCode(txtProductCode.Text.Trim())) { MessageBox.Show("入力した製品コードは存在しないため、更新できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            //更新担当者チェック処理
            if (false == CheckClass.Check_HumanNo(txtHumanMSNo.Text.Trim())) { MessageBox.Show("入力した更新担当者は存在しないため、更新できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }


            //問題なければ、TRUEをかえす
            return true;

        }

        //////////////////////////////////////////////////
        //更新メイン処理                                //
        //////////////////////////////////////////////////
        private void Submit_Main()
        {
            //変数定義
            SubmitClass SubmitClass = new SubmitClass();
            SqlCommand cd = null;
            //更新確認メッセージ
            if(MessageBox.Show("更新しますか？","更新確認",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes){
                //更新前チェック処理
                if (true == Submit_Check()){
                    try{
                        //SQLの取得
                        string strSQL = SubmitClass.Submit_Main(lblMode.Text, txtWorklineNo.Text.Trim(), txtWorklineName.Text.Trim(), txtProcessNo.Text.Trim(), txtProductCode.Text.Trim(), txtHumanMSNo.Text.Trim());
                        //更新処理
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        CTCommon.DBConnect.cn.Open();
                        cd.ExecuteNonQuery();
                        //更新完了
                        MessageBox.Show("更新完了しました。", "更新完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        smClear();


                    }catch (Exception e){
                        MessageBox.Show(e.Message);

                    }finally{
                        //クローズ処理
                        CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                    }


                }
            }

        }

        //////////////////////////////////////////////////
        //削除メイン処理                                //
        //////////////////////////////////////////////////
        public void Delete_Main()
        {
            //変数定義
            DeleteClass DeleteClass = new DeleteClass();
            SqlCommand cd = null;

            //削除確認メッセージ
            if (MessageBox.Show("削除しますか？", "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                try
                {
                    //SQLを取得
                    string strSQL = DeleteClass.Delete_Main(txtWorklineNo.Text.Trim());
                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                    CTCommon.DBConnect.cn.Open();
                    cd.ExecuteNonQuery();
                    //削除完了
                    MessageBox.Show("削除完了しました。", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        private void smClear() {
            //テキストボックスの初期化
            txtWorklineNo.Clear();
            txtWorklineName.Clear();
            txtProcessNo.Clear();
            txtProductCode.Clear();
            txtHumanMSNo.Clear();
            txtWorklineNo.Enabled = true;
            //ラベルの初期化
            lblMode.Text = "";
            lblProcessName.Text = "";
            lblProductName.Text = "";
            //GroupBoxの初期化
            groupBox3.Enabled = false;
            //ボタンの初期化
            btnSubmit.Enabled = false;
            btnDelete.Enabled = false;

        
        
        
        }






    }
}

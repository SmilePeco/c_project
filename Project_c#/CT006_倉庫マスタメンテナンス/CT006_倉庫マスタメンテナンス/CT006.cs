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

namespace CT006_倉庫マスタメンテナンス
{
    public partial class CT006 : Form
    {
        public CT006()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CT006_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();

        }

        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CT006_KeyDown(object sender, KeyEventArgs e)
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
                    //削除処理
                    if(btnDelete.Enabled == true ) { Delete_Main(); }
                    break;
                case Keys.F4:
                    //クリア処理
                    smClear();
                    break;
                case Keys.F5:
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
            //変数定義
            CTCommon.CTHumanMSSearch frmSearch = new CTCommon.CTHumanMSSearch();

            if (sender.Equals(this.btnSerach)) { Search_Main(); } //検索処理
            if (sender.Equals(this.btnSubmit)) { Submit_Main(); } //更新処理
            if (sender.Equals(this.btnDelete)) { Delete_Main(); } //削除処理
            if (sender.Equals(this.btnClear)) { smClear(); } //クリア処理
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了処理

            //更新担当者ボタン押下処理
            if (sender.Equals(this.btnHumanMSSearch)) {
                string strResuiveValue = frmSearch.ShowminiForm();
                txtHumanMSNo.Text = strResuiveValue;
                frmSearch.Dispose();


            }

        }

        //////////////////////////////////////////////////
        //テキスト 数値のみ入力制御                     //
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
            int intCount = 0; //在庫NO MAX値取得用
            CheckClass CheckClass = new CheckClass();

            //空白以外の場合は更新モード
            //空白の場合は登録モード
            if (txtWarehouseNo.Text.Trim() != "") {
            
                //入力した倉庫NOが存在するかチェック
                if (true == CheckClass.Check_WarehouseNo(txtWarehouseNo.Text.Trim()))
                {
                    //存在した場合は在庫名を取得
                    string strReciveValue = CheckClass.Check_WarehouseName(txtWarehouseNo.Text.Trim());
                    txtWarehouseName.Text = strReciveValue;
                    //表示設定
                    txtWarehouseNo.Enabled = false;
                    groupBox3.Enabled = true;
                    btnSubmit.Enabled = true;
                    btnDelete.Enabled = true;
                    lblMode.Text = "更新";


                }else{
                    //存在しなかった場合はエラー
                    MessageBox.Show("入力した倉庫NOは存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

         
            }
            else
            {
                //登録モード
                //倉庫NOのMAX値+1を取得
                intCount = CheckClass.Check_WarehouseNoMAX();
                txtWarehouseNo.Text = Convert.ToString(intCount);
                //表示設定
                txtWarehouseNo.Enabled = false;
                groupBox3.Enabled = true;
                btnSubmit.Enabled = true;
                lblMode.Text = "登録";


            }

        }

        //////////////////////////////////////////////////
        //更新前チェック処理                            //
        //////////////////////////////////////////////////
        private Boolean Submit_Check(){

            //変数定義
            CheckClass CheckClass = new CheckClass();
            
            //在庫名のチェック
            if (txtWarehouseName.Text.Trim() == "") { MessageBox.Show("倉庫名が空欄です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //更新担当者のチェック
            if (false == CheckClass.Check_HumanNo(txtHumanMSNo.Text.Trim())) { MessageBox.Show("入力した更新担当者が存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //問題なければ、TRUEをかえす
            return true;

        }

        //////////////////////////////////////////////////
        //更新メイン処理                                //
        //////////////////////////////////////////////////
        private void Submit_Main()
        {
            //変数定義
            string strSQL;
            SubmitClass SubmitClass = new SubmitClass();
            SqlCommand cd = null;

            //確認メッセージ
            if (MessageBox.Show("更新しますか？", "更新確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                if (true == Submit_Check()){
                    try{
                        //更新処理
                        strSQL = SubmitClass.Submit_Main(lblMode.Text, txtWarehouseNo.Text.Trim(), txtWarehouseName.Text.Trim(), txtHumanMSNo.Text.Trim());
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        CTCommon.DBConnect.cn.Open();
                        cd.ExecuteNonQuery();
                        //更新完了
                        MessageBox.Show("更新完了しました。", "更新完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //クリア処理
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
        private void Delete_Main()
        {
            //変数定義
            CheckClass CheckClass = new CheckClass();
            DeleteClass DeleteClass = new DeleteClass();
            SqlCommand cd = null;

            //削除確認メッセージ
            if (MessageBox.Show("削除しますか？", "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                //製品マスタで使用していないか確認
                if (true == CheckClass.Check_ProductMS(txtWarehouseNo.Text.Trim())){
                    try{
                        //SQL発行
                        string strSQL = DeleteClass.Delete_Main(txtWarehouseNo.Text.Trim());
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        CTCommon.DBConnect.cn.Open();
                        cd.ExecuteNonQuery();
                        //削除完了
                        MessageBox.Show("削除完了しました。", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        smClear();



                    }catch (Exception e){
                        MessageBox.Show(e.Message);
                    }finally{
                        //クローズ処理
                        CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                    }
                    


                }else{
                    MessageBox.Show("倉庫NO[" + txtWarehouseNo.Text.Trim() + "]は、製品マスタで使用されているため、削除できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
        }

        //////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        private void smClear()
        {
            //テキストボックス初期化
            txtWarehouseNo.Clear();
            txtWarehouseName.Clear();
            txtHumanMSNo.Clear();
            txtWarehouseNo.Enabled = true;
            //ラベル初期化
            lblMode.Text = "";
            //GroupBox初期化
            groupBox3.Enabled = false;
            //ボタン初期化
            btnSubmit.Enabled = false;
            btnDelete.Enabled = false;

        }






    }
}

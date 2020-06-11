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

namespace CT007_製品マスタメンテナンス
{
    public partial class CT007 : Form
    {
        public CT007()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CT007_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();

        }


        //////////////////////////////////////////////////
        //ボタン押下処理                                //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e)
        {
            //変数定義
            CTCommon.CTWarehouseMSSearch frmWarehouse = new CTCommon.CTWarehouseMSSearch();
            CTCommon.CTHumanMSSearch frmHuman = new CTCommon.CTHumanMSSearch();
            CTCommon.CTPartsMSSearch frmParts = new CTCommon.CTPartsMSSearch();
            CTCommon.CTProductMSSearch frmProduct = new CTCommon.CTProductMSSearch();
            CTCommon.NameSubmit NameSubmit = new CTCommon.NameSubmit();


            if (sender.Equals(this.btnSearch)) { Search_Main(); } //検索処理
            if (sender.Equals(this.btnSubmit)) { Submit_Main(); } //更新処理
            if (sender.Equals(this.btnClear)) { smClear(); } //クリア処理

            //製品コード検索ボタン押下
            if (sender.Equals(this.btnSearchProductCodeSearch)){
                string strReciveValue = frmProduct.Showminifrom();
                txtSearchProductCode.Text = strReciveValue;
            }

            //倉庫NO検索ボタン押下
            if (sender.Equals(this.btnWarehouseNoSearch)) {
                string strReciveValue =  frmWarehouse.Showminiform();
                txtWarehouseNo.Text = strReciveValue;
            }

            //部品コード１検索ボタン押下
            if (sender.Equals(this.btn01PartsCodeSearch)){
                string strReciveValue = frmParts.Showminiform();
                txt01PartsCode.Text = strReciveValue;
                //部品名を取得
                string strResiveValue2 = NameSubmit.PartsName_Submit(txt01PartsCode.Text);
                lbl01PartsName.Text = strResiveValue2;

            }

            //部品コード２検索ボタン押下
            if (sender.Equals(this.btn02PartsCodeSearch))
            {
                string strReciveValue = frmParts.Showminiform();
                txt02PartsCode.Text = strReciveValue;
                //部品名を取得
                string strResiveValue2 = NameSubmit.PartsName_Submit(txt02PartsCode.Text);
                lbl02PartsName.Text = strResiveValue2;

            }

            //部品コード３検索ボタン押下
            if (sender.Equals(this.btn03PartsCodeSearch))
            {
                string strReciveValue = frmParts.Showminiform();
                txt03PartsCode.Text = strReciveValue;
                //部品名を取得
                string strResiveValue2 = NameSubmit.PartsName_Submit(txt03PartsCode.Text);
                lbl03PartsName.Text = strResiveValue2;

            }





            //更新担当者ボタン押下
            if (sender.Equals(this.btnHumanNoSearch)) {
                string strReciveValue = frmHuman.ShowminiForm();
                txtHumanNo.Text = strReciveValue;
            }


        }

        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CT007_KeyDown(object sender, KeyEventArgs e)
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
                    if (btnDelete.Enabled == true) { Delete_Main(); }
                    break;

                case Keys.F4:
                    //クリア処理
                    smClear();
                    break;
            }

        }

        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main()
        {
            //変数定義
            CheckClass CheckClass = new CheckClass();
            SearchClass SearchClass = new SearchClass();

            //空欄以外の場合は、更新モード
            //空欄の場合は、登録モード
            if (txtSearchProductCode.Text.Trim() != ""){
                //入力した値が存在するかチェック
                if (true == SearchClass.Search_Check(txtSearchProductCode.Text.Trim())){
                    //存在した場合は値の取得
                    //PRODUCT_MSから、値の取得
                    txtProductNo.Text = SearchClass.Search_ReturnValue("製品NO", txtSearchProductCode.Text.Trim()); //製品NO
                    txtProductCode.Text = SearchClass.Search_ReturnValue("製品コード", txtSearchProductCode.Text.Trim()); //製品コード
                    txtProductName.Text = SearchClass.Search_ReturnValue("製品名", txtSearchProductCode.Text.Trim()); //製品名
                    txtWarehouseNo.Text = SearchClass.Search_ReturnValue("倉庫NO", txtSearchProductCode.Text.Trim()); //倉庫NO
                    txtRemark.Text = SearchClass.Search_ReturnValue("備考", txtSearchProductCode.Text.Trim()); //備考
                    txt01PartsCode.Text = SearchClass.Search_ReturnValue("使用部品コード1", txtSearchProductCode.Text.Trim()); //部品コード１
                    txt02PartsCode.Text = SearchClass.Search_ReturnValue("使用部品コード2", txtSearchProductCode.Text.Trim()); //部品コード２
                    txt03PartsCode.Text = SearchClass.Search_ReturnValue("使用部品コード3", txtSearchProductCode.Text.Trim()); //部品コード３
                    //最新単価の取得
                    txtUpdateMoney.Text = SearchClass.Search_latestMoney(txtSearchProductCode.Text.Trim()); //単価
                    txtOriginalMoney.Text = SearchClass.Search_latestMoney(txtSearchProductCode.Text.Trim()); //元の単価
                    //DataGridViewの設定
                    DataSet dsDataset = SearchClass.Search_DataGridView(txtSearchProductCode.Text.Trim());
                    //DataGridViewの初期化
                    dataGridView.DataSource = null;
                    //取得できた場合のみバインドする
                    if (dsDataset != null){
                        dataGridView.DataSource = dsDataset.Tables[0];
                    }
                    
                    //表示設定
                    txtSearchProductCode.Enabled = false;
                    txtProductNo.Enabled = false;
                    txtProductCode.Enabled = false;
                    txtOriginalMoney.Enabled = false;
                    groupBox3.Enabled = true;
                    btnSubmit.Enabled = true;
                    btnDelete.Enabled = true;
                    lblMode.Text = "更新";

                }else{
                    //存在しない場合はエラー
                    MessageBox.Show("入力した製品コードは存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


                

            }else{
                //登録モード
                //製品NoのMAX値＋１を取得する
                int intReciveValue = CheckClass.Check_ProductNoMAX();
                txtProductNo.Text = Convert.ToString(intReciveValue);
                //表示設定
                txtSearchProductCode.Enabled = false;
                txtProductNo.Enabled = false;
                txtOriginalMoney.Enabled = false;
                groupBox3.Enabled = true;
                btnSubmit.Enabled = true;
                lblMode.Text = "登録";
            }
        }

        //////////////////////////////////////////////////
        //更新前チェック処理                            //
        //////////////////////////////////////////////////
        private Boolean Submit_Check()
        {
            //変数定義
            CheckClass CheckClass = new CheckClass();

            //製品コードのチェック
            //登録の場合、空欄、もしくは、既に存在している場合、エラー
            if (lblMode.Text == "登録"){
                if (txtProductCode.Text.Trim() == "") { MessageBox.Show("製品コードが空欄のため、更新できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
                if (false == CheckClass.Check_ProductCode(txtProductCode.Text.Trim())) { MessageBox.Show("入力した製品コードは既に存在しているため、更新できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            }

            //製品名のチェック
            //空欄の場合、エラー
            if (txtProductName.Text.Trim() == "") { MessageBox.Show("製品名が空欄のため、更新できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //倉庫NOのチェック
            //存在しない倉庫NOの場合、エラー
            if (false == CheckClass.Check_WarehouseNo(txtWarehouseNo.Text.Trim())) { MessageBox.Show("入力した倉庫NOが存在しないため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            
            //部品コードのチェック
            //空欄以外で、存在しない部品コードの場合、エラー
            if (txt01PartsCode.Text.Trim() != "") { //部品コード１の場合
                if (false == CheckClass.Check_PartsCode(txt01PartsCode.Text.Trim())) { MessageBox.Show("入力した部品コードは存在しないため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            }

            if (txt02PartsCode.Text.Trim() != ""){ //部品コード２の場合
                if (false == CheckClass.Check_PartsCode(txt02PartsCode.Text.Trim())) { MessageBox.Show("入力した部品コードは存在しないため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            }

            if (txt03PartsCode.Text.Trim() != ""){ //部品コード３の場合
                if (false == CheckClass.Check_PartsCode(txt03PartsCode.Text.Trim())) { MessageBox.Show("入力した部品コードは存在しないため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            }

            //単価のチェック
            //空欄の場合、エラー
            if (txtUpdateMoney.Text.Trim() == "") { MessageBox.Show("単価が空欄のため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //更新担当者のチェック
            //存在しない更新担当者の場合、エラー
            if (false == CheckClass.Check_HumanMS(txtHumanNo.Text.Trim())) { MessageBox.Show("入力した更新担当者が存在しないため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }


            //問題ない場合は、TRUEをかえす
            return true;

        }

        //////////////////////////////////////////////////
        //更新メイン処理                                //
        //////////////////////////////////////////////////
        private void Submit_Main(){

            //変数定義
            SubmitClass SubmitClass = new SubmitClass(); 
            string strSQL;
            SqlCommand cd;
            SqlTransaction tran = null;
            //更新確認メッセージ
            if (MessageBox.Show("更新しますか？", "更新確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                //チェック処理
                if (true == Submit_Check()){
                    try{
                        //トランザクションの開始
                        CTCommon.DBConnect.cn.Open();
                        tran = CTCommon.DBConnect.cn.BeginTransaction();
                        ////製品マスタ更新処理
                        //SQL取得
                        strSQL = SubmitClass.Submit_ProductMS(lblMode.Text, txtProductNo.Text.Trim(), txtProductCode.Text.Trim(), txtProductName.Text.Trim(), txt01PartsCode.Text.Trim(), txt02PartsCode.Text.Trim(), txt03PartsCode.Text.Trim(), txtWarehouseNo.Text.Trim(), txtRemark.Text.Trim(), txtHumanNo.Text.Trim());
                        //SQL実行
                        cd = new SqlCommand (strSQL, CTCommon.DBConnect.cn);
                        cd.Transaction = tran;
                        cd.ExecuteNonQuery();
                        ////製品単価履歴マスタ更新処理
                        //SQL取得
                        strSQL = SubmitClass.Submit_ProductHistoryMS(txtProductCode.Text.Trim(), txtUpdateMoney.Text.Trim(), txtHumanNo.Text.Trim());
                        //SQL実行
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        cd.Transaction = tran;
                        cd.ExecuteNonQuery();



                        //更新完了：Commit処理
                        MessageBox.Show("更新完了しました。", "更新完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        //削除メイン処理                                //
        //////////////////////////////////////////////////
        private void Delete_Main(){

            //変数定義
            SqlTransaction tran = null;
            SqlCommand cd = null;
            string strSQL;
            DeleteClass DeleteClass = new DeleteClass();

            //削除確認メッセージ
            if (MessageBox.Show("削除しますか？ \r\n単価履歴情報も削除されます。", "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                try
                {
                    //トランザクション処理開始
                    CTCommon.DBConnect.cn.Open();
                    tran = CTCommon.DBConnect.cn.BeginTransaction();
                    //PRODUCT_MSのSQL発行
                    strSQL = DeleteClass.Delete_Main("1", txtProductCode.Text.Trim());
                    //SQL実行
                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                    cd.Transaction = tran;
                    cd.ExecuteNonQuery();
                    //PRODUCT_HISTORY_MSのSQL発行
                    strSQL = DeleteClass.Delete_Main("2", txtProductCode.Text.Trim());
                    //SQL実行
                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                    cd.Transaction = tran;
                    cd.ExecuteNonQuery();
                    //削除完了
                    MessageBox.Show("削除完了しました。", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tran.Commit();
                    smClear();



                }catch (Exception e){
                    tran.Rollback();
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
            //テキストボックス初期化
            txtSearchProductCode.Clear();
            txtProductNo.Clear();
            txtProductCode.Clear();
            txtProductName.Clear();
            txtWarehouseNo.Clear();
            txt01PartsCode.Clear();
            txt02PartsCode.Clear();
            txt03PartsCode.Clear();
            txtUpdateMoney.Clear();
            txtOriginalMoney.Clear();
            txtHumanNo.Clear();
            txtRemark.Clear();
            txtSearchProductCode.Enabled = true;
            txtProductNo.Enabled = true;
            txtProductCode.Enabled = true;
            //ラベル初期化
            lbl01PartsName.Text = "";
            lbl02PartsName.Text = "";
            lbl03PartsName.Text = "";
            lblMode.Text = "";
            //GroupBox初期化
            groupBox3.Enabled = false;
            //ボタン初期化
            btnSubmit.Enabled = false;
            btnDelete.Enabled = false;
            //DataGridViewの初期化
            dataGridView.DataSource = null;

        }







    }
}

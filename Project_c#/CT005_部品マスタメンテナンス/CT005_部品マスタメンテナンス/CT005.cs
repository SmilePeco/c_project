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

namespace CT005_部品マスタメンテナンス
{
    public partial class CT005 : Form
    {
        public CT005()
        {
            InitializeComponent();
        }


        ///////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CT005_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();

        }

        ///////////////////////////////////////////////////
        //ファンクションキー押下処理                     //
        //////////////////////////////////////////////////
        private void CT005_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    Search_Main();
                    break;
                case Keys.F2:
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

        ///////////////////////////////////////////////////
        //ボタンクリック処理                            //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e)
        {
            //変数定義
            CTCommon.CTPartsClassMSSearch frmPartsClassSearch = new CTCommon.CTPartsClassMSSearch();
            CTCommon.CTHumanMSSearch frmHumanSearch = new CTCommon.CTHumanMSSearch();
            CTCommon.CTPartsMSSearch frmPartsSearch = new CTCommon.CTPartsMSSearch();

            //部品マスタ検索を押下
            if (sender.Equals(this.btnSearchPartsCodeSearch)){
                string strReturnValue = frmPartsSearch.Showminiform();
                txtSearchPartsCode.Text = strReturnValue;

            }

            //部品分類NO検索を押下
            if (sender.Equals(this.btnPartsClassNoSearch)) {
                string strReturnValue = frmPartsClassSearch.Showminiform();
                txtPartsClassNo.Text = strReturnValue;
            }

            //更新担当者検索を押下
            if (sender.Equals(this.btnHumanNoSearch)){
                string strReturnValue = frmHumanSearch.ShowminiForm();
                txtHumanNo.Text = strReturnValue;

            }

            if (sender.Equals(this.btnSearch)) { Search_Main(); } //検索ボタン押下
            if (sender.Equals(this.btnSubmit)) { Submit_Main(); } //更新ボタン押下
            if (sender.Equals(this.btnDelete)) { Delete_Main(); } //削除ボタン押下
            if (sender.Equals(this.btnClear)) { smClear(); } //クリアボタン押下
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了ボタン押下

        }

        ///////////////////////////////////////////////////
        //テキストボックス KeyPress処理                 //
        //////////////////////////////////////////////////
        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {
                if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b') { e.Handled = true; }　//数値とバックスペース以外入力禁止

        }


        ///////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main()
        {
            //変数定義
            SearchClass SearchClass = new SearchClass();
            DataSet dsDataset = new DataSet();

            if (txtSearchPartsCode.Text.Trim() != ""){
                ////空白以外の場合
                //入力した部品コードが存在するか確認
                if (SearchClass.Search_PartsCode(txtSearchPartsCode.Text.Trim()) != ""){
                    //存在した場合
                    //更新モード
                    //検索処理
                    txtPartsNo.Text = SearchClass.Search_PartsNo(txtSearchPartsCode.Text.Trim()); //部品No
                    txtPartsCode.Text = SearchClass.Search_PartsCode(txtSearchPartsCode.Text.Trim()); //部品コード
                    txtPartsName.Text = SearchClass.Search_PartsName(txtSearchPartsCode.Text.Trim()); //部品名
                    txtPartsClassNo.Text = SearchClass.Search_PartsClassNo(txtSearchPartsCode.Text.Trim()); //部品分類No
                    txtUpdateMoney.Text = SearchClass.Search_UpdateMoney(txtSearchPartsCode.Text.Trim()); //単価
                    txtOriginalMoney.Text = SearchClass.Search_UpdateMoney(txtSearchPartsCode.Text.Trim()); //元の単価
                    txtHumanNo.Text = SearchClass.Search_HumanNo(txtSearchPartsCode.Text.Trim()); //更新担当者

                    //単価履歴
                    //DataSet取得
                    dsDataset = SearchClass.Search_UpdateMoney_History(txtSearchPartsCode.Text.Trim());
                    //DataSetバインド
                    if (dsDataset != null){ dataGridView1.DataSource = dsDataset.Tables[0];   }
                    else{ dataGridView1.DataSource = null; }
                    //トリム処理
                    for (int i = 0; i <= dataGridView1.RowCount - 1; i++){
                        for(int y = 0; y <= dataGridView1.ColumnCount -1; y++){
                            dataGridView1[y, i].Value = dataGridView1[y, i].Value.ToString().Trim();
                        }
                    }


                    //ヘッダーとすべてのセルの内容に合わせて、列の幅を自動調整する
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    //クローズ処理
                    CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                    
                    //表示設定
                    groupBox3.Enabled = true;
                    btnSubmit.Enabled = true;
                    btnDelete.Enabled = true;
                    txtPartsCode.Enabled = false;
                    lblMode.Text = "更新";

                }
                else { MessageBox.Show("未入力した部品コードは存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }else{
                ////空白の場合
                //登録モード
                //クリア処理
                smClear();
                //連番設定
                int intCount = SearchClass.Search_ItemNOMAX();
                txtPartsNo.Text = Convert.ToString(intCount);
                //表示設定
                groupBox3.Enabled = true;
                btnSubmit.Enabled = true;
                btnDelete.Enabled = true;
                lblMode.Text = "登録";



            }
        }


        ///////////////////////////////////////////////////
        //更新メイン処理                                 //
        //////////////////////////////////////////////////
        private void Submit_Main(){

            //変数定義
            SqlCommand cd = null;
            SqlTransaction tran = null;
            SearchClass SearchClass = new SearchClass();


            //確認メッセージ
            if (MessageBox.Show("更新しますか？", "更新確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                //チェック処理
                if (true == Submit_Check())
                {
                    try
                    {
                        ////更新処理
                        //トランザクション開始
                        CTCommon.DBConnect.DBConect_Main();
                        CTCommon.DBConnect.cn.Open();
                        tran = CTCommon.DBConnect.cn.BeginTransaction();
                        SubmitClass CLSubmit = new SubmitClass();
                        //Submitクラスから、PARTS_MAIN更新のSQL生成
                        string strSQL = CLSubmit.Submit_Main_PARTS_MS(lblMode.Text, txtPartsNo.Text.Trim(), txtPartsCode.Text.Trim(), txtPartsName.Text.Trim(), txtPartsClassNo.Text.Trim(), txtUpdateMoney.Text.Trim(), txtHumanNo.Text.Trim());
                        //SQL実行（PARTS_MAIN）
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        cd.Transaction = tran;
                        cd.ExecuteNonQuery();
                        //Submitクラスから、PARTS_HISYORY_MAIN更新のSQL生成
                        //更新の場合は単価が変更ある場合のみ更新対象とする
                        if (lblMode.Text == "更新"){
                            //単価と元の単価の値を比べる
                            //トリム処理
                            txtUpdateMoney.Text = txtUpdateMoney.Text.Trim();
                            if (txtOriginalMoney.Text.Trim() != txtUpdateMoney.Text.TrimStart('0')){
                                //異なっていた場合は、通常登録
                                strSQL = CLSubmit.Submit_Main_PARTS_HISORY_MS(lblMode.Text, txtPartsNo.Text.Trim(), txtPartsCode.Text.Trim(), txtPartsName.Text.Trim(), txtPartsClassNo.Text.Trim(), txtUpdateMoney.Text.Trim(), txtHumanNo.Text.Trim());
                                //SQL実行（PARTS_MAIN）
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();
                            }else{
                                //同じだった場合は、メッセージを表示して更新対象外とする
                                MessageBox.Show("単価は値の変更が無いため、更新対象外となります。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }else{
                            //登録の場合は通常登録
                            strSQL = CLSubmit.Submit_Main_PARTS_HISORY_MS(lblMode.Text, txtPartsNo.Text.Trim(), txtPartsCode.Text.Trim(), txtPartsName.Text.Trim(), txtPartsClassNo.Text.Trim(), txtUpdateMoney.Text.Trim(), txtHumanNo.Text.Trim());
                            //SQL実行（PARTS_MAIN）
                            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                            cd.Transaction = tran;
                            cd.ExecuteNonQuery();
                        }
                        //更新完了
                        MessageBox.Show("更新が完了いたしました。", "更新完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        tran.Commit();
                        //クローズ処理
                        smClear();




                    }
                    catch (Exception e)
                    {
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
            

        }

        ///////////////////////////////////////////////////
        //更新チェック処理                              //
        //////////////////////////////////////////////////
        private Boolean Submit_Check()
        {
            //変数定義
            CheckClass CLCheck = new CheckClass();

            //部品コードチェック
            //未記入の場合はエラー
            if (txtPartsCode.Text.Trim() == "") { MessageBox.Show("部品コードが未入力です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            //新規の場合、マスタ検索し、存在している場合はエラー
            if (lblMode.Text == "登録"){
                if (false == CLCheck.Check_PartsCode(txtPartsCode.Text.Trim())) { MessageBox.Show("入力した部品コードは既に存在しています。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            }

            //部品分類コード
            //未記入の場合はエラー
            if (txtPartsCode.Text.Trim() == "") { MessageBox.Show("部品分類コードが未入力です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            //マスタ検索し、存在していない場合はエラー
            if (false == CLCheck.Check_PartsClass(txtPartsClassNo.Text.Trim())) { MessageBox.Show("入力した部品分類コードが存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            
            //単価
            //未記入の場合はエラー
            if (txtUpdateMoney.Text.Trim() == "") { MessageBox.Show("単価が未入力です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //更新担当者
            //マスタ検索し、存在していない場合はエラー
            if (false == CLCheck.Check_HumanMS(txtHumanNo.Text.Trim())) { MessageBox.Show("入力した更新担当者がマスタに存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }


            //問題なければ、TRUEをかえす
            return true;
        }

        ///////////////////////////////////////////////////
        //削除メイン処理                                 //
        //////////////////////////////////////////////////
        private void Delete_Main(){

            //変数定義
            SqlTransaction tran = null;
            SqlCommand cd = null;
            string strSQL;
            DeleteClass DeleteClass = new DeleteClass();

            //削除最終確認
            if (MessageBox.Show("削除しますか？ \r\n単価履歴マスタも全て削除されます。", "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                try
                {
                    //トランザクション処理開始
                    CTCommon.DBConnect.DBConect_Main();
                    CTCommon.DBConnect.cn.Open();
                    tran = CTCommon.DBConnect.cn.BeginTransaction();
                    //部品コード削除処理
                    strSQL = DeleteClass.Delete_PartsMS(txtPartsCode.Text.Trim());
                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                    cd.Transaction = tran;
                    cd.ExecuteNonQuery();
                    //単価履歴マスタ削除処理
                    strSQL = DeleteClass.Delete_PartsHistoryMS(txtPartsCode.Text.Trim());
                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                    cd.Transaction = tran;
                    cd.ExecuteNonQuery();
                    //削除完了
                    MessageBox.Show("削除完了しました。", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tran.Commit();
                    smClear();



                }
                catch (Exception e)
                {
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

        ///////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        private void smClear(){
            //テキストボックス初期化
            txtSearchPartsCode.Clear();
            txtPartsNo.Clear();
            txtPartsCode.Clear();
            txtPartsName.Clear();
            txtPartsClassNo.Clear();
            txtUpdateMoney.Clear();
            txtHumanNo.Clear();
            txtOriginalMoney.Clear();
            txtPartsNo.Enabled = false;
            txtPartsCode.Enabled = true;
            txtOriginalMoney.Enabled = false;
            //ラベル初期化
            lblMode.Text = "";
            //TabControl初期化
            tbcMain.SelectedIndex = 0;
            //GroupBox初期化
            groupBox3.Enabled = false;
            //DatagridView初期化
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            //ボタン初期化
            btnSubmit.Enabled = false;
            btnDelete.Enabled = false;
        }





    }
}

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

namespace CT011_部品本登録画面
{
    public partial class CT011 : Form
    {
        public CT011()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CT011_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();

        }

        //////////////////////////////////////////////////
        //ファンクションキー押下処理                    //
        //////////////////////////////////////////////////
        private void CT011_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode){
                case Keys.F1:
                    //検索処理
                    Search_Main();
                    break;

                case Keys.F2:
                    //登録、削除処理
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
            if (sender.Equals(this.btnSearch)) { Search_Main(); } //検索ボタン押下処理
            if (sender.Equals(this.btnSubmit)) { Submit_Main(); } //登録、削除ボタン押下処理
            if (sender.Equals(this.btnClear)) { smClear(); } //クリア処理
            if (sender.Equals(this.btnEnd)) { this.Close(); } //クローズ処理



            //製品コード検索ボタン押下
            if (sender.Equals(this.btnPartsMSSearch)) {
                //変数定義
                CTCommon.CTPartsMSSearch frmSearch = new CTCommon.CTPartsMSSearch();
                string strPartsCode = frmSearch.Showminiform();
                txtPartsCode.Text = strPartsCode;
                //部品名取得
                CTCommon.NameSubmit NameSubmit = new CTCommon.NameSubmit();
                string strPartsName = NameSubmit.PartsName_Submit(txtPartsCode.Text);
                lblPartsName.Text = strPartsName;
            }

            //更新担当者検索ボタン押下
            if (sender.Equals(this.btnHumanMSSearch)) {
                //変数定義
                CTCommon.CTHumanMSSearch frmSearch = new CTCommon.CTHumanMSSearch();
                string strHumanNo = frmSearch.ShowminiForm();
                txtHumanMSNo.Text = strHumanNo;
            }

        }

        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main(){

            //変数定義
            SearchClass SearchClass = new SearchClass();
            DataSet dsDataset = new DataSet();

            //DataSet取得処理
            dsDataset = SearchClass.Search_Dataset(txtPartsCode.Text.Trim(), dtpSubmitFrom.Text.Trim(), dtpSubmitTo.Text.Trim());
            //DataSetの調査
            if (dsDataset != null){
                //DataSetバインド
                dataGridView1.DataSource = dsDataset.Tables[0];
                //トリム処理、入力不可処理
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++){
                    for (int y = 0; y <= dataGridView1.ColumnCount - 1; y++){
                        dataGridView1[y, i].Value = dataGridView1[y, i].Value.ToString().Trim();
                        dataGridView1.Columns[y].ReadOnly = true;
                    }
                }
                //登録・削除のチェックボックス追加
                DataGridViewCheckBoxColumn dgvCheck = new DataGridViewCheckBoxColumn();
                dataGridView1.Columns.Insert(0, dgvCheck);
                dataGridView1.Columns[0].HeaderText = cboClass.Text;
                //DataGridView1のすべての列の幅を自動調整する
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                //表示設定
                cboClass.Enabled = false;
                btnSubmit.Enabled = true;
                btnSubmit.Text = "F2:" + cboClass.Text + " ";

            }else{
                MessageBox.Show("検索結果が０件です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        //////////////////////////////////////////////////
        //更新チェック処理                              //
        //////////////////////////////////////////////////
        private Boolean Submit_Check(){
            //フォーカスを外す
            dataGridView1.EndEdit();
            this.ActiveControl = null;

            //変数定義
            int intCount = 0;
            CTCommon.ValueCheck ValueCheck = new CTCommon.ValueCheck();

            //チェック数を取得
            //チェック数が０の場合はエラー
            for(int i = 0; i <= dataGridView1.RowCount -1; i++){
                if (Convert.ToBoolean(dataGridView1[0, i].Value) == true) { intCount += 1; }
            }
            if (intCount == 0) { MessageBox.Show("チェック数が０です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //更新担当者チェック
            if (false == ValueCheck.Check_HumanMS(txtHumanMSNo.Text.Trim())) { MessageBox.Show("入力した更新担当者は存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //問題なければ、TRUEをかえす
            return true;

        }

        //////////////////////////////////////////////////
        //更新メイン処理                                //
        //////////////////////////////////////////////////
        private void Submit_Main(){
            //変数定義
            SubmitClass SubmitClass = new SubmitClass();
            DeleteClass DeleteClass = new DeleteClass();
            SqlTransaction tran = null;
            SqlCommand cd = null;
            string strSQL = "";

            //確認メッセージ
            if (MessageBox.Show("" + cboClass.Text + "しますか？", "" + cboClass.Text + "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                if (true == Submit_Check()){
                    try
                    {
                        //トランザクション開始
                        CTCommon.DBConnect.cn.Open();
                        tran = CTCommon.DBConnect.cn.BeginTransaction();
                        //登録か削除かチェック
                        if (cboClass.Text == "登録")
                        {
                            //登録モード
                            //DataGridViewの値を１件ずつ最後尾まで取得
                            for (int i = 0; i <= dataGridView1.RowCount - 1; i++){
                                //チェックが入っている列のみ更新対象
                                if (Convert.ToBoolean(dataGridView1[0, i].Value) == true){
                                    //PARTS_TBL:SQL取得
                                    strSQL = SubmitClass.Submit_PartsTBL(dataGridView1[1, i].Value.ToString(), txtHumanMSNo.Text.Trim());
                                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                    //PARTS_TBL:更新処理
                                    cd.Transaction = tran;
                                    cd.ExecuteNonQuery();
                                    //PARTS_HISTORY_TBL:SQL取得
                                    strSQL = SubmitClass.Submit_PartsHistoryTBL(dataGridView1[1, i].Value.ToString(), txtHumanMSNo.Text.Trim());
                                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                    //PARTS_TBL:更新処理
                                    cd.Transaction = tran;
                                    cd.ExecuteNonQuery();
                                }
        
                            }

                            //登録完了
                            MessageBox.Show("登録完了しました。", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            tran.Commit();
                            smClear();

                        }
                        else
                        {
                            //削除モード
                            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                            {
                                //チェックが入っている列のみ削除対象
                                if (Convert.ToBoolean(dataGridView1[0, i].Value) == true){
                                    //PARTS_TBL:SQL取得
                                    strSQL = DeleteClass.Delete_PartsMS(dataGridView1[1, i].Value.ToString());
                                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                    //PARTS_TBL:削除処理
                                    cd.Transaction = tran;
                                    cd.ExecuteNonQuery();
                                    //PARTS_HISTORY_TBL:SQL取得
                                    strSQL = DeleteClass.Delete_PartsHistoryMS(dataGridView1[1, i].Value.ToString());
                                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                    //PARTS_TBL:削除処理
                                    cd.Transaction = tran;
                                    cd.ExecuteNonQuery();
                                }
                            }

                            //登録完了
                            MessageBox.Show("削除完了しました。", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            tran.Commit();
                            smClear();

                        }

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
            txtHumanMSNo.Clear();
            //ラベル初期化
            lblPartsName.Text = "";
            //コンボボックス初期化
            cboClass.Enabled = true;
            cboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClass.Items.Clear();
            cboClass.Items.Add("登録");
            cboClass.Items.Add("削除");
            cboClass.SelectedIndex = 0;
            //DataTimePicker初期化
            dtpSubmitFrom.Value = DateTime.Now;
            dtpSubmitTo.Value = DateTime.Now;
            //DataGridView初期化
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            //ボタン初期化
            btnSubmit.Enabled = false;
            btnSubmit.Text = "F2";



        }






    }
}

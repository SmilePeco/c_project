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

namespace CT002_受注登録画面
{
    public partial class CT002 : Form
    {
        public CT002()
        {
            InitializeComponent();
        }



        //////////////////////////////////////////////////
        //ロード処理                                    //
        //////////////////////////////////////////////////
        private void CT002_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();
        }



        //////////////////////////////////////////////////
        //ファンクションキー押下処理                    //
        //////////////////////////////////////////////////
        private void CT002_KeyDown(object sender, KeyEventArgs e){

            CheckClass chkClass = new CheckClass();

            switch (e.KeyCode)
            {
                case Keys.F1:
                    //検索処理
                    Search_Main();
                    break;

                case Keys.F2:
                    //登録、削除処理
                    if (btnSubmit.Enabled == true){
                        Submit();
                    }
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
        private void button_Click(object sender, EventArgs e)
        {
            //ファンクションキー：検索ボタン押下
            if (sender.Equals(this.btnSearch)){
                Search_Main();
            }

            //ファンクションキー：登録、削除ボタン押下
            if (sender.Equals(this.btnSubmit)){
                Submit();
            }

            //ファンクションキー：クリアボタン押下
            if(sender.Equals(this.btnClear)){
                smClear();
            }

            //ファンクションキー：終了ボタン押下
            if (sender.Equals(this.btnEnd)){
                this.Close();
            }

            //検索条件：受注先NOの受注先ボタンを押下
            if (sender.Equals(this.btnOrderMSSearch)){
                //受注先NO検索を開く
                CTCommon.CTOrderMSSearch frmSearch = new CTCommon.CTOrderMSSearch();
                string strOrderNo = frmSearch.ShowMiniForm();
                txtOrderMSNo.Text = strOrderNo;
                frmSearch.Dispose();
                //受注先名を取得
                CTCommon.NameSubmit frmSubmit = new CTCommon.NameSubmit();
                string strOrderName = frmSubmit.OrderMSName_Submit(txtOrderMSNo.Text);
                lblOrderMSName.Text = strOrderName;

            }

            //検索条件：受注NOの受注先ボタンを押下
            if(sender.Equals(this.btnOrderNoSerach01)){
                //受注先NO検索を開く
                CTCommon.CTOrderMSSearch frmSearch = new CTCommon.CTOrderMSSearch();
                string strOrderNo = frmSearch.ShowMiniForm();
                txtOrderNoSearch01.Text = strOrderNo;
                frmSearch.Dispose();
                //受注先名の取得
                CTCommon.NameSubmit frmSubmit = new CTCommon.NameSubmit();
                string strOrderName = frmSubmit.OrderMSName_Submit(txtOrderNoSearch01.Text);
                lblOrderNoSearch01.Text = strOrderName;
                     

            }
            
            //検索条件：受注NOの検索ボタン押下
            if (sender.Equals(this.btnOrderNoSerach02)){
                //受注NO検索を開く
                CTCommon.CTOrderNOSearch frmSearch = new CTCommon.CTOrderNOSearch();
                string strOrderNo = frmSearch.ShowminiForm(txtOrderNoSearch01.Text, dtpOrderNoSearch01.Text, dtpOrderNoSearch02.Text);
                txtOrderNo.Text = strOrderNo;
                
            }

            //更新担当者のボタン押下
            if (sender.Equals(this.btnHumanMSSearch))
            {
                //更新担当者マスタ検索を開く
                CTCommon.CTHumanMSSearch frmSearch = new CTCommon.CTHumanMSSearch();
                string strHumanNo = frmSearch.ShowminiForm();
                txtHumanMSNo.Text = strHumanNo;
            }
            
        }


        //////////////////////////////////////////////////
        //ラジオ、チェックボックス チェック処理         //
        //////////////////////////////////////////////////
        private void rbo_CheckedChanged(object sender, EventArgs e)
        {
            //受注先NO、受注日をチェックした場合
            if (sender.Equals(this.rboSearch01)){
                if (true == rboSearch01.Checked){
                    //受注先NO、受注日の検索条件を表示する
                    groupBox2.Enabled = true;
                    groupBox3.Enabled = false;
                }
                
            }

            //受注NOをチェックした場合
            if (sender.Equals(this.rboSearch02)){
                if (true == rboSearch02.Checked){
                    //受注NOの検索条件を表示する
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = true;
                }
            }

            //検索条件：受注NO 受注NOを検索をチェックした場合
            if (chkOrderNOSearch.Equals(this.chkOrderNOSearch)){
                if (true == chkOrderNOSearch.Checked){
                    //検索ボックスを使用可
                    groupBox5.Enabled = true;
                }else{
                    //検索ボックスを使用不可
                    groupBox5.Enabled = false;
                }
            }

        }

       

        ///////////////////////////////////////////////////
        //テキストボックス Leave処理                    //
        //////////////////////////////////////////////////
        private void text_Leave(object sender, EventArgs e)
        {

            if (sender.Equals(this.txtOrderMSNo))
            {
                //受注先NOを０埋め処理
                txtOrderMSNo.Text = txtOrderMSNo.Text.PadLeft(3, '0');
                //受注先名を取得
                CTCommon.NameSubmit frmSubmit = new CTCommon.NameSubmit();
                string strOrderName = frmSubmit.OrderMSName_Submit(txtOrderMSNo.Text);
                lblOrderMSName.Text = strOrderName;

            }

            if (sender.Equals(this.txtOrderNoSearch01))
            {
                //受注先NOを０埋め処理
                txtOrderNoSearch01.Text = txtOrderNoSearch01.Text.PadLeft(3, '0');
                //受注先名を取得
                CTCommon.NameSubmit frmSubmit = new CTCommon.NameSubmit();
                string strOrderName = frmSubmit.OrderMSName_Submit(txtOrderNoSearch01.Text);
                lblOrderNoSearch01.Text = strOrderName;

            }

        }

        //////////////////////////////////////////////////
        //テキストボックス 数値のみ KeyPress処理        //
        //////////////////////////////////////////////////
        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //数値とバックスペース以外入力禁止
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main(){
            //変数定義
            //検索条件：受注先NO intCount=1
            //検索条件：受注NO intCount=2
            int intCount = 0;
            string strOrder = "";
            if (rboSearch01.Checked == true){
                intCount = 1;
                strOrder = txtOrderMSNo.Text;
            }else if (rboSearch02.Checked == true){
                intCount = 2;
                strOrder = txtOrderNo.Text;
            }
            SearchClass CLSearch = new SearchClass();

            //DataGridViewの初期化
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            //F2ボタン初期化
            btnSubmit.Text = "F2:";
            btnSubmit.Enabled = false;
            //検索前チェック
            if (true == Search_Check()){
                //検索開始、DataSetを取得
                DataSet dsDataset = CLSearch.Search_Main(intCount, strOrder, dtpOrderDateFrom.Text, dtpOrderDateTo.Text);
                //DataSetをバインド
                if (dsDataset != null){
                    //バインド前の初期化
                    smClear_Search();
                    //バインド
                    dataGridView1.DataSource = dsDataset.Tables[0];
                    //１列目にチェックボックスを追加する
                    DataGridViewCheckBoxColumn dgvCheck = new DataGridViewCheckBoxColumn();
                    dataGridView1.Columns.Insert(0, dgvCheck);
                    //チェックボックスヘッダー名の変更
                    if (rboSubmit.Checked == true){
                        dataGridView1.Columns[0].HeaderText = "登録";
                    }else if(rboDelete.Checked == true){
                        dataGridView1.Columns[0].HeaderText = "削除";
                    }

                    //１列目以外はトリム処理、ReadOnly
                    for (int i = 0; i <= dataGridView1.RowCount - 1; i++){
                        for (int y = 1; y <= dataGridView1.ColumnCount - 1; y++){
                            dataGridView1[y, i].Value = dataGridView1[y, i].Value.ToString().Trim();
                            dataGridView1[y, i].ReadOnly = true;
                        }
                    }
                    
                    //ヘッダーとすべてのセルの内容に合わせて、列の幅を自動調整する
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                }else{
                    //検索結果０だった場合はメッセージ表示
                    MessageBox.Show("検索結果が０件です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = null;
                }



            }



        }

        //////////////////////////////////////////////////
        //検索前チェック処理                            //
        //////////////////////////////////////////////////
        private Boolean Search_Check(){

            //検索条件が選択されているか確認
            if(rboSearch03.Checked == true){
                MessageBox.Show("検索条件が選択されていません。 \r\n確認してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
                return false;
            }

            //登録、削除が選択されているか確認
            if(rboNone.Checked == true){
                MessageBox.Show("登録、削除が選択されていません。 \r\n確認してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
            }
            

           　//受注先NOのチェック
            //受注先NOが検索条件だった場合のみ
            if (rboSearch01.Checked == true){
                CheckClass CLCheck = new CheckClass();
                //受注先NOチェック処理
                if(false == CLCheck.OrderMS_Check(txtOrderMSNo.Text.Trim())){
                    MessageBox.Show("入力した受注先NOは存在しません。 \r\n確認してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    return false;
                
                    
                }
            }

            //受注NOのチェック
            //受注NOが検索条件だった場合のみ
            if(rboSearch02.Checked == true){
                CheckClass CLCheck = new CheckClass();
                if(false == CLCheck.OrderNO_Check(txtOrderNo.Text.Trim())){
                    MessageBox.Show("入力した受注NOは存在しません。 \r\n確認してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    return false;
                }
            }

            //問題なければ、TRUEを返す
            return true;


        }

        //////////////////////////////////////////////////
        //登録、削除処理                                //
        //////////////////////////////////////////////////
        private void Submit(){
            //編集モード解除
            dataGridView1.EndEdit();

            //登録前のメッセージ表示
            if (MessageBox.Show("更新しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                //登録前チェック処理
                if(true == Submit_Check()){
                    //登録処理
                    if(true == Submit_Main()){
                        smClear();
                    }
                    
                
                }
            }
        }

        //////////////////////////////////////////////////
        //登録、削除メイン処理                          //
        //////////////////////////////////////////////////
        private Boolean Submit_Main(){

            //変数定義
            SqlTransaction tran = null;
            SubmitClass CLClass = new SubmitClass();
            SqlCommand cd = null;
            string strSQL;
            int intCount = 0;

            try{
                //DB接続
                CTCommon.DBConnect.cn.Open();
                //トランザクションの開始
                tran = CTCommon.DBConnect.cn.BeginTransaction();
                //チェックが付いているセルのみ対象
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++){
                    if (true == Convert.ToBoolean(dataGridView1[0, i].Value)){
                        //DataGridViewの値を取得
                        string strOrderNo = dataGridView1[1, i].Value.ToString().Trim();
                        //ラジオボタンの取得、登録＝１、削除＝２
                        if (rboSubmit.Checked == true) { intCount = 1; } else if (rboSubmit.Checked == true) { intCount = 2; }
                        //SQL取得
                        strSQL = CLClass.Submit_Main(intCount, strOrderNo);
                        //SQL実行
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        cd.Transaction = tran;
                        cd.ExecuteNonQuery();
                    }
                }

                //Commit処理
                tran.Commit();
                //クローズ処理
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                MessageBox.Show("更新処理が完了いたしました。", "更新完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return true;
                
            }catch (Exception e){
                Console.WriteLine(e.Message);
                if (tran != null){
                    //RollBack処理
                    tran.Rollback();
                    //クローズ処理
                    CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                    return false;

                }
            }
            return false;
        }

        //////////////////////////////////////////////////
        //登録、削除前チェック処理                      //
        //////////////////////////////////////////////////
        private Boolean Submit_Check(){

            int intCount = 0; //カウント数
            CheckClass CLClass = new CheckClass();

            //チェックボックスのチェック数を確認
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++){
                if (true == Convert.ToBoolean(dataGridView1[0, i].Value)){
                    //チェックだった場合は、＋１
                    intCount += 1;
                }
            }

            //チェック数が０だった場合は、エラー
            if (intCount == 0){
                MessageBox.Show("チェック数が０です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //入力した更新担当者が存在するか確認
            if (false == CLClass.HumanMS_Check(txtHumanMSNo.Text.Trim())){
                MessageBox.Show("入力した更新担当者が存在しません。 \r\n確認してください。","エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            //問題なければ、TRUEを返す
            return true;


        }
        
        //////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        private void smClear()
        {
            //テキストボックスの初期化
            txtOrderMSNo.Clear();
            txtOrderNo.Clear();
            txtOrderNoSearch01.Clear();
            //ラベルの初期化
            lblOrderMSName.Text = "";
            lblOrderNoSearch01.Text = "";
            //時刻の初期化
            dtpOrderDateFrom.Text = DateTime.Now.ToString("yyyy/MM/dd");
            dtpOrderDateTo.Text = DateTime.Now.ToString("yyyy/MM/dd");
            dtpOrderNoSearch01.Text = DateTime.Now.ToString("yyyy/MM/dd");
            dtpOrderNoSearch02.Text = DateTime.Now.ToString("yyyy/MM/dd");
            //GroupBoxの初期化
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox5.Enabled = false;
            //checkboxの初期化
            chkOrderNOSearch.Checked = false;
            //ラジオボタンの初期化
            rboSearch03.Checked = true;
            rboSearch03.Visible = false;
            rboNone.Checked = true;
            rboNone.Visible = false;
            //F2ボタン初期化
            btnSubmit.Text = "F2:";
            btnSubmit.Enabled = false;
            //DataGridViewの初期化
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            



        }


        //////////////////////////////////////////////////
        //クリア処理 - 検索ボタン押下時                 //
        //////////////////////////////////////////////////
        private void smClear_Search(){
            //DataGridViewの初期化
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            //F2ボタン使用可
            btnSubmit.Enabled = true;
            //F2ボタンの名称設定
            if (rboSubmit.Checked == true){
                btnSubmit.Text = "F2:登録";
            }else if(rboDelete.Checked == true){
                btnSubmit.Text= "F2:削除";
            }
            


        }



















    }
}

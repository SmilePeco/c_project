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

namespace CT001_受注仮登録画面
{
    public partial class CT001 : Form
    {
        public CT001()
        {
            //デザインの表示
            InitializeComponent();
        }

        //////////////////////////////////////////////////
        //ロード処理                                    //
        //////////////////////////////////////////////////
        private void CT001_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();

        }

        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CT001_KeyDown(object sender, KeyEventArgs e){

            switch (e.KeyCode){
                case Keys.F1:
                    //登録処理
                    smSubmit();
                    break;
                case Keys.F2:
                    //クリア処理
                    smClear();
                    break;
                case Keys.F3:
                    this.Close();
                    break;
                    
            }
        }


        //////////////////////////////////////////////////
        //ボタン押下処理                                //
        //////////////////////////////////////////////////
        private void button_Click(object sender, EventArgs e){

            //F1:検索ボタン押下
            if (sender.Equals(this.btnSubmit)){ smSubmit(); }

            //F2:クリアボタン押下
            if (sender.Equals(this.btnClear)){ smClear(); }

            //F3:終了ボタン押下
            if (sender.Equals(this.btnEnd)){ this.Close(); }

            //受注先マスタボタン押下
            if (sender.Equals(this.btnOrderMSSearch)){
                //受注先マスタ検索の小窓を開く
                CTCommon.CTOrderMSSearch frmSearch = new CTCommon.CTOrderMSSearch();
                string strOrderNo = frmSearch.ShowMiniForm();
                txtOrderMSNo.Text = strOrderNo;
                frmSearch.Dispose();
                //受注先名の検索
                CTCommon.NameSubmit frmSubmit = new CTCommon.NameSubmit();
                string strOrderName = frmSubmit.OrderMSName_Submit(txtOrderMSNo.Text);
                lblOrderMSName.Text = strOrderName;
                     
            }

            //製品マスタボタン押下
            if (sender.Equals(this.btnProductMSSearch)){
                //製品マスタ検索の小窓を開く
                CTCommon.CTProductMSSearch frmSearch = new CTCommon.CTProductMSSearch();
                string strProductNo = frmSearch.Showminiform();
                txtProductCode.Text = strProductNo;
                frmSearch.Dispose();
                //製品名の検索
                CTCommon.NameSubmit frmSubmit = new CTCommon.NameSubmit();
                string strProductName = frmSubmit.ProductName_Submit(txtProductCode.Text);
                lblProductName.Text = strProductName;
                //単価の検索
                SearchClass SearchClass = new SearchClass();
                string strUnitPrice = SearchClass.Search_UnitPrice(txtProductCode.Text);
                txtOrderUnitPrice.Text = strUnitPrice;
                //受注金額の計算
                SubmitClass SubmitClass = new SubmitClass();
                string strPrice = SubmitClass.Submit_OrderPrice(txtOrderNumber.Text.Trim(), txtOrderUnitPrice.Text.Trim());
                txtOrderPrice.Text = strPrice;
                //作業ラインの初期化
                txtWorklineMSNo.Clear();
                lblWorklineMSName.Text = "";


            }


            //作業ラインNOマスタボタン押下
            if (sender.Equals(this.btnWorklineMSSearch)){
                //作業ラインマスタ検索の小窓を開く
                CTCommon.CTWorklineMSSearch frmSearch = new CTCommon.CTWorklineMSSearch();
                string strWorklineNo = frmSearch.ShowminiForm(txtProductCode.Text.Trim());
                txtWorklineMSNo.Text = strWorklineNo;
                frmSearch.Dispose();
                //作業工程名の検索
                CTCommon.NameSubmit frmSubmit = new CTCommon.NameSubmit();
                string strWorklineName = frmSubmit.WorklineName_Submit(txtWorklineMSNo.Text);
                lblWorklineMSName.Text = strWorklineName;
            }

            //更新担当者マスタボタン押下
            if (sender.Equals(this.btnHumanMSSearch)){
                //更新担当者マスタ検索の小窓を開く
                CTCommon.CTHumanMSSearch frmSearch = new CTCommon.CTHumanMSSearch();
                string strHumanNo = frmSearch.ShowminiForm();
                txtHumanMSNo.Text = strHumanNo;
                frmSearch.Dispose();
                
            }

        }

        //////////////////////////////////////////////////
        //Text数値のみ_KeyPress処理                     //
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
        //受注数_KeyDown処理                            //
        //////////////////////////////////////////////////
        private void txtOrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            //変数定義
            SubmitClass SubmitClass = new SubmitClass();

            //Enterキー押下時に計算処理
            if (e.KeyCode == Keys.Enter){
                string strPrice = SubmitClass.Submit_OrderPrice(txtOrderNumber.Text.Trim(), txtOrderUnitPrice.Text.Trim());
                txtOrderPrice.Text = strPrice;
            } 

        }



        //////////////////////////////////////////////////
        //text_Leave処理                                //
        //////////////////////////////////////////////////
        private void text_Leave(object sender, EventArgs e)
        {
            //変数定義
            CTCommon.NameSubmit frmSubmit = new CTCommon.NameSubmit();
            
            //受注先NOの０埋め処理
            if (sender.Equals(this.txtOrderMSNo))
            {
                txtOrderMSNo.Text = txtOrderMSNo.Text.PadLeft(3, '0');
                //受注先名の検索
                string strOrderName = frmSubmit.OrderMSName_Submit(txtOrderMSNo.Text);
                lblOrderMSName.Text = strOrderName;
            }

            //製品コード 製品名取得処理
            if (sender.Equals(this.txtProductCode))
            {
                //製品名の取得
                string strProductName = frmSubmit.ProductName_Submit(txtProductCode.Text);
                lblProductName.Text = strProductName;
                //作業ライン初期化
                txtWorklineMSNo.Clear();
                lblWorklineMSName.Text = "";
            }

            //作業工程NOの０埋め処理
            if (sender.Equals(this.txtWorklineMSNo))
            {
                txtWorklineMSNo.Text = txtWorklineMSNo.Text.PadLeft(3, '0');
                //作業工程名の検索
                string strWorkProcessName = frmSubmit.WorkProcessMSName_Submit(txtWorklineMSNo.Text);
                lblWorklineMSName.Text = strWorkProcessName;

            }



        }

        //////////////////////////////////////////////////
        //CheckBox チェック切り替え処理                 //
        //////////////////////////////////////////////////
        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {

            //作業ラインを使用しないにチェック
            if (chkNoneWorkLine.Checked == true){
                txtWorklineMSNo.Clear();
                lblWorklineMSName.Text = "";
                groupBox3.Enabled = false;

            }else{
                txtWorklineMSNo.Clear();
                lblWorklineMSName.Text = "";
                groupBox3.Enabled = true;
            }

        }

        //////////////////////////////////////////////////
        //受注NO最大値取得処理                          //
        //////////////////////////////////////////////////
        public void smOrderNO_Setting(){

            //変数定義
            DataSet dsDataset = new DataSet();
            string strSQL;
            SqlDataReader dtReader;
            SqlCommand cd = null;
            int intCount = 0; //受注NO取得用
            
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += "  MAX(受注NO) AS 受注NO ";
            strSQL += "FROM ";
            strSQL += " RECEIVE_TBL ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
            if (dtReader.HasRows){
                while (dtReader.Read()){
                    intCount = Convert.ToInt32(dtReader["受注NO"]);
                    intCount += 1;
                }
           
            }else{
                intCount += 1;
            }
            //取得した値の格納
            txtOrderNo.Text = Convert.ToString(intCount);
            //クローズ処理
            dtReader.Close();
            CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
            
        }



        //////////////////////////////////////////////////
        //登録処理                                      //
        //////////////////////////////////////////////////
        public void smSubmit(){

            //変数定義
            SubmitClass SubmitClass = new SubmitClass();
            SqlCommand cd = null;
            //フォーカスを外す
            this.ActiveControl = null;

            if (MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){

                try{
                    //チェック処理
                    if (true == smSubmit_Check())
                    {
                        //SQL取得
                        string strSQL = SubmitClass.Submit_Main(txtOrderNo.Text.Trim(), txtOrderMSNo.Text.Trim(), txtProductCode.Text.Trim(), txtWorklineMSNo.Text.Trim(), txtOrderNumber.Text.Trim(), txtOrderUnitPrice.Text.Trim(), txtOrderPrice.Text.Trim(), txtHumanMSNo.Text.Trim());
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        CTCommon.DBConnect.cn.Open();
                        cd.ExecuteNonQuery();
                        //登録完了
                        MessageBox.Show("登録完了しました。", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        //登録チェック処理                              //
        //////////////////////////////////////////////////
        public Boolean smSubmit_Check(){

            CheckClass CheckClass = new CheckClass();

            //受注先NOのチェック
            if (false == CheckClass.smCheck_OrderMS(txtOrderMSNo.Text.Trim())) { MessageBox.Show("入力した受注先NOは存在しないため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //製品コードのチェック
            if (false == CheckClass.smCheck_ProductMS(txtProductCode.Text.Trim())) { MessageBox.Show("入力した製品コードは存在しないため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //チェックが外れているときは、作業工程NOのチェック
            if (chkNoneWorkLine.Checked == false){
                if (false == CheckClass.smCheck_WorklineMS(txtWorklineMSNo.Text.Trim())) { MessageBox.Show("入力した作業ラインは存在しないため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            }

            //登録担当者のチェック
            if (false == CheckClass.smCheck_HumanMS(txtHumanMSNo.Text.Trim())) { MessageBox.Show("入力した登録担当者は存在しないため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //受注数のチェック
            if (txtOrderNumber.Text.Trim() == ""){
                MessageBox.Show("受注数が空白です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //単価の検索
            SearchClass SearchClass = new SearchClass();
            string strUnitPrice = SearchClass.Search_UnitPrice(txtProductCode.Text);
            txtOrderUnitPrice.Text = strUnitPrice;
            //受注金額の計算
            SubmitClass SubmitClass = new SubmitClass();
            string strPrice = SubmitClass.Submit_OrderPrice(txtOrderNumber.Text.Trim(), txtOrderUnitPrice.Text.Trim());
            txtOrderPrice.Text = strPrice;

            //単価のチェック
            if (txtOrderUnitPrice.Text.Trim() == "0") { MessageBox.Show("受注単価が０のため、登録できません。 \r\n製品コードを確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //金額のチェック
            if (txtOrderPrice.Text.Trim() == "0") { MessageBox.Show("受注金額が０のため、登録できません。 \r\n製品コードか受注数を確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //問題なければ、TRUEをかえす
            return true;
        }

        //////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        public void smClear()
        {
            //テキストボックスの初期化
            txtOrderNo.Clear();
            txtOrderMSNo.Clear();
            txtWorklineMSNo.Clear();
            txtProductCode.Clear();
            txtOrderNumber.Clear();
            txtHumanMSNo.Clear();
            txtOrderUnitPrice.Clear();
            txtOrderPrice.Clear();
            txtWorklineMSNo.ReadOnly = true;
            txtOrderUnitPrice.Enabled = false;
            txtOrderPrice.Enabled = false;
            //ラベルの初期化
            lblOrderMSName.Text = "";
            lblProductName.Text = "";
            lblWorklineMSName.Text = "";
            //受注NO入力不可
            txtOrderNo.Enabled = false;
            //チェックボックス初期化
            chkNoneWorkLine.Checked = false;

            ////受注NOの取得
            //クローズ処理
            CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
            //メイン処理
            smOrderNO_Setting();
            
        }















    }
}

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
            if (sender.Equals(this.btnSubmit)){
                smSubmit();
            }

            //F2:クリアボタン押下
            if (sender.Equals(this.btnClear)){
                smClear();
            }

            //F3:終了ボタン押下
            if (sender.Equals(this.btnEnd)){
                this.Close();
            }

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

            //作業工程NOマスタボタン押下
            if (sender.Equals(this.btnWorkProcessMSSearch)){
                //作業工程マスタ検索の小窓を開く
                CTCommon.CTWorkProcessMSSearch frmSearch = new CTCommon.CTWorkProcessMSSearch();
                string strWorkProcessNo = frmSearch.ShowminiForm();
                txtWorkProcessMSNo.Text = strWorkProcessNo;
                frmSearch.Dispose();
                //作業工程名の検索
                CTCommon.NameSubmit frmSubmit = new CTCommon.NameSubmit();
                string strWorkProcessName = frmSubmit.WorkProcessMSName_Submit(txtWorkProcessMSNo.Text);
                lblWorkProcessMSName.Text = strWorkProcessName;
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
        //受注NO最大値取得処理                          //
        //////////////////////////////////////////////////
        public void smOrderNO_Setting(){

            //変数定義
            DataSet dsDataset = new DataSet();
            string strSQL;
            SqlDataReader dtReader;
            SqlCommand cd = null;
            int intCount = 0; //受注NO取得用
            
            //DB接続
            CTCommon.DBConnect.DBConect_Main();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += "  MAX(受注NO) AS 受注NO ";
            strSQL += "FROM ";
            strSQL += " ORDER_TBL ";
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


            if (MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                SubmitClass SubmitClass = new SubmitClass();
                //事前トリム処理
                txtOrderNo.Text = txtOrderNo.Text.Trim();
                txtOrderMSNo.Text = txtOrderMSNo.Text.Trim();
                txtWorkProcessMSNo.Text = txtWorkProcessMSNo.Text.Trim();
                txtOrderNumber.Text = txtOrderNumber.Text.Trim();
                txtHumanMSNo.Text = txtHumanMSNo.Text.Trim();

                //チェック処理
                if (true == smSubmit_Check())
                {
                    //チェックが問題なければ、メイン処理
                    SubmitClass.Submit_Main(txtOrderNo.Text, txtOrderMSNo.Text, txtWorkProcessMSNo.Text, txtHumanMSNo.Text, txtOrderNumber.Text);
                    smClear();
                }
            }


            }
            

        //////////////////////////////////////////////////
        //登録チェック処理                              //
        //////////////////////////////////////////////////
        public Boolean smSubmit_Check(){

            CheckClass CheckClass = new CheckClass();

            //受注先NOのチェック
            if (false == CheckClass.smCheck_OrderMS(txtOrderMSNo.Text.Trim())){
                return false;
            }

            //作業工程NOのチェック
            if (false == CheckClass.smCheck_ShipmentMS(txtWorkProcessMSNo.Text.Trim())){
                return false;
            }

            //更新担当者のチェック
            if (false == CheckClass.smCheck_HumanMS(txtHumanMSNo.Text.Trim())){
                return false;
            }

            //受注数のチェック
            if (txtOrderNumber.Text.Trim() == ""){
                MessageBox.Show("受注数が空白です。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
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
            txtWorkProcessMSNo.Clear();
            txtOrderNumber.Clear();
            txtHumanMSNo.Clear();
            //ラベルの初期化
            lblOrderMSName.Text = "";
            lblWorkProcessMSName.Text = "";
            //受注NO入力不可
            txtOrderNo.Enabled = false;

            //受注NOの取得
            smOrderNO_Setting();
            
        }


        //////////////////////////////////////////////////
        //text_Leave処理                                //
        //////////////////////////////////////////////////
        private void text_Leave(object sender, EventArgs e){
            //受注先NOの０埋め処理
            if (sender.Equals(this.txtOrderMSNo)){
                txtOrderMSNo.Text = txtOrderMSNo.Text.PadLeft(3, '0');
                //受注先名の検索
                CTCommon.NameSubmit frmSubmit = new CTCommon.NameSubmit();
                string strOrderName = frmSubmit.OrderMSName_Submit(txtOrderMSNo.Text);
                lblOrderMSName.Text = strOrderName;
            }

            //作業工程NOの０埋め処理
            if (sender.Equals(this.txtWorkProcessMSNo)){
                txtWorkProcessMSNo.Text = txtWorkProcessMSNo.Text.PadLeft(3, '0');
                //作業工程名の検索
                CTCommon.NameSubmit frmSubmit = new CTCommon.NameSubmit();
                string strWorkProcessName = frmSubmit.WorkProcessMSName_Submit(txtWorkProcessMSNo.Text);
                lblWorkProcessMSName.Text = strWorkProcessName;

            }


        
        }


    }
}

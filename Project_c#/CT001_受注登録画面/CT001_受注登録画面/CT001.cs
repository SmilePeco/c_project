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

namespace CT001_受注登録画面
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
            //受注NOの取得
            smOrderNO_Setting();
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
                    
            }
        }

        //////////////////////////////////////////////////
        //受注先NOマスタボタン押下処理                  //
        //////////////////////////////////////////////////
        private void btnOrderMSSearch_Click(object sender, EventArgs e)
        {

            CTCommon.CTOrderMSSearch frmSearch = new CTCommon.CTOrderMSSearch();
            string strOrderNo = frmSearch.ShowMiniForm();
            txtOrderMSNo.Text = strOrderNo;
            frmSearch.Dispose();

        }


        //////////////////////////////////////////////////
        //作業工程NOマスタボタン押下処理                  //
        //////////////////////////////////////////////////
        private void btnWorkProcessMSSearch_Click(object sender, EventArgs e)
        {
            CTCommon.CTWorkProcessMSSearch frmSearch = new CTCommon.CTWorkProcessMSSearch();
            string strWorkProcessNo = frmSearch.ShowminiForm();
            txtWorkProcessMSNo.Text = strWorkProcessNo;
            frmSearch.Dispose();
            
        }

        //////////////////////////////////////////////////
        //受注先NOマスタボタン押下処理                  //
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
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            if (dtReader.HasRows){
                while (dtReader.Read())
                {
                    intCount = Convert.ToInt32(dtReader["受注NO"]);
                    intCount += 1;

                }
                
            }
            else
            {
                intCount += 1;
            }
            //取得した値の格納
            txtOrderNo.Text = Convert.ToString(intCount);
            //クローズ処理
            dtReader.Close();
            CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
            
        }

        //////////////////////////////////////////////////
        //受注数 KeyPress処理                           //
        //////////////////////////////////////////////////
        private void txtOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        //////////////////////////////////////////////////
        //登録処理                                      //
        //////////////////////////////////////////////////
        public void smSubmit(){

            if (true == smSubmit_Check()){

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
            //受注NO入力不可
            txtOrderNo.Enabled = false;
            
        }
        

    }
}

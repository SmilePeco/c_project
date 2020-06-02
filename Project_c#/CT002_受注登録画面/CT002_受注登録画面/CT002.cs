using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        //ボタンクリック処理                            //
        //////////////////////////////////////////////////
        private void button_Click(object sender, EventArgs e)
        {
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


        }


        //////////////////////////////////////////////////
        //ラジオボタンチェック処理                      //
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
            //ラジオボタンの初期化
            rboSearch03.Checked = true;
            rboSearch03.Visible = false;
            



        }












    }
}

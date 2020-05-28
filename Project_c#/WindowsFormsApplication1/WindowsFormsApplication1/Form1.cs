using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
                           
            //デザイナ情報の呼び出し
            InitializeComponent();
            
        }

        //////////////////////////////////////////////////
        //検索ボタン押下                                //
        //////////////////////////////////////////////////
        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            //変数定義
            DataGridViewConnect DataGridViewConnect = new DataGridViewConnect();
            DataSet dsDataset = new DataSet();
            string strSQL;
            //テキストボックスの０埋め
            if (txtOrderMSNo.Text.Trim() != "")
            {
                txtOrderMSNo.Text = txtOrderMSNo.Text.PadLeft(3, '0');
                            }

            //DB接続
            DBConnect.DBConnect_Main();
            //SQL生成
            // 実行するSQLの準備
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += "* ";
            strSQL += "FROM ";
            strSQL += "ORDER_TBL ";
            if (txtOrderMSNo.Text.Trim() != ""){
                strSQL += "WHERE ";
                strSQL += "受注NO = '" + txtOrderMSNo.Text.Trim() + "' ";
            }

            //SQLを渡して実行、DataSetを返す
            dsDataset = DataGridViewConnect.DataGridViewConnect1(strSQL);
            //DataGridViewにバインド
            if (dsDataset != null){
                DataGridView1.DataSource = dsDataset.Tables[0];
            }else{
                DataGridView1.DataSource = null ;

            }

            //後処理
            //クローズ処理
            DBConnect.DBConnect_Close(DBConnect.cn);
               
        }


    }
}

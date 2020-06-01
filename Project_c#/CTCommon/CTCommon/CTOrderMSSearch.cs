using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTCommon
{
    public partial class CTOrderMSSearch : Form
    {

        public string ReturnValue;       //元のフォームに返す戻り値


        public CTOrderMSSearch()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////
        //ファンクションキー押下処理                    //
        //////////////////////////////////////////////////
        private void CTOrderMSSearch_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch(e.KeyCode){
                case Keys.F1:
                    Search_Main();
                    break;
                case Keys.F2:
                    this.Close();
                    break;
            }


        }

        //////////////////////////////////////////////////
        //検索ボタン押下処理                            //
        //////////////////////////////////////////////////
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search_Main();

        }


        //////////////////////////////////////////////////
        //閉じるボタン押下処理                          //
        //////////////////////////////////////////////////
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main()
        {
            //変数定義
            DataGridViewConnect DataGridViewConnect = new DataGridViewConnect();
            DataSet dsDataset = new DataSet();
            string strSQL;
            if (txtOrderMSNo.Text.Trim() != ""){
                txtOrderMSNo.Text = txtOrderMSNo.Text.PadLeft(3, '0');
            }

            //DB接続
            DBConnect.DBConect_Main();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 受注先NO, ";
            strSQL += " 受注先名 ";
            strSQL += "FROM ";
            strSQL += " ORDER_MS ";
            if (txtOrderMSNo.Text.Trim() != ""){
                strSQL += "WHERE ";
                strSQL += " 受注先NO = '" + txtOrderMSNo.Text.Trim() +"' ";
            }
            //SQLを渡し、Datasetを取得する
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            
            //Datasetをバインド
            if (dsDataset != null){
                DataGridView1.DataSource = dsDataset.Tables[0];
            }else{
                DataGridView1.DataSource = null;
            }

            //トリム処理
            for (int i = 0; i <= DataGridView1.RowCount - 1; i++){
                for (int y = 0; y <= DataGridView1.ColumnCount - 1; y++){
                    DataGridView1[y, i].Value = DataGridView1[y, i].Value.ToString().Trim();
                }
            }

            //後処理
            //クローズ処理
            DBConnect.DBConnect_Close(DBConnect.cn);
            
        }

        //////////////////////////////////////////////////
        //DataGridView1_ダブルクリック処理              //
        //////////////////////////////////////////////////
        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e){
            //行番号を取得
            int intRow = e.RowIndex;
            //セル値を取得
            string strOrderNO = this.DataGridView1[0, intRow].Value.ToString();
            string strOrderName = this.DataGridView1[0, intRow].Value.ToString();
            //返却用の値を設定
            this.ReturnValue = strOrderNO;
            this.Close();

        }


        //////////////////////////////////////////////////
        //値返却用フォーム                              //
        //////////////////////////////////////////////////
        public string ShowMiniForm()
        {
            CTOrderMSSearch CTOrderMSSearch = new CTOrderMSSearch();
            CTOrderMSSearch.ShowDialog();
            string receiveText = CTOrderMSSearch.ReturnValue;
            CTOrderMSSearch.Dispose();
            return receiveText;
        }









    }
}

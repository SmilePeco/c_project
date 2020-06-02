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
    public partial class CTWorkProcessMSSearch : Form
    {

        public string ReturnValue;       //元のフォームに返す戻り値
        

        public CTWorkProcessMSSearch()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CTWorkProcessMSSearch_KeyDown(object sender, KeyEventArgs e){
            switch (e.KeyCode){
                case Keys.F1:
                    Search_Main();
                    break;
                case Keys.F2:
                    this.Close();
                    break;


            }

        }


        //////////////////////////////////////////////////
        //ファンクションキーボタン押下処理              //
        //////////////////////////////////////////////////
        private void button_Click(object sender, EventArgs e)
        {
            //F1:検索ボタン押下
            if (sender.Equals(this.btnSearch)){
                Search_Main();
            }

            //F2:終了ボタン押下
            if (sender.Equals(this.btnEnd)){
                this.Close();
            }

        }

        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        public void Search_Main(){

            //変数定義
            DataGridViewConnect DataGridViewConnect = new DataGridViewConnect();
            DataSet dsDataset = new DataSet();
            string strSQL;
            if (txtWorkProcessMSNo.Text.Trim() != ""){
                txtWorkProcessMSNo.Text = txtWorkProcessMSNo.Text.PadLeft(3, '0');
            }

            //DB接続
            DBConnect.DBConect_Main();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " A.作業工程NO, ";
            strSQL += "  A.作業工程名, ";
            strSQL += " B.製品NO, ";
            strSQL += "  B.製品名 ";
            strSQL += "FROM ";
            strSQL += " WORKPROCESS_MS A, ";
            strSQL += " ITEM_MS B ";
            strSQL += "WHERE ";
            strSQL += "    A.製品NO = B.製品NO ";
            if (txtWorkProcessMSNo.Text.Trim() != ""){
                strSQL += "AND A.作業工程NO = '" + txtWorkProcessMSNo.Text.Trim() +"' ";
            }
            //SQLを渡し、DataSetを取得する
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            //DataSetをバインド
            if (dsDataset != null)
            {
                DataGridView1.DataSource = dsDataset.Tables[0];

            }
            else
            {
                DataGridView1.DataSource = null;
            }

            //トリム処理
            for (int i = 0; i <= DataGridView1.RowCount - 1; i++)
            {
                for (int y = 0; y <= DataGridView1.ColumnCount - 1; y++)
                {
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
        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //行番号を取得
            int intRow = e.RowIndex;
            //セル値を取得
            string strWorkProcessNO = DataGridView1[0, intRow].Value.ToString().Trim();
            //返却用の値を取得
            this.ReturnValue = strWorkProcessNO;
            this.Close();

        }

        //////////////////////////////////////////////////
        //値返却用フォーム                              //
        //////////////////////////////////////////////////
        public string ShowminiForm(){
            CTWorkProcessMSSearch CTWorkProcessMSSearch = new CTWorkProcessMSSearch();
            CTWorkProcessMSSearch.ShowDialog();
            string receiveText = CTWorkProcessMSSearch.ReturnValue;
            CTWorkProcessMSSearch.Dispose();
            return receiveText;

        }






    }
}

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

namespace CTCommon
{
    public partial class CTProcessMSSearch : Form
    {

        public string strSQL;
        public string strReturnValue;

        public CTProcessMSSearch()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CTProcessMSSearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode){
                case Keys.F1:
                    //検索処理
                    Search_Main();
                    break;
                
                case Keys.F2:
                    //終了処理
                    this.Close();
                    break;

            }

        }

        //////////////////////////////////////////////////
        //テキストボックス 数値のみ入力可能             //
        //////////////////////////////////////////////////
        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }


        //////////////////////////////////////////////////
        //ボタン押下処理                               //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(this.btnSearch)) { Search_Main(); } //検索処理
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了処理

        }

        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main()
        {
            //０埋め処理
            if (txtProcessMSNo.Text.Trim() != "") { txtProcessMSNo.Text = txtProcessMSNo.Text.PadLeft(3, '0'); }
           

            //変数定義
            DataSet dsDataset = new DataSet();
            DataGridViewConnect DataGridViewConnect = new DataGridViewConnect();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 工程NO, ";
            strSQL += " 工程名 ";
            strSQL += "FROM ";
            strSQL += " PROCESS_MS ";
            //空欄の場合は全件検索
            //空欄以外は入力値を検索条件とする
            if (txtProcessMSNo.Text.Trim() != ""){
                strSQL += "WHERE ";
                strSQL += " 工程NO = '" + txtProcessMSNo.Text.Trim() + "' ";

            }
            //DataSet取得
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            //DataSetバインド
            if (dsDataset != null){
                DataGridView1.DataSource = dsDataset.Tables[0];

            }else{
                DataGridView1.DataSource = null;

            }

            //トリム処理
            for(int i = 0; i <= DataGridView1.RowCount -1; i++){
                for (int y = 0; y <= DataGridView1.ColumnCount - 1; y++){
                    DataGridView1[y, i].Value = DataGridView1[y, i].Value.ToString().Trim();
                }

            }

            //ヘッダーとすべてのセルの内容に合わせて、列の幅を自動調整する
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //クローズ処理
            CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);



        }

        //////////////////////////////////////////////////
        //DataGridView ダブルクリック処理               //
        //////////////////////////////////////////////////
        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //現在行番号を取得
            int intRow = e.RowIndex;
            //行の値を取得
            string strProcessNo = DataGridView1[0, intRow].Value.ToString();
            //行の値をかえす
            strReturnValue = strProcessNo;
            this.Close();

        }

        //////////////////////////////////////////////////
        //値返却用フォーム                              //
        //////////////////////////////////////////////////
        public string Showminiform()
        {
            //変数定義
            CTProcessMSSearch frmSearch = new CTProcessMSSearch();
            frmSearch.ShowDialog();
            string strReturnValue2 = strReturnValue;
            return strReturnValue2;

        }










    }
}

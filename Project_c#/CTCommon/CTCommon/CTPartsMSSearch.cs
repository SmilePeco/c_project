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
    public partial class CTPartsMSSearch : Form
    {

        public string strSQL; //SQL生成用
        public string strReturnValue;

        public CTPartsMSSearch()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CTPartsMSSearch_KeyDown(object sender, KeyEventArgs e)
        {
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
        //ボタン押下処理                                //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(this.btnSearch)) { Search_Main(); } //検索処理
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了処理


        }


        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main(){

            //変数定義
            DataSet dsDataset = new DataSet();
            DataGridViewConnect DataGridViewConnect = new DataGridViewConnect();

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 部品No, ";
            strSQL += " 部品コード, ";
            strSQL += " 部品名 ";
            strSQL += "FROM ";
            strSQL += " PARTS_MS ";
            strSQL += "WHERE ";
            strSQL += " 部品コード LIKE '" + txtPartsCode.Text.Trim() + "%' ";
            strSQL += "ORDER BY ";
            strSQL += " 部品No ";
            //Datasetを取得
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            //Datasetをバインド
            if (dsDataset != null) { DataGridView1.DataSource = dsDataset.Tables[0]; }
            else { DataGridView1.DataSource = null; }
            //トリム処理
            for (int i = 0; i <= DataGridView1.RowCount - 1; i++){
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
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //現在行を取得
            int intRow = e.RowIndex;
            //行の値を取得
            string strPartsCode = DataGridView1[1, intRow].Value.ToString().Trim();
            //値を返す
            strReturnValue = strPartsCode;
            this.Close();

        }

        //////////////////////////////////////////////////
        //値返却用フォーム                              //
        //////////////////////////////////////////////////
        public string Showminiform()
        {
            CTPartsMSSearch frmSearch = new CTPartsMSSearch();
            frmSearch.ShowDialog();
            //ダブルクリックした値を返す
            string strReciveValue = frmSearch.strReturnValue;
            frmSearch.Dispose();
            return strReciveValue;
        }






    }
}

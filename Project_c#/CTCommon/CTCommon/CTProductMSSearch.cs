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
    public partial class CTProductMSSearch : Form
    {

        public string strSQL;
        public string strReturnValue;

        public CTProductMSSearch()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CTProductMSSearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    Search_Main();
                    break;

                case Keys.F2:
                    this.Close();
                    break;
            }



        }


        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main()
        {
            //変数定義
            DataSet dsDataset = new DataSet();
            DataGridViewConnect DataGridViewConnect = new DataGridViewConnect();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 製品コード, ";
            strSQL += " 製品名 ";
            strSQL += "FROM ";
            strSQL += " PRODUCT_MS ";
            strSQL += "WHERE ";
            strSQL += " 製品コード LIKE 'S%' ";
            //DataSet取得
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
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
            //現在行番号の取得
            int intRow = e.RowIndex;
            //行の値を取得
            string strProductNo = DataGridView1[0, intRow].Value.ToString();
            //値を返す
            strReturnValue = strProductNo;
            this.Close();

        }


        //////////////////////////////////////////////////
        //値返却用フォーム                              //
        //////////////////////////////////////////////////
        public string Showminifrom()
        {
            //変数定義
            CTProductMSSearch frmSearch = new CTProductMSSearch();
            frmSearch.ShowDialog();
            string strReciveValue = frmSearch.strReturnValue;
            frmSearch.Dispose();
            return strReciveValue;
        }











    }
}

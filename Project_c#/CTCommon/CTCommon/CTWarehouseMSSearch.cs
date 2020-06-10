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
    public partial class CTWarehouseMSSearch : Form
    {
        public string strSQL;
        public string strReturnValue;


        public CTWarehouseMSSearch()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CTWarehouseMSSearch_Load(object sender, EventArgs e)
        {
            //検索メイン処理
            Search_Main();

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
            strSQL += " 倉庫NO, ";
            strSQL += " 倉庫名 ";
            strSQL += "FROM ";
            strSQL += " WAREHOUSE_MS ";
            //SQL実行
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            //DataSetバインド
            if (dsDataset != null){
                dataGridView1.DataSource = dsDataset.Tables[0];
                //トリム処理
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++){
                    for (int y = 0; y <= dataGridView1.ColumnCount - 1; y++){
                        dataGridView1[y, i].Value = dataGridView1[y, i].Value.ToString().Trim();
                    }
                }

                //ヘッダーとすべてのセルの内容に合わせて、列の幅を自動調整する
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }else{
                dataGridView1.DataSource = null;

            }

            //クローズ処理
            CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);

        }

        //////////////////////////////////////////////////
        //DataGridView ダブルクリック処理               //
        //////////////////////////////////////////////////
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //現在行番号を取得
            int intRow = e.RowIndex;
            //行の値を取得
            string strWarehouseNo = dataGridView1[0, intRow].Value.ToString().Trim();
            //値を返す
            strReturnValue = strWarehouseNo;
            this.Close();

        }

        //////////////////////////////////////////////////
        //値返却用処理フォーム                          //
        //////////////////////////////////////////////////
        public string Showminiform(){
            //変数定義
            CTWarehouseMSSearch frmSearch = new CTWarehouseMSSearch();
            frmSearch.ShowDialog();
            string strReciveValue = frmSearch.strReturnValue;
            frmSearch.Dispose();
            return strReciveValue;



        }






    }
}

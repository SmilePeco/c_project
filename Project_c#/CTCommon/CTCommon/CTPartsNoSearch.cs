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
    public partial class CTPartsNoSearch : Form
    {
        public CTPartsNoSearch()
        {
            InitializeComponent();
        }

        public string strSQl;
        public string strReturnValue;


        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CTPartsNoSearch_Load(object sender, EventArgs e){
            //表示処理
            txtPartsCode.Enabled = false;

            //検索メイン処理
            Search_Main();

        }

        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main(){
            //変数定義
            DataGridViewConnect DataGridViewConnect = new DataGridViewConnect();
            DataSet dsDataset = new DataSet();
            //SQL発行
            strSQl = "";
            strSQl += "SELECT ";
            strSQl += " 部品登録NO, ";
            strSQl += " 部品コード, ";
            strSQl += " 登録数 ";
            strSQl += "FROM ";
            strSQl += " PARTS_TBL ";
            strSQl += "WHERE ";
            strSQl += "    部品コード = '" + txtPartsCode.Text + "' ";
            strSQl += "AND 登録済フラグ = 1 ";
            //SQL実行
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQl);
            //Datasetをバインドする
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


        }

        //////////////////////////////////////////////////
        //DataGridView ダブルクリック処理               //
        //////////////////////////////////////////////////
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){
            //現在に行番号を取得
            int intRow = e.RowIndex;
            //行の値の取得
            string strPartsNo = dataGridView1[0, intRow].Value.ToString();
            //値をかえす
            strReturnValue = strPartsNo;
            this.Close();


        }


        //////////////////////////////////////////////////
        //値返却用フォーム                              //
        //////////////////////////////////////////////////
        public string Showminiform(string strPartsCode){
            //変数定義
            CTPartsNoSearch frmSearch = new CTPartsNoSearch();
            frmSearch.txtPartsCode.Text = strPartsCode;
            frmSearch.ShowDialog();
            string strReturnValue2 = frmSearch.strReturnValue;
            return strReturnValue2;

        }





        
    }
}

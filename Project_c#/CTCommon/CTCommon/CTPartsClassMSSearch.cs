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
    public partial class CTPartsClassMSSearch : Form
    {

        public string strSQL;
        public string strReturnValue;


        public CTPartsClassMSSearch()
        {
            InitializeComponent();
        }



        ///////////////////////////////////////////////////
        //Load処理                                       //
        //////////////////////////////////////////////////
        private void CTPartsClassMSSearch_Load(object sender, EventArgs e){
            //検索メイン処理
            PartsClass_Search();

        }

        ///////////////////////////////////////////////////
        //ファンクションキー押下処理                     //
        //////////////////////////////////////////////////
        private void CTPartsClassMSSearch_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e){
            switch (e.KeyCode){
                case Keys.F1:
                    this.Close();
                    break;
            }

        }


        ///////////////////////////////////////////////////
        //ボタン押下処理                                //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e){
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了ボタン押下処理

        }


        ///////////////////////////////////////////////////
        //検索メイン処理                                 //
        //////////////////////////////////////////////////
        public void PartsClass_Search() { 
            //変数定義
            DataSet dsDataset = new DataSet();
            DataGridViewConnect DataGridViewConnect = new DataGridViewConnect();

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += "  部品分類NO AS NO, ";
            strSQL += "  部品分類名 ";
            strSQL += "FROM ";
            strSQL += " PARTS_CLASS_MS ";
            //Dataset生成
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            //DataSetバインド
            if (dsDataset != null) {
                dataGridView1.DataSource = dsDataset.Tables[0];
            }else{
                dataGridView1.DataSource = null;

            }

            //トリム処理
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++){
                for (int y = 0; y <= dataGridView1.ColumnCount - 1; y++){
                    dataGridView1[y, i].Value = dataGridView1[y, i].Value.ToString().Trim();
                }
            }

            //ヘッダーとすべてのセルの内容に合わせて、列の幅を自動調整する
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //クローズ処理
            CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);

        }



        //////////////////////////////////////////////////
        //DataGridView1 ダブルクリック処理              //
        //////////////////////////////////////////////////
        private void dataGridView1_CellContentDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            //現在行番号を取得
            int intRow = e.RowIndex;
            //値を取得
            string strPartsClassNo = dataGridView1[0, intRow].Value.ToString();
            //値を変数に代入
            strReturnValue = strPartsClassNo;
            this.Close();
        }



        //////////////////////////////////////////////////
        //値返却用フォーム                              //
        //////////////////////////////////////////////////
        public string Showminiform(){
            //変数定義
            CTPartsClassMSSearch frmParts = new CTPartsClassMSSearch();
            //画面を開く
            frmParts.ShowDialog();
            string strReciveValue = frmParts.strReturnValue;
            frmParts.Dispose();
            return strReciveValue;

        }
    }
}

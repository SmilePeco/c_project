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
    public partial class CTWorklineMSSearch : Form
    {
        public string strReceiveValue = "";
        public string strReturnValue = "";

        public CTWorklineMSSearch()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CTWorklineMSSearch_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();

            //検索メイン処理
            Search_main();
            

        }

        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CTWorklineMSSearch_KeyDown(object sender, KeyEventArgs e){
            //終了処理
            switch (e.KeyCode){ case Keys.F1: this.Close(); break; }
        }

        //////////////////////////////////////////////////
        //ボタン押下処理                                //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(this.btnEnd)) { this.Close(); }
        }





        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        public void Search_main(){

            //変数定義
            string strSQL;
            DataGridViewConnect DataGridViewConnect = new DataGridViewConnect();
            try{
                //SQL発行
                strSQL = "";
                strSQL += "SELECT ";
                strSQL += " 作業ラインNO, ";
                strSQL += " 作業ライン名 ";
                strSQL += "FROM ";
                strSQL += " WORKLINE_MS ";
                strSQL += "WHERE ";
                strSQL += " 製品コード = '" + txtProductCode.Text + "' ";
                //SQL実行
                DataSet dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
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


            }catch (Exception e){
                MessageBox.Show(e.Message);

            }finally{
                //クローズ処理
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
            }
        }


        //////////////////////////////////////////////////
        //DataGriView ダブルクリック処理                //
        //////////////////////////////////////////////////
        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //現在行番号を取得
            int intRow = e.RowIndex;
            //行の値を取得
            string strWorklineNo = DataGridView1[0, intRow].Value.ToString().Trim();
            //値を返す
            strReturnValue = strWorklineNo;
            this.Close();

        }

        //////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        private void smClear()
        {
            txtProductCode.Enabled = false;
        }


        //////////////////////////////////////////////////
        //値返却用フォーム                              //
        //////////////////////////////////////////////////
        public string ShowminiForm(string strValue)
        {
            CTWorklineMSSearch CTWorklineMSSearch = new CTWorklineMSSearch();
            CTWorklineMSSearch.strReceiveValue = strValue;
            CTWorklineMSSearch.txtProductCode.Text = CTWorklineMSSearch.strReceiveValue;
            CTWorklineMSSearch.ShowDialog();
            string strReturnValue2 = CTWorklineMSSearch.strReturnValue;
            CTWorklineMSSearch.Dispose();
            return strReturnValue2;

        }
















    }
}

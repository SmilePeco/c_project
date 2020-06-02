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
    public partial class CTHumanMSSearch : Form
    {

        public string ReturnValue;       //元のフォームに返す戻り値

        public CTHumanMSSearch()
        {
            InitializeComponent();
        }


        //////////////////////////////////////////////////
        //ロード処理                                    //
        //////////////////////////////////////////////////
        private void CTHumanMSSearch_Load(object sender, EventArgs e)
        {
            //検索処理
            Search_Main();

        }

        //////////////////////////////////////////////////
        //ファンクションキー押下処理                    //
        //////////////////////////////////////////////////
        private void CTHumanMSSearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    this.Close();
                    break;
            }

        }

        
        //////////////////////////////////////////////////
        //ファンクションキーボタン押下処理              //
        //////////////////////////////////////////////////
        private void button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(this.btnEnd))
            {
                this.Close();
            }

        }

        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        public void Search_Main()
        {
            //変数定義
            DataGridViewConnect DataGridViewConnect = new DataGridViewConnect();
            DataSet dsDataset = new DataSet();
            string strSQL;
            //DB接続
            DBConnect.DBConect_Main();
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 社員NO, ";
            strSQL += " 名前 ";
            strSQL += "FROM ";
            strSQL += "  HUMAN_MS ";
            strSQL += "ORDER BY ";
            strSQL += " 社員NO ";
            //SQLを渡し、Datasetを取得する
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            //DataSetをバインド
            if (dsDataset != null)
            {
                dataGridView1.DataSource = dsDataset.Tables[0];
            }
            else
            {
                dataGridView1.DataSource = null;

            }

            //トリム処理
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int y = 0; y < dataGridView1.ColumnCount - 1; y++)
                {

                        dataGridView1[y, i].Value = dataGridView1[y, i].Value.ToString().Trim();
                }
            }

            //後処理
            //クローズ処理
            DBConnect.DBConnect_Close(DBConnect.cn);


        }

        //////////////////////////////////////////////////
        //DataGridView1_ダブルクリック処理              //
        //////////////////////////////////////////////////
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //現在行の取得
            int intRow = e.RowIndex;
            //セル値の取得
            string strHumanNo = dataGridView1[1, intRow].Value.ToString().Trim();
            //返却用の値を設定
            this.ReturnValue = strHumanNo;
            this.Close();

        }

        //////////////////////////////////////////////////
        //値返却用フォーム                              //
        //////////////////////////////////////////////////
        public string ShowminiForm()
        {
            CTHumanMSSearch CTHumanMSSearch = new CTHumanMSSearch();
            CTHumanMSSearch.ShowDialog();
            string receiveText = CTHumanMSSearch.ReturnValue;
            CTHumanMSSearch.Dispose();
            return receiveText;
        }







    }
}

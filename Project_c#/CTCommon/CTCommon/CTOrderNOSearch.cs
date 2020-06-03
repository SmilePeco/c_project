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
    public partial class CTOrderNOSearch : Form
    {
        public string ReturnValue;       //元のフォームに返す戻り値
        public string strOrderMSNo;       //元のフォーム受け取る値（受注先NO）
        public string strDateTimeFrom;       //元のフォーム受け取る値（受注先NO）
        public string strDateTimeTo;       //元のフォーム受け取る値（受注先NO）



        public CTOrderNOSearch()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CTOrderNOSearch_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();
            //検索処理
            Search_Main();

        }


        ///////////////////////////////////////////////////
        //ファンクションキー押下処理                    //
        //////////////////////////////////////////////////
        private void CTOrderNOSearch_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode){
                case Keys.F1:
                    //終了処理
                    this.Close();
                    break;
            }
        }

        ///////////////////////////////////////////////////
        //ボタン押下処理                                //
        //////////////////////////////////////////////////
        private void button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(this.btnEnd)){
                //終了処理
                this.Close();
            }
        }

        ///////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        private void smClear()
        {
            //テキストボックスの初期化
            txtOrderMSNo.Enabled = false;
            //日付の初期化
            dtpOrderDateFrom.Enabled = false;
            dtpOrderDateTo.Enabled = false;
            //受け取った値の代入
            txtOrderMSNo.Text = this.strOrderMSNo;
            dtpOrderDateFrom.Text = this.strDateTimeFrom;
            dtpOrderDateTo.Text = this.strDateTimeTo;

        }

        ///////////////////////////////////////////////////
        //検索処理                                      //
        //////////////////////////////////////////////////
        private void Search_Main()
        {
            //変数定義
            DataGridViewConnect DataGridViewConnect = new DataGridViewConnect();
            DataSet dsDataset = new DataSet();
            string strSQL;
            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " A.受注NO, ";
            strSQL += " A.受注日, ";
            strSQL += " A.受注先NO, ";
            strSQL += " B.受注先名, ";
            strSQL += " A.受注数, ";
            strSQL += " A.作業工程NO, ";
            strSQL += " C.作業工程名 ";
            strSQL += "FROM ";
            strSQL += " ORDER_TBL A, ";
            strSQL += " ORDER_MS B, ";
            strSQL += " WORKPROCESS_MS C ";
            strSQL += "WHERE ";
            strSQL += "    A.受注先NO = '" + txtOrderMSNo.Text + "' ";
            strSQL += "AND A.受注先NO = B.受注先NO ";
            strSQL += "AND A.作業工程NO = C.作業工程NO ";
            strSQL += "AND A.受注チェックフラグ = '0' ";
            strSQL += "AND A.受注日 BETWEEN ";
            strSQL += "    '" + dtpOrderDateFrom.Text + "' AND '" + dtpOrderDateTo.Text + "' ";
            strSQL += "ORDER BY ";
            strSQL += " A.受注NO ";
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
                for (int y = 0; y <= DataGridView1.ColumnCount - 1; y++) {
                    DataGridView1[y, i].Value = DataGridView1[y, i].Value.ToString().Trim();

                }
            }

            //後処理
            //クローズ処理
            DBConnect.DBConnect_Close(DBConnect.cn);
            
        }


        //////////////////////////////////////////////////
        //DataGridView ダブルクリック処理               //
        //////////////////////////////////////////////////
        private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //現在行の取得
            int intRow = e.RowIndex;
            //セル値の取得
            string strOrderNo = DataGridView1[0, intRow].Value.ToString();
            //元フォームに値を返す
            this.ReturnValue = strOrderNo;
            this.Close();

        }


        //////////////////////////////////////////////////
        //値返却用フォーム                              //
        //////////////////////////////////////////////////
        public string ShowminiForm(string strOrderMSNo, string strDateTimeFrom, string strDateTimeTo)
        {
            CTOrderNOSearch CTOrderNOSearch = new CTOrderNOSearch();
            //受け取った値の代入
            CTOrderNOSearch.strOrderMSNo = strOrderMSNo;
            CTOrderNOSearch.strDateTimeFrom = strDateTimeFrom;
            CTOrderNOSearch.strDateTimeTo = strDateTimeTo;
            CTOrderNOSearch.ShowDialog();
            //値を返却
            string strReciveText = CTOrderNOSearch.ReturnValue;
            CTOrderNOSearch.Dispose();
            return strReciveText;




        }








    }
}

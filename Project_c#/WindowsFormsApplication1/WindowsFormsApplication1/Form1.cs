using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPro
{
    public partial class Form1 : Form
    {
        //Datasetの設定
        var dsDataset = new DataSet();

        public Form1()
        {


                
            //デザイナ情報の呼び出し
            InitializeComponent();
            
        }





        //////////////////////////////////////////////////
        //検索ボタン押下                                //
        //////////////////////////////////////////////////
        private void btnSearch_Click(object sender, EventArgs e)
        {
           //DB接続
            DBConnect.DBConnect_Main();
            Program.ShipmentMS_MainSearch();


           

            //DataGridViewの設定
            this.DataGridView1.DataSource = Program.

        }





        

    }
}

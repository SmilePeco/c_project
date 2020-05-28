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
using System.Configuration;

namespace TestPro
{

        static class Program
    {




        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBox.Show("テスト。 \r\nテスト。", "タイトル？", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           

       }


        //////////////////////////////////////////////////
        //検索処理                                      //
        //////////////////////////////////////////////////
        public static void ShipmentMS_Search()
        {


        }


        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        public static void ShipmentMS_MainSearch()
        {
            //変数定義
            SqlConnection cn = null;
            SqlCommand cd = null;
            string strSQL = null;
            SqlDataReader drReader;
            Form1 frmForm1 = new Form1();

            try
            {
                //DB接続
                cn = DBConnect.cn;
                cn.Open();

                // 実行するSQLの準備
                strSQL = @"
                                 SELECT
                                   *
                                 FROM
                                   ORDER_TBL
                                ";

                cd = new SqlCommand(strSQL, cn);
                drReader = cd.ExecuteReader();
                if (drReader.HasRows){
                    drReader.Close();

                    //Datasetの設定
                    var dsDataset = new DataSet();
                    //DataAdapterの設定
                    var daDataAdapter = new SqlDataAdapter(strSQL, cn);
                    daDataAdapter.Fill(dsDataset);


                    
                    

                }
                else
                {

                }




            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            finally
            {
                cn.Dispose();
                cn.Close();
            
            }



        }





    }
}

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


namespace CTCommon
{
    public class DataGridViewConnect
    {

        public DataSet DataGridViewConnect_Main(string strSQL)
        {

            //変数定義
            SqlConnection cn = null;
            SqlCommand cd = null;
            SqlDataReader dtReader;
            //DB接続
            cn = DBConnect.cn;
            cn.Open();
            //SQL実行
            cd = new SqlCommand(strSQL, cn);
            dtReader = cd.ExecuteReader();
            //読み込んだdtReaderが存在するか確認
            if (dtReader.HasRows)
            {
                dtReader.Close();

                //DataAdapterの生成
                var daDataAdapter = new SqlDataAdapter(strSQL, cn);
                //Dataset生成
                DataSet dsDataset = new DataSet();

                daDataAdapter.Fill(dsDataset);

                //クローズ処理
                cn.Close();
                
                return dsDataset;



            }else{
                //クローズ処理
                cn.Close();
                return null;


            }




        }
    }
}

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
    class DataGridViewConnect
    {
        

        public DataSet DataGridViewConnect1(string strSQL)
        {

            //変数定義
            SqlConnection cn = null;
            SqlCommand cd = null;
            SqlDataReader drReader;


                //DB接続
                cn = DBConnect.cn;
                cn.Open();


                cd = new SqlCommand(strSQL, cn);
                drReader = cd.ExecuteReader();
                if (drReader.HasRows)
                {
                    drReader.Close();

                    //Datasetの設定
                    var dsDataset = new DataSet();
                    //DataAdapterの設定
                    var daDataAdapter = new SqlDataAdapter(strSQL, cn);
                    daDataAdapter.Fill(dsDataset);

                    return dsDataset;
                }else{
                    return null;
                }

                }
    }



    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace CT003_社員マスタメンテナンス
{
    class SearchClass
    {

        public string strSQL; //SQL発行用


        //////////////////////////////////////////////////
        //ログインID 連番取得処理                       //
        //////////////////////////////////////////////////
        public int Search_SerialNumber(){
            //変数定義
            SqlDataReader dtReader;
            SqlCommand cd; 
            int intReturn = 0;

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " COALESCE(MAX(社員NO), 0) AS 社員NO ";
            strSQL += "FROM ";
            strSQL += " HUMAN_MS ";
            //SQL実行
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //dtReader読込
            if (dtReader.HasRows){
                if (dtReader.Read()){
                    intReturn = int.Parse(dtReader["社員NO"].ToString());　//連番取得
                }
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                intReturn += 1;
                return intReturn;

            }else{
                //ありえないが、１で返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                intReturn += 1;
                return intReturn;

            }
           
            



        }

        //////////////////////////////////////////////////
        //ログインID 存在チェック処理                   //
        //////////////////////////////////////////////////
        public DataSet Search_Main(string strHumanNo)
        {
            //変数定義
            CTCommon.DataGridViewConnect DataGridViewConnect = new CTCommon.DataGridViewConnect();
            DataSet dsDataset;

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 名前 ";
            strSQL += "FROM ";
            strSQL += " HUMAN_MS ";
            strSQL += "WHERE ";
            strSQL += " 名前 = '" + strHumanNo + "' ";
            //SQL実行
            dsDataset = DataGridViewConnect.DataGridViewConnect_Main(strSQL);
            //Datasetを返す
            return dsDataset;
            
        }

        //////////////////////////////////////////////////
        //ログインID 社員NO取得処理                     //
        //////////////////////////////////////////////////
        public string Search_HumanNo(string strHumanNo)
        {
            //変数定義
            SqlDataReader dtReader;
            SqlCommand cd = null;
            string strReturn = ""; //戻り値

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 社員NO ";
            strSQL += "FROM ";
            strSQL += " HUMAN_MS ";
            strSQL += "WHERE ";
            strSQL += " 名前 = '" + strHumanNo + "' ";
            //DB接続
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //DataReader読込
            if (dtReader.HasRows){
                while (dtReader.Read()){
                    strReturn = dtReader["社員NO"].ToString().Trim();
                }

                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturn;
            }else{
                //ありえないが、空白を返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturn;
            }

        }



        //////////////////////////////////////////////////
        //ログインID ログインID取得処理                 //
        //////////////////////////////////////////////////
        public string Search_LoginID(string strHumanNo)
        {
            //変数定義
            SqlDataReader dtReader;
            SqlCommand cd = null;
            string strReturn = ""; //戻り値

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 名前 ";
            strSQL += "FROM ";
            strSQL += " HUMAN_MS ";
            strSQL += "WHERE ";
            strSQL += " 名前 = '" + strHumanNo + "' ";
            //DB接続
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //DataReader読込
            if (dtReader.HasRows){
                while (dtReader.Read())
                {
                    strReturn = dtReader["名前"].ToString().Trim();
                }

                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturn;
            }else{
                //ありえないが、空白を返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturn;
            }

        }

        //////////////////////////////////////////////////
        //ログインID 更新担当者名取得処理               //
        //////////////////////////////////////////////////
        public string Search_HumanName(string strHumanNo)
        {
            //変数定義
            SqlDataReader dtReader;
            SqlCommand cd = null;
            string strReturn = ""; //戻り値

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 更新担当者名 ";
            strSQL += "FROM ";
            strSQL += " HUMAN_MS ";
            strSQL += "WHERE ";
            strSQL += " 名前 = '" + strHumanNo + "' ";
            //DB接続
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //DataReader読込
            if (dtReader.HasRows){
                while (dtReader.Read()){
                    strReturn = dtReader["更新担当者名"].ToString().Trim();
                }

                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturn;
            }else{
                //ありえないが、空白を返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return strReturn;
            }

        }


        //////////////////////////////////////////////////
        //ログインID 管理者フラグ取得処理               //
        //////////////////////////////////////////////////
        public int Search_AdminFLG(string strHumanNo)
        {
            //変数定義
            SqlDataReader dtReader;
            SqlCommand cd = null;
            int intReturn = 0; //戻り値

            //SQL発行
            strSQL = "";
            strSQL += "SELECT ";
            strSQL += " 管理者フラグ ";
            strSQL += "FROM ";
            strSQL += " HUMAN_MS ";
            strSQL += "WHERE ";
            strSQL += " 名前 = '" + strHumanNo + "' ";
            //DB接続
            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
            CTCommon.DBConnect.cn.Open();
            dtReader = cd.ExecuteReader();
            //DataReader読込
            if (dtReader.HasRows)
            {
                while (dtReader.Read())
                {
                    intReturn = Convert.ToInt32(dtReader["管理者フラグ"].ToString());
                }

                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return intReturn;
            }
            else
            {
                //ありえないが、空白を返す
                //クローズ処理
                dtReader.Close();
                CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                return intReturn;
            }

        }
    }
}

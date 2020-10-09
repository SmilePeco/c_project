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

namespace CT012_製品生産画面
{
    public partial class CT012 : Form
    {
        public CT012()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CT012_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();
            //増やしました
             
        }

        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CT012_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode){
                case Keys.F1:
                    //検索処理
                    if (btnSearch.Enabled == true) { Search_Main(); }
                    break;

                case Keys.F2:
                    //登録処理
                    if (btnSubmit.Enabled == true) { Submit_Main(); }
                    break;

                case Keys.F3:
                    //クリア処理
                    smClear();
                    break;

                case Keys.F4:
                    //終了処理
                    this.Close();
                    break;

            }

        }

        //////////////////////////////////////////////////
        //ボタンクリック処理                            //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e){

            if (sender.Equals(this.btnSearch)) { Search_Main(); } //検索メイン処理
            if (sender.Equals(this.btnSubmit)) { Submit_Main(); } //登録メイン処理
            if (sender.Equals(this.btnClear)) { smClear(); } //クリア処理
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了処理



            //製品コード検索ボタン押下
            if (sender.Equals(this.btnSearchProductMSSearch)){
                //変数定義
                CTCommon.CTProductMSSearch frmSearch = new CTCommon.CTProductMSSearch();
                 txtSearchProductCode.Text =  frmSearch.Showminiform();
                //製品名取得
                 CTCommon.NameSubmit NameSubmit = new CTCommon.NameSubmit();
                 lblSearchProductName.Text = NameSubmit.ProductName_Submit(txtSearchProductCode.Text);
            }

            //更新担当者ボタン押下
            if (sender.Equals(this.btnHumanMSSearch)){
                //変数定義
                CTCommon.CTHumanMSSearch frmSearch = new CTCommon.CTHumanMSSearch();
                txtHumanMSNo.Text = frmSearch.ShowminiForm();

            }


            //使用部品１検索ボタン押下
            if (sender.Equals(this.btnInputPartsMSSearch1))
            {
                //変数定義
                CTCommon.CTPartsNoSearch frmSearch = new CTCommon.CTPartsNoSearch();
                SearchClass SearchClass = new SearchClass();
                string strPartsNo1 = frmSearch.Showminiform(txtInputPartsCode1.Text);
                if ((strPartsNo1 != "") && (strPartsNo1 != null)){
                    lblOutputPartsNo1.Text = strPartsNo1;

                    //登録数の取得
                    string strPartsNumber1 = SearchClass.Search_OutputPartsNumber(lblOutputPartsNo1.Text);
                    txtOutputPartsNumber1.Text = strPartsNumber1;
                    //表示設定
                    lblInputStatus1.Text = "設定済";
                    lblInputPartsNo1.Text = lblOutputPartsNo1.Text;

                }
 
            }

            //使用部品２検索ボタン押下
            if (sender.Equals(this.btnInputPartsMSSearch2))
            {
                //変数定義
                CTCommon.CTPartsNoSearch frmSearch = new CTCommon.CTPartsNoSearch();
                SearchClass SearchClass = new SearchClass();
                string strPartsNo2 = frmSearch.Showminiform(txtInputPartsCode2.Text);
                if ((strPartsNo2 != "") && (strPartsNo2 != null)){
                    lblOutputPartsNo2.Text = strPartsNo2;
                    //登録数の取得
                    string strPartsNumber2 = SearchClass.Search_OutputPartsNumber(lblOutputPartsNo2.Text);
                    txtOutputPartsNumber2.Text = strPartsNumber2;
                    //表示設定
                    lblInputStatus2.Text = "設定済";
                    lblInputPartsNo2.Text = lblOutputPartsNo2.Text;
                }
            }

            //使用部品３検索ボタン押下
            if (sender.Equals(this.btnInputPartsMSSearch3))
            {
                //変数定義
                CTCommon.CTPartsNoSearch frmSearch = new CTCommon.CTPartsNoSearch();
                SearchClass SearchClass = new SearchClass();
                string strPartsNo3 = frmSearch.Showminiform(txtInputPartsCode3.Text);
                if ((strPartsNo3 != "") && (strPartsNo3 != null)){
                    lblOutputPartsNo3.Text = strPartsNo3;
                    //登録数の取得
                    string strPartsNumber3 = SearchClass.Search_OutputPartsNumber(lblOutputPartsNo3.Text);
                    txtOutputPartsNumber3.Text = strPartsNumber3;
                    //表示設定
                    lblInputStatus3.Text = "設定済";
                    lblInputPartsNo3.Text = lblOutputPartsNo3.Text;
                }
            }



        }


        //////////////////////////////////////////////////
        //テキストボックス 数値のみ入力可能 制御処理    //
        //////////////////////////////////////////////////
        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        //////////////////////////////////////////////////
        //生産数 Leave処理                              //
        //////////////////////////////////////////////////
        private void txtSubmitNumber_Leave(object sender, EventArgs e)
        {
            ////生産数からフォーカスが外れたときは、使用数を再計算する
            //空の場合は計算しない
            if (txtSubmitNumber.Text.Trim() != ""){
                if (lblOutputConsumeNumber1.Text != ""){ //使用数１の計算
                    int intValue = Convert.ToInt32(lblOutputOriginConsumeNumber1.Text) * Convert.ToInt32(txtSubmitNumber.Text);
                    lblOutputConsumeNumber1.Text = Convert.ToString(intValue);
                }

                if (lblOutputConsumeNumber2.Text != ""){ //使用数２の計算
                    int intValue = Convert.ToInt32(lblOutputOriginConsumeNumber2.Text) * Convert.ToInt32(txtSubmitNumber.Text);
                    lblOutputConsumeNumber2.Text = Convert.ToString(intValue);
                }

                if (lblOutputConsumeNumber3.Text != ""){ //使用数３の計算
                    int intValue = Convert.ToInt32(lblOutputOriginConsumeNumber3.Text) * Convert.ToInt32(txtSubmitNumber.Text);
                    lblOutputConsumeNumber3.Text = Convert.ToString(intValue);
                }
            }


        }


        //////////////////////////////////////////////////
        //検索メイン処理                                //
        //////////////////////////////////////////////////
        private void Search_Main(){
            //変数定義
            SearchClass SearchClass = new SearchClass();
            string strPartsCode1 = "", strPartsName1 = "", strPartsCode2 = "", strPartsName2 = "", strPartsCode3 = "", strPartsName3 = "";
            //値をrefで受け取る
            if(true == SearchClass.Search_Main(txtSearchProductCode.Text.Trim(), ref strPartsCode1, ref strPartsName1, ref strPartsCode2, ref strPartsName2, ref strPartsCode3, ref strPartsName3)){
                //受け取った値を代入
                txtInputPartsCode1.Text = strPartsCode1; lblInputPartsName1.Text = strPartsName1;
                txtInputPartsCode2.Text = strPartsCode2; lblInputPartsName2.Text = strPartsName2;
                txtInputPartsCode3.Text = strPartsCode3; lblInputPartsName3.Text = strPartsName3;
                //Outputにも値を代入
                txtOutputPartsCode1.Text = txtInputPartsCode1.Text;
                txtOutputPartsCode2.Text = txtInputPartsCode2.Text;
                txtOutputPartsCode3.Text = txtInputPartsCode3.Text;
                if (txtOutputPartsCode1.Text != "") { lblOutputConsumeNumber1.Text = "1"; lblOutputOriginConsumeNumber1.Text = "1"; }
                if (txtOutputPartsCode2.Text != "") { lblOutputConsumeNumber2.Text = "1"; lblOutputOriginConsumeNumber2.Text = "1"; }
                if (txtOutputPartsCode3.Text != "") { lblOutputConsumeNumber3.Text = "1"; lblOutputOriginConsumeNumber3.Text = "1"; } 
                //表示設定
                btnSearch.Enabled = false;
                btnSubmit.Enabled = true;
                groupBox3.Enabled = true;
                groupBox10.Enabled = true;
                txtSearchProductCode.Enabled = false;
                btnSearchProductMSSearch.Enabled = false;
                if (txtInputPartsCode1.Text.Trim() == "") { btnInputPartsMSSearch1.Enabled = false; } else { btnInputPartsMSSearch1.Enabled = true; }
                if (txtInputPartsCode2.Text.Trim() == "") { btnInputPartsMSSearch2.Enabled = false; } else { btnInputPartsMSSearch2.Enabled = true; }
                if (txtInputPartsCode3.Text.Trim() == "") { btnInputPartsMSSearch3.Enabled = false; } else { btnInputPartsMSSearch3.Enabled = true; }
            }else{
                MessageBox.Show("入力した製品コードが存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        //////////////////////////////////////////////////
        //更新前チェック処理                            //
        //////////////////////////////////////////////////
        private Boolean Submit_Check(){
            //変数定義
            CTCommon.ValueCheck ValueCheck = new CTCommon.ValueCheck();
            CheckClass CheckClass = new CheckClass();

            //使用部品１チェック
            if (txtInputPartsCode1.Text.Trim() != ""){
                if (lblInputStatus1.Text == "") { MessageBox.Show("使用部品１が設定されていません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            }
            //使用部品２チェック
            if (txtInputPartsCode2.Text.Trim() != ""){
                if (lblInputStatus2.Text == "") { MessageBox.Show("使用部品２が設定されていません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            }
            //使用部品３チェック
            if (txtInputPartsCode3.Text.Trim() != ""){
                if (lblInputStatus3.Text == "") { MessageBox.Show("使用部品３が設定されていません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            }

            //生産数が０か、空白の場合はエラー
            if (txtSubmitNumber.Text.Trim() == "0" || txtSubmitNumber.Text.Trim() == "") { MessageBox.Show("生産数が入力されていません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //更新担当者が存在しない場合はエラー
            if (false == ValueCheck.Check_HumanMS(txtHumanMSNo.Text.Trim())) { MessageBox.Show("入力した更新担当者は存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }


            ////使用部品の残数計算チェック処理
            //変数定義
            int intOutputConsumeNumber1 = 0; int intOutputConsumeNumber2 = 0; int intOutputConsumeNumber3 = 0;
            int intOutputPartsNumber1 = 0; int intOutputPartsNumber2 = 0; int intOutputPartsNumber3 = 0;
            //文字列→数値変換処理
            int.TryParse(lblOutputConsumeNumber1.Text, out intOutputConsumeNumber1);
            int.TryParse(lblOutputConsumeNumber2.Text, out intOutputConsumeNumber2);
            int.TryParse(lblOutputConsumeNumber3.Text, out intOutputConsumeNumber3);
            int.TryParse(txtOutputPartsNumber1.Text, out intOutputPartsNumber1);
            int.TryParse(txtOutputPartsNumber2.Text, out intOutputPartsNumber2);
            int.TryParse(txtOutputPartsNumber3.Text, out intOutputPartsNumber3);
            //本処理
            if (false == CheckClass.Check_OuputValues(intOutputConsumeNumber1, lblOutputPartsNo1.Text, intOutputPartsNumber1, intOutputConsumeNumber2, lblOutputPartsNo2.Text, intOutputPartsNumber2, intOutputConsumeNumber3, lblOutputPartsNo3.Text, intOutputPartsNumber3))
            {
                MessageBox.Show("部品残数の計算時、残数０以下の部品が発生します。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }

            //問題なければ、TRUEをかえす
            return true;

        }

        //////////////////////////////////////////////////
        //更新メイン処理                                //
        //////////////////////////////////////////////////
        private void Submit_Main(){
            //変数定義
            SubmitClass SubmitClass = new SubmitClass();
            SqlTransaction tran = null;
            SqlCommand cd = null;
            string strSQL;

            //フォーカスを外す
            this.ActiveControl = null;

            //確認メッセージ
            if (MessageBox.Show("登録しますか？", "登録確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                //チェック処理
                if (true == Submit_Check()){
                    try{
                        /////////////////////////
                        //トランザクション開始//
                        /////////////////////////
                        CTCommon.DBConnect.cn.Open();
                        tran = CTCommon.DBConnect.cn.BeginTransaction();
                        ////PARTS_TBL、PARTS_CONSUME_HISTORY_TBL////
                        //使用部品１の計算（使用部品が空欄の場合は計算しない）
                        if (txtOutputPartsCode1.Text.Trim() != ""){
                            ////PARTS_TBL、PARTS_HISTORY_TBL////
                            //SQL発行
                            strSQL = SubmitClass.Submit_Calc_PartsTBL(tran, lblOutputPartsNo1.Text, lblOutputConsumeNumber1.Text);
                            //計算結果が、削除処理か判定する
                            if (strSQL != "DELETE"){
                                //DELETE指示以外は通常とおりに更新処理
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                //更新処理
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                            }else{
                                ////削除処理の場合はTABLE_TBL、TABLE_HISTORY_TBL の削除SQLを生成する
                                //TABLE_TBL 削除SQL生成
                                strSQL = SubmitClass.Submit_PartsTBLDelete(lblOutputPartsNo1.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                //更新処理
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                                //TABLE_HISTORY_TBL 削除SQL生成
                                strSQL = SubmitClass.Submit_PartsHistoryTBLDelete(lblOutputPartsNo1.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                //更新処理
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                            }


                            ////PARTS_CONSUME_HISTORY_TBL////
                            //部品消費履歴マスタのMAX値、残数の取得
                            int intConsumeNo = SubmitClass.Submit_PartsConsumeMAX(tran);
                            int intReNumber = SubmitClass.Submit_PartsTBLReNumber(tran, lblOutputPartsNo1.Text);
                            //SQL発行
                            strSQL = SubmitClass.Submit_PartsConsume(tran, intConsumeNo, lblOutputPartsNo1.Text.Trim(), txtOutputPartsCode1.Text.Trim(), intReNumber, lblOutputConsumeNumber1.Text.Trim(), txtHumanMSNo.Text.Trim());
                            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                            //更新処理
                            cd.Transaction = tran;
                            cd.ExecuteNonQuery();
                        }


                        //使用部品２の計算（使用部品が空欄の場合は計算しない）
                        if (txtOutputPartsCode2.Text.Trim() != ""){
                            ////PARTS_TBL////
                            //SQL発行
                            strSQL = SubmitClass.Submit_Calc_PartsTBL(tran, lblOutputPartsNo2.Text, lblOutputConsumeNumber2.Text);
                            //計算結果が、削除処理か判定する
                            if (strSQL != "DELETE")
                            {
                                //DELETE指示以外は通常とおりに更新処理
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                //更新処理
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                            }else{
                                ////削除処理の場合はTABLE_TBL、TABLE_HISTORY_TBL の削除SQLを生成する
                                //TABLE_TBL 削除SQL生成
                                strSQL = SubmitClass.Submit_PartsTBLDelete(lblOutputPartsNo2.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                //更新処理
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                                //TABLE_HISTORY_TBL 削除SQL生成
                                strSQL = SubmitClass.Submit_PartsHistoryTBLDelete(lblOutputPartsNo2.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                //更新処理
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();
                            }





                            ////PARTS_CONSUME_HISTORY_TBL////
                            //部品消費履歴マスタのMAX値、消費残数の取得
                            int intConsumeNo = SubmitClass.Submit_PartsConsumeMAX(tran);
                            int intReNumber = SubmitClass.Submit_PartsTBLReNumber(tran, lblOutputPartsNo2.Text);
                            //SQL発行
                            strSQL = SubmitClass.Submit_PartsConsume(tran, intConsumeNo, lblOutputPartsNo2.Text.Trim(), txtOutputPartsCode2.Text.Trim(), intReNumber, lblOutputConsumeNumber2.Text.Trim(), txtHumanMSNo.Text.Trim());
                            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                            //更新処理
                            cd.Transaction = tran;
                            cd.ExecuteNonQuery();
                        }



                        //使用部品３の計算（使用部品が空欄の場合は計算しない）
                        if (txtOutputPartsCode3.Text.Trim() != ""){
                            //SQL発行
                            strSQL = SubmitClass.Submit_Calc_PartsTBL(tran, lblOutputPartsNo3.Text, lblOutputConsumeNumber3.Text);
                            //計算結果が、削除処理か判定する
                            if (strSQL != "DELETE")
                            {
                                //DELETE指示以外は通常とおりに更新処理
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                //更新処理
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                            }else{
                                ////削除処理の場合はTABLE_TBL、TABLE_HISTORY_TBL の削除SQLを生成する
                                //TABLE_TBL 削除SQL生成
                                strSQL = SubmitClass.Submit_PartsTBLDelete(lblOutputPartsNo3.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                //更新処理
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                                //TABLE_HISTORY_TBL 削除SQL生成
                                strSQL = SubmitClass.Submit_PartsHistoryTBLDelete(lblOutputPartsNo3.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                //更新処理
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();
                            }

                            ////PARTS_CONSUME_HISTORY_TBL////
                            //部品消費履歴マスタのMAX値、残数の取得
                            int intConsumeNo = SubmitClass.Submit_PartsConsumeMAX(tran);
                            int intReNumber = SubmitClass.Submit_PartsTBLReNumber(tran, lblOutputPartsNo3.Text);
                            //SQL発行
                            strSQL = SubmitClass.Submit_PartsConsume(tran, intConsumeNo, lblOutputPartsNo3.Text.Trim(), txtOutputPartsCode3.Text.Trim(), intReNumber, lblOutputConsumeNumber3.Text.Trim(), txtHumanMSNo.Text.Trim());
                            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                            //更新処理
                            cd.Transaction = tran;
                            cd.ExecuteNonQuery();
                        }

                        ////PRODUCT_TBL、PRODUCT_HISTORY_TBL////
                        //PRODUCT_TBL
                        //生産NOのMAX値を取得
                        int intProductNoMAX = SubmitClass.Submit_ProductNoMAX(tran);
                        //SQL発行
                        strSQL = SubmitClass.Submit_ProductTBL(intProductNoMAX, txtSearchProductCode.Text.Trim(), txtSubmitNumber.Text.Trim(), txtHumanMSNo.Text.Trim());
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        //更新処理
                        cd.Transaction = tran;
                        cd.ExecuteNonQuery();

                        //PRODUCT_HISTORY_TBL
                        //SQL発行
                        strSQL = SubmitClass.Submit_ProductHistoryTBL(intProductNoMAX, txtSearchProductCode.Text.Trim(), txtSubmitNumber.Text.Trim(), dtpSubmit.Text, txtOutputPartsCode1.Text.Trim(), lblOutputPartsNo1.Text.Trim(), txtOutputPartsCode2.Text.Trim(), lblOutputPartsNo2.Text.Trim(), txtOutputPartsCode3.Text.Trim(), lblOutputPartsNo3.Text.Trim(), txtHumanMSNo.Text.Trim());
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        //更新処理
                        cd.Transaction = tran;
                        cd.ExecuteNonQuery();

                        //更新完了メッセージ
                        MessageBox.Show("登録完了しました。", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        smClear();
                        tran.Commit();







                        //strSQL = "";
                        //strSQL += "SELECT ";
                        //strSQL += " 登録数 ";
                        //strSQL += "FROM ";
                        //strSQL += " PARTS_TBL ";
                        //strSQL += "WHERE ";
                        //strSQL += " 部品登録NO = " + lblOutputPartsNo2.Text + " ";
                        //cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        //cd.Transaction = tran;
                        //dtReader = cd.ExecuteReader();
                        //if (dtReader.Read()) { a = dtReader["登録数"].ToString(); }
                        //MessageBox.Show(a, "a", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //dtReader.Close();




                    }catch (Exception e){
                        tran.Rollback();
                        MessageBox.Show(e.Message);
                    }finally{
                        //クローズ処理
                        CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                    }




                }

            }

        }

        //////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        private void smClear() {
            //テキストボックス初期化
            txtSearchProductCode.Clear();
            txtInputPartsCode1.Clear();
            txtInputPartsCode2.Clear();
            txtInputPartsCode3.Clear();
            txtOutputPartsCode1.Clear();
            txtOutputPartsCode2.Clear();
            txtOutputPartsCode3.Clear();
            txtOutputPartsNumber1.Clear();
            txtOutputPartsNumber2.Clear();
            txtOutputPartsNumber3.Clear();
            txtSubmitNumber.Clear();
            txtHumanMSNo.Clear();
            //テキストボックス初期表示処理
            txtSearchProductCode.Enabled = true;
            btnSearchProductMSSearch.Enabled = true;
            txtInputPartsCode1.ReadOnly = true;
            txtInputPartsCode2.ReadOnly = true;
            txtInputPartsCode3.ReadOnly = true;
            txtOutputPartsCode1.ReadOnly = true;
            txtOutputPartsCode2.ReadOnly = true;
            txtOutputPartsCode3.ReadOnly = true;
            txtOutputPartsNumber1.ReadOnly = true;
            txtOutputPartsNumber2.ReadOnly = true;
            txtOutputPartsNumber3.ReadOnly = true;

            //ラベル初期化
            lblInputPartsName1.Text = "";
            lblInputPartsName2.Text = "";
            lblInputPartsName3.Text = "";
            lblInputPartsNo1.Text = "";
            lblInputPartsNo2.Text = "";
            lblInputPartsNo3.Text = "";
            lblInputStatus1.Text = "";
            lblInputStatus2.Text = "";
            lblInputStatus3.Text = "";
            lblOutputConsumeNumber1.Text = "";
            lblOutputConsumeNumber2.Text = "";
            lblOutputConsumeNumber3.Text = "";
            lblOutputOriginConsumeNumber1.Text = "";
            lblOutputOriginConsumeNumber2.Text = "";
            lblOutputOriginConsumeNumber3.Text = "";
            lblOutputPartsNo1.Text = "";
            lblOutputPartsNo2.Text = "";
            lblOutputPartsNo3.Text = "";
            lblSearchProductName.Text = "";
            //ボタン初期化
            btnSearch.Enabled = true;
            btnSubmit.Enabled = false;
            //Groupbox初期化
            groupBox3.Enabled = false;
            groupBox10.Enabled = false;



        }






        //public void test(string strPartsNo)
        //{
        //    SqlCommand cd = null;
        //    SqlDataReader dtReader;
        //    string a = "";
        //    strSQL = "";
        //    strSQL += "SELECT ";
        //    strSQL += " 登録数 ";
        //    strSQL += "FROM ";
        //    strSQL += " PARTS_TBL ";
        //    strSQL += "WHERE ";
        //    strSQL += " 部品登録NO = " + strPartsNo + " ";
        //    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);

        //    dtReader = cd.ExecuteReader();
        //    if (dtReader.Read()) { a = dtReader["登録数"].ToString(); }
        //    MessageBox.Show(a, "a", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


        //}



    }
}

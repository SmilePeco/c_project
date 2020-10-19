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
            CT012_Clear();
             
        }

        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CT012_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode){
                case Keys.F1:
                    //検索処理
                    if (btnSearch.Enabled == true) { CT012_Search(); }
                    break;

                case Keys.F2:
                    //登録処理
                    if (btnSubmit.Enabled == true) { CT012_Submit(); }
                    break;

                case Keys.F3:
                    //クリア処理
                    CT012_Clear();
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
        private void CT012_ButtonClick(object sender, EventArgs e){ 

            if (sender.Equals(this.btnSearch)) { CT012_Search(); } //検索メイン処理
            if (sender.Equals(this.btnSubmit)) { CT012_Submit(); } //登録メイン処理
            if (sender.Equals(this.btnClear)) { CT012_Clear(); } //クリア処理
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了処理


            //【説明】：製品コード検索ボタン押下
            if (sender.Equals(this.btnSearchProductMSSearch)){
                CTCommon.CTProductMSSearch frmSearch = new CTCommon.CTProductMSSearch();
                txtSearchProductCode.Text =  frmSearch.Showminiform();

                CTCommon.NameSubmit NameSubmit = new CTCommon.NameSubmit();
                lblSearchProductName.Text = NameSubmit.ProductName_Submit(txtSearchProductCode.Text);
            }

            //【説明】：更新担当者ボタン押下
            if (sender.Equals(this.btnHumanMSSearch)){
                CTCommon.CTHumanMSSearch frmSearch = new CTCommon.CTHumanMSSearch();

                txtHumanMSNo.Text = frmSearch.ShowminiForm();
            }

            //【説明】：使用部品１～３ボタン押下
            Button btn = sender as Button;
            string ClickButtonName = btn.Name;

            if (ClickButtonName == "btnInputPartsMSSearch1" || 
                ClickButtonName == "btnInputPartsMSSearch2" ||
                ClickButtonName == "btnInputPartsMSSearch3"){

                    Button_InputParts(ClickButtonName);

            }

        }

        //////////////////////////////////////////////////
        //使用部品検索ボタン　内部処理                  //
        //////////////////////////////////////////////////
        private void Button_InputParts(string ButtonName){

            CTCommon.CTPartsNoSearch frmSearch = new CTCommon.CTPartsNoSearch();
            Search Search = new Search();
            string OutputPartsNo;

            if (ButtonName == "btnInputPartsMSSearch1"){
                OutputPartsNo = frmSearch.Showminiform(txtInputPartsCode1.Text);
                if (OutputPartsNo != null){
                    lblInputStatus1.Text = "設定済";
                    lblInputPartsNo1.Text = OutputPartsNo;
                    lblOutputPartsNo1.Text = OutputPartsNo;
                    txtOutputPartsNumber1.Text = Search.Search_OutputPartsNumber(OutputPartsNo);
                }

            }else if (ButtonName == "btnInputPartsMSSearch2"){
                OutputPartsNo = frmSearch.Showminiform(txtInputPartsCode2.Text);
                if (OutputPartsNo != null){
                    lblInputStatus2.Text = "設定済";
                    lblInputPartsNo2.Text = OutputPartsNo;
                    lblOutputPartsNo2.Text = OutputPartsNo;
                    txtOutputPartsNumber2.Text = Search.Search_OutputPartsNumber(OutputPartsNo);
                }

            }else if (ButtonName == "btnInputPartsMSSearch3"){
                OutputPartsNo = frmSearch.Showminiform(txtInputPartsCode3.Text);
                if (OutputPartsNo != null){
                    lblInputStatus3.Text = "設定済";
                    lblInputPartsNo3.Text = OutputPartsNo;
                    lblOutputPartsNo3.Text = OutputPartsNo;
                    txtOutputPartsNumber3.Text = Search.Search_OutputPartsNumber(OutputPartsNo);
                }
            }
        }
            

        //////////////////////////////////////////////////
        //テキストボックス 数値のみ入力可能 制御処理    //
        //////////////////////////////////////////////////
        private void CT012_KeyPress_Text(object sender, KeyPressEventArgs e){
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        //////////////////////////////////////////////////
        //生産数 Leave処理                              //
        //////////////////////////////////////////////////
        private void CT012_Leave(object sender, EventArgs e){ 

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
        private void CT012_Search(){
            //変数定義
            Search Search = new Search();
            string[] PartsCode; string[] PartsName;
            PartsCode = new string[4]; PartsName = new string[4]; 
            if(true == Search.Main(txtSearchProductCode.Text.Trim(), ref PartsCode, ref PartsName)){

                for (int i = 1; i <= 3; i++){
                    Control[] InputPartsCode = this.Controls.Find("txtInputPartsCode" + i, true);
                    Control[] OutputPartsCode = this.Controls.Find("txtOutputPartsCode" + i, true);
                    Control[] InputPartsName = this.Controls.Find("lblInputPartsName" + i, true);
                    InputPartsCode[0].Text = PartsCode[i];
                    OutputPartsCode[0].Text = PartsCode[i];
                    InputPartsName[0].Text = PartsName[i];
                }
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
        private Boolean CT012_Submit_Check(){ 
            CTCommon.ValueCheck ValueCheck = new CTCommon.ValueCheck();
            Check Check = new Check();

            //使用部品チェック
            if (txtInputPartsCode1.Text.Trim() != "" && lblInputStatus1.Text == "") { MessageBox.Show("使用部品１が設定されていません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (txtInputPartsCode2.Text.Trim() != "" && lblInputStatus2.Text == "") { MessageBox.Show("使用部品２が設定されていません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            if (txtInputPartsCode3.Text.Trim() != "" && lblInputStatus3.Text == "") { MessageBox.Show("使用部品３が設定されていません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //生産数が０か、空白の場合はエラー
            if (txtSubmitNumber.Text.Trim() == "0" || txtSubmitNumber.Text.Trim() == "") { MessageBox.Show("生産数が入力されていません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //更新担当者が存在しない場合はエラー
            if (false == ValueCheck.Check_HumanMS(txtHumanMSNo.Text.Trim())) { MessageBox.Show("入力した更新担当者は存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            //【説明】:ラベル値→数値の変換をする。
            var lblConsumeNumber = new string[] { lblOutputConsumeNumber1.Text, lblOutputConsumeNumber2.Text, lblOutputConsumeNumber3.Text };
            var txtPartsNumber = new string[] { txtOutputPartsNumber1.Text, txtOutputPartsNumber2.Text, txtOutputPartsNumber3.Text };
            int[] OutputConsume = new int[3];
            int[] OutputParts = new int[3];

            for (int i = 0; i <= 2; i++){
                if (lblConsumeNumber[i] == "") { OutputConsume[i] = 0; } else { OutputConsume[i] = Convert.ToInt32(lblConsumeNumber[i]); }
                if (txtPartsNumber[i] == "") { OutputParts[i] = 0; } else { OutputParts[i] = Convert.ToInt32(txtPartsNumber[i]); }
            }

            //【説明】:入力生産数＞使用数だった場合はエラーとする。
            var lblPartsNo = new string[] { lblOutputPartsNo1.Text, lblOutputPartsNo2.Text, lblOutputPartsNo3.Text };

            if (false == Check.OuputValues(OutputConsume, lblPartsNo, OutputParts)){
                MessageBox.Show("部品残数の計算時、残数０以下の部品が発生します。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
            }
            
            return true;

        }

        //////////////////////////////////////////////////
        //更新メイン処理                                //
        //////////////////////////////////////////////////
        private void CT012_Submit(){ //プルリクエスト用：CT012_Submitとする
            //変数定義
            Submit Submit = new Submit();
            SqlTransaction tran = null;
            SqlCommand cd = null;
            string strSQL = "";
            string[] SQL_DeleteJudge = new string[3];
            int[] SQL_HISTORYTBL_MaxNo = new int[3];
            int[] SQL_HISTORYTBL_ReNumber = new int[3];

            //【備考】：計算漏れをなくすため、フォーカスを外す
            this.ActiveControl = null;

            if (MessageBox.Show("登録しますか？", "登録確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes){
                //チェック処理
                if (true == CT012_Submit_Check()){
                    try{
                        CTCommon.DBConnect.cn.Open();
                        tran = CTCommon.DBConnect.cn.BeginTransaction();

                        //【説明】：使用部品１の処理
                        if (txtOutputPartsCode1.Text.Trim() != ""){

                            T012_Submit_Prep_PartsNo1(tran, ref SQL_DeleteJudge);

                            if (SQL_DeleteJudge[0] == "DELETE"){
                                //【説明】：使用数＞PARTS_TBLの登録数の場合は、DELETE処理
                                strSQL = Submit.DELETE_PARTS_TBL(lblOutputPartsNo1.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                                strSQL = Submit.DELETE_PARTS_HISTORY_TBL(lblOutputPartsNo1.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                            }else{
                                //【説明】：使用数＜PARTS_TBLの登録数の場合は、登録数の引き算
                                cd = new SqlCommand(SQL_DeleteJudge[0], CTCommon.DBConnect.cn);
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                            }

                            string[] ConsumeParts = new string[] { lblOutputPartsNo1.Text.Trim(), txtOutputPartsCode1.Text.Trim() };
                            string[] OthersName = new string[] { lblOutputConsumeNumber1.Text.Trim(), txtHumanMSNo.Text.Trim() };

                            T012_Submit_After_PartsNo1(tran, ref SQL_HISTORYTBL_MaxNo, ref SQL_HISTORYTBL_ReNumber);

                            //【説明】：登録・引き算処理を消費履歴に残す
                            strSQL = Submit.INSERT_PARTS_CONSUME_HISTORY_TBL(tran, SQL_HISTORYTBL_MaxNo[1], ConsumeParts, SQL_HISTORYTBL_ReNumber[1], OthersName);
                            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                            cd.Transaction = tran;
                            cd.ExecuteNonQuery();
                        }

                        //【説明】：使用部品２の処理（１と処理内容は同じ。）
                        if (txtOutputPartsCode2.Text.Trim() != ""){
                            T012_Submit_Prep_PartsNo2(tran, ref SQL_DeleteJudge);


                            if (SQL_DeleteJudge[1] == "DELETE"){
                                strSQL = Submit.DELETE_PARTS_TBL(lblOutputPartsNo2.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                                strSQL = Submit.DELETE_PARTS_HISTORY_TBL(lblOutputPartsNo2.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                            }else{
                                cd = new SqlCommand(SQL_DeleteJudge[1], CTCommon.DBConnect.cn);
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                            }

                            string[] ConsumeParts = new string[] { lblOutputPartsNo2.Text.Trim(), txtOutputPartsCode2.Text.Trim() };
                            string[] OthersName = new string[] { lblOutputConsumeNumber2.Text.Trim(), txtHumanMSNo.Text.Trim() };

                            T012_Submit_After_PartsNo2(tran, ref SQL_HISTORYTBL_MaxNo, ref SQL_HISTORYTBL_ReNumber);

                            strSQL = Submit.INSERT_PARTS_CONSUME_HISTORY_TBL(tran, SQL_HISTORYTBL_MaxNo[1], ConsumeParts,  SQL_HISTORYTBL_ReNumber[1], OthersName);
                            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                            cd.Transaction = tran;
                            cd.ExecuteNonQuery();
                        }

                        //【説明】：使用部品３の処理（１と処理内容は同じ。）
                        if (txtOutputPartsCode3.Text.Trim() != ""){
                            T012_Submit_Prep_PartsNo3(tran, ref SQL_DeleteJudge);

                            if (SQL_DeleteJudge[2] == "DELETE"){
                                strSQL = Submit.DELETE_PARTS_TBL(lblOutputPartsNo3.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                                strSQL = Submit.DELETE_PARTS_HISTORY_TBL(lblOutputPartsNo3.Text);
                                cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                            }else{
                                cd = new SqlCommand(SQL_DeleteJudge[2], CTCommon.DBConnect.cn);
                                cd.Transaction = tran;
                                cd.ExecuteNonQuery();

                            }

                            string[] ConsumeParts = new string[] { lblOutputPartsNo3.Text.Trim(), txtOutputPartsCode3.Text.Trim() };
                            string[] OthersName = new string[] { lblOutputConsumeNumber3.Text.Trim(), txtHumanMSNo.Text.Trim() };

                            T012_Submit_After_PartsNo3(tran, ref SQL_HISTORYTBL_MaxNo, ref SQL_HISTORYTBL_ReNumber);

                            strSQL = Submit.INSERT_PARTS_CONSUME_HISTORY_TBL(tran, SQL_HISTORYTBL_MaxNo[2], ConsumeParts, SQL_HISTORYTBL_ReNumber[2], OthersName);
                            cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                            cd.Transaction = tran;
                            cd.ExecuteNonQuery();
                        }

                        int intProductNoMAX = Submit.Submit_ProductNoMAX(tran);
                        //【説明】：製品テーブルに履歴を残す
                        strSQL = Submit.Submit_ProductTBL(intProductNoMAX, txtSearchProductCode.Text.Trim(), txtSubmitNumber.Text.Trim(), txtHumanMSNo.Text.Trim());
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        cd.Transaction = tran;
                        cd.ExecuteNonQuery();

                        //【説明】：製品テーブルに詳細な履歴を残す
                        strSQL = Submit.Submit_ProductHistoryTBL(intProductNoMAX, txtSearchProductCode.Text.Trim(), txtSubmitNumber.Text.Trim(), dtpSubmit.Text, txtOutputPartsCode1.Text.Trim(), lblOutputPartsNo1.Text.Trim(), txtOutputPartsCode2.Text.Trim(), lblOutputPartsNo2.Text.Trim(), txtOutputPartsCode3.Text.Trim(), lblOutputPartsNo3.Text.Trim(), txtHumanMSNo.Text.Trim());
                        cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                        cd.Transaction = tran;
                        cd.ExecuteNonQuery();

                        MessageBox.Show("登録完了しました。", "登録完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        CT012_Clear();
                        tran.Commit();

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
        //更新事前処理  部品コード１                    //
        //////////////////////////////////////////////////
        private void T012_Submit_Prep_PartsNo1(SqlTransaction tran, ref string[] SQL_DeleteJudge) {

            Submit Submit = new Submit();

            if (txtOutputPartsCode1.Text.Trim() != ""){
                SQL_DeleteJudge[0] = Submit.JUDGE_PARTS_TBL(tran, lblOutputPartsNo1.Text, lblOutputConsumeNumber1.Text);
            }
        }

        //////////////////////////////////////////////////
        //更新事前処理  部品コード２                    //
        //////////////////////////////////////////////////
        private void T012_Submit_Prep_PartsNo2(SqlTransaction tran, ref string[] SQL_DeleteJudge){

            Submit Submit = new Submit();

            if (txtOutputPartsCode2.Text.Trim() != ""){
                SQL_DeleteJudge[1] = Submit.JUDGE_PARTS_TBL(tran, lblOutputPartsNo2.Text, lblOutputConsumeNumber2.Text);
            }
        }

        //////////////////////////////////////////////////
        //更新事前処理  部品コード３                    //
        //////////////////////////////////////////////////
        private void T012_Submit_Prep_PartsNo3(SqlTransaction tran, ref string[] SQL_DeleteJudge){

            Submit Submit = new Submit();

            if (txtOutputPartsCode3.Text.Trim() != ""){
                SQL_DeleteJudge[2] = Submit.JUDGE_PARTS_TBL(tran, lblOutputPartsNo3.Text, lblOutputConsumeNumber3.Text);
            }
        }

        //////////////////////////////////////////////////
        //更新事後処理  部品コード１                    //
        //////////////////////////////////////////////////
        private void T012_Submit_After_PartsNo1(SqlTransaction tran, ref int[] SQL_HISTORYTBL_MaxNo, ref int[] SQL_HISTORYTBL_ReNumber){

            Submit Submit = new Submit();
            
            if (txtOutputPartsCode1.Text.Trim() != ""){
                SQL_HISTORYTBL_MaxNo[0] = Submit.Submit_PartsConsumeMAX(tran);
                SQL_HISTORYTBL_ReNumber[0] = Submit.Submit_PartsTBLReNumber(tran, lblOutputPartsNo1.Text);

            }
        }
            

        //////////////////////////////////////////////////
        //更新事後処理  部品コード２                    //
        //////////////////////////////////////////////////
        private void T012_Submit_After_PartsNo2(SqlTransaction tran, ref int[] SQL_HISTORYTBL_MaxNo, ref int[] SQL_HISTORYTBL_ReNumber){

            Submit Submit = new Submit();

            if (txtOutputPartsCode2.Text.Trim() != ""){
                SQL_HISTORYTBL_MaxNo[1] = Submit.Submit_PartsConsumeMAX(tran);
                SQL_HISTORYTBL_ReNumber[1] = Submit.Submit_PartsTBLReNumber(tran, lblOutputPartsNo2.Text);

            }

        }

        //////////////////////////////////////////////////
        //更新事後処理  部品コード３                    //
        //////////////////////////////////////////////////
        private void T012_Submit_After_PartsNo3(SqlTransaction tran, ref int[] SQL_HISTORYTBL_MaxNo, ref int[] SQL_HISTORYTBL_ReNumber){

            Submit Submit = new Submit();

            if (txtOutputPartsCode3.Text.Trim() != ""){
                SQL_HISTORYTBL_MaxNo[2] = Submit.Submit_PartsConsumeMAX(tran);
                SQL_HISTORYTBL_ReNumber[2] = Submit.Submit_PartsTBLReNumber(tran, lblOutputPartsNo3.Text);

            }

        }





        //////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        private void CT012_Clear(){ 

            //プルリクエスト用：ここも集約したい

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



    }
}

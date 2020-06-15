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

namespace CT009_受注先マスタメンテナンス
{
    public partial class CT009 : Form
    {
        public CT009()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CT009_Load(object sender, EventArgs e)
        {
            //クリア処理
            smClear();
        }


        //////////////////////////////////////////////////
        //ボタン押下処理                                //
        //////////////////////////////////////////////////
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(this.btnSerach)) { Search_Main(); } //検索処理
            if (sender.Equals(this.btnSubmit)) { Submit_Main(); } //更新処理

            if (sender.Equals(this.btnClear)) { smClear(); } //クリア処理
            if (sender.Equals(this.btnEnd)) { this.Close(); } //終了処理



        }


        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CT009_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    //検索処理
                    Search_Main();
                    break;

                case Keys.F2:
                    //更新処理
                    if (btnSubmit.Enabled == true) { Submit_Main(); }
                    break;

                case Keys.F3:
                    //削除処理
                    if (btnDelete.Enabled == true) { Delete_Main(); }
                    break;

                case Keys.F4:
                    //クリア処理
                    smClear();
                    break;

                case Keys.F5:
                    //終了処理
                    this.Close();
                    break;
            }
        }




        //////////////////////////////////////////////////
        //検索メイン処理                               //
        //////////////////////////////////////////////////
        public void Search_Main()
        {
            //変数定義
            SearchClass SearchClass = new SearchClass();

            //空白ではない場合は、０埋め処理
            if (txtSearchOrderMSNO.Text.Trim() != ""){
                txtSearchOrderMSNO.Text = txtSearchOrderMSNO.Text.PadLeft(3, '0');
            }

            
            //空白以外の場合は、更新モード
            //空白の場合は、登録モード
            if (txtSearchOrderMSNO.Text.Trim() != ""){
                //更新モード
                //入力した値が存在しているか確認
                if (true == SearchClass.Search_Check(txtSearchOrderMSNO.Text.Trim())){
                    //存在した場合は、各値を検索
                    txtOrderMSName.Text = SearchClass.Search_Values("1", txtSearchOrderMSNO.Text.Trim()); //受注先名の取得
                    txtOrderMSPerson.Text = SearchClass.Search_Values("2", txtSearchOrderMSNO.Text.Trim()); //受注先担当者名の取得
                    txtOrderMSTEL.Text = SearchClass.Search_Values("3", txtSearchOrderMSNO.Text.Trim()); //受注先電話番号の取得
                    txtOrderMSAdress1.Text = SearchClass.Search_Values("4", txtSearchOrderMSNO.Text.Trim()); //受注先住所１の取得
                    txtOrderMSAdress2.Text = SearchClass.Search_Values("5", txtSearchOrderMSNO.Text.Trim()); //受注先住所１の取得
                    //表示設定
                    groupBox3.Enabled = true;
                    txtSearchOrderMSNO.Enabled = false;
                    btnSubmit.Enabled = true;
                    btnDelete.Enabled = true;
                    lblMode.Text = "更新";



                }else{
                    MessageBox.Show("入力した受注先NOはマスタに存在しません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }else{
                //登録モード
                //MAX値の取得
                txtSearchOrderMSNO.Text = SearchClass.Search_OrderMSNoMAX();
                //表示設定
                txtSearchOrderMSNO.Enabled = true;
                groupBox3.Enabled = true;
                btnSubmit.Enabled = true;
                btnDelete.Enabled = true;
                lblMode.Text = "登録";

            }



        }


        ////////////////////////////////////////////////////
        ////更新チェック処理                              //
        ////////////////////////////////////////////////////
        //private Boolean Submit_Check(){

        //    //空白チェック
        //    if (txtOrderMSName.Text.Trim() == "") { MessageBox.Show("受注先名が空欄のため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; } //受注先名
        //    if (txtOrderMSPerson.Text.Trim() == "") { MessageBox.Show("受注先担当者名が空欄のため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; } //受注先担当者名
        //    if (txtOrderMSTEL.Text.Trim() == "") { MessageBox.Show("受注先電話番号が空欄のため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; } //受注先電話番号
        //    if (txtOrderMSAdress1.Text.Trim() == "") { MessageBox.Show("受注先住所１が空欄のため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; } //受注先住所１
        //    if (txtOrderMSAdress2.Text.Trim() == "") { MessageBox.Show("受注先住所２が空欄のため、登録できません。 \r\n確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; } //受注先住所２

        //    //問題なければ、TRUEをかえす
        //    return true;

        //}


        //////////////////////////////////////////////////
        //更新メイン処理                                //
        //////////////////////////////////////////////////
        private void Submit_Main(){

            //変数定義
            string strSQL;
            SubmitClass SubmitClass = new SubmitClass();
            SqlCommand cd = null;

            //更新確認メッセージ
            if (MessageBox.Show("更新しますか？", "更新確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try
                {
                    //SQL取得
                    strSQL = SubmitClass.Submit_Main(lblMode.Text, txtSearchOrderMSNO.Text.Trim(), txtOrderMSName.Text.Trim(), txtOrderMSPerson.Text.Trim(), txtOrderMSTEL.Text.Trim(), txtOrderMSAdress1.Text.Trim(), txtOrderMSAdress2.Text.Trim());
                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                    CTCommon.DBConnect.cn.Open();
                    cd.ExecuteNonQuery();
                    //更新完了
                    MessageBox.Show("更新完了しました。", "更新完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    smClear();


                }catch (Exception e){
                    MessageBox.Show(e.Message);
                }finally{
                    //クローズ処理
                    CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);
                }
            }
        }

        //////////////////////////////////////////////////
        //削除メイン処理                                    //
        //////////////////////////////////////////////////
        private void Delete_Main()
        {
            //変数定義
            string strSQL;
            DeleteClass DeleteClass = new DeleteClass();
            SqlCommand cd = null;


            //削除確認
            if (MessageBox.Show("削除しますか？", "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                try{
                    //SQL取得
                    strSQL = DeleteClass.Delete_Main(txtSearchOrderMSNO.Text.Trim());
                    cd = new SqlCommand(strSQL, CTCommon.DBConnect.cn);
                    CTCommon.DBConnect.cn.Open();
                    cd.ExecuteNonQuery();
                    //更新完了
                    MessageBox.Show("削除完了しました。", "削除完了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    smClear();

                }catch (Exception e){
                    MessageBox.Show(e.Message);
                }finally{
                    //クローズ処理
                    CTCommon.DBConnect.DBConnect_Close(CTCommon.DBConnect.cn);

                }

            }
        }

        //////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        public void smClear(){
            //テキストボックス初期化
            txtSearchOrderMSNO.Clear();
            txtOrderMSName.Clear();
            txtOrderMSPerson.Clear();
            txtOrderMSTEL.Clear();
            txtOrderMSAdress1.Clear();
            txtOrderMSAdress2.Clear();
            txtSearchOrderMSNO.Enabled = true;
            //ラベル初期化
            lblMode.Text = "";
            //GroupBox初期化
            groupBox3.Enabled = false;
            //ボタン初期化
            btnSubmit.Enabled = false;
            btnDelete.Enabled = false;
            

        }













    }
}

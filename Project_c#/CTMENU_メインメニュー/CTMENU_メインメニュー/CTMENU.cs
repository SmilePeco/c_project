using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTMENU_メインメニュー
{
    public partial class CTMENU : Form
    {

        //変数定義
        CT001_受注仮登録画面.CT001 CT001 = new CT001_受注仮登録画面.CT001();
        CT002_受注登録画面.CT002 CT002 = new CT002_受注登録画面.CT002();
        CT003_社員マスタメンテナンス.CT003 CT003 = new CT003_社員マスタメンテナンス.CT003();
        CT004_部品分類マスタメンテナンス.CT004 CT004 = new CT004_部品分類マスタメンテナンス.CT004();
        CT005_部品マスタメンテナンス.CT005 CT005 = new CT005_部品マスタメンテナンス.CT005();
        CT006_倉庫マスタメンテナンス.CT006 CT006 = new CT006_倉庫マスタメンテナンス.CT006();
        CT007_製品マスタメンテナンス.CT007 CT007 = new CT007_製品マスタメンテナンス.CT007();
        CT008_作業ラインマスタメンテナンス.CT008 CT008 = new CT008_作業ラインマスタメンテナンス.CT008();
        CT009_受注先マスタメンテナンス.CT009 CT009 = new CT009_受注先マスタメンテナンス.CT009();
        CT010_部品仮登録画面.CT010 CT010 = new CT010_部品仮登録画面.CT010();
        CT011_部品本登録画面.CT011 CT011 = new CT011_部品本登録画面.CT011();
        CT012_製品生産画面.CT012 CT012 = new CT012_製品生産画面.CT012();

        public string strPublicAdminFLG; //ログインした管理者フラグの確認用

        public CTMENU()
        {
            InitializeComponent();
        }



        //////////////////////////////////////////////////
        //Load処理                                      //
        //////////////////////////////////////////////////
        private void CTMENU_Load(object sender, EventArgs e)
        {
            //初期設定
            smClear();

        }


        //////////////////////////////////////////////////
        //ファンクションキー処理                        //
        //////////////////////////////////////////////////
        private void CTMENU_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode){
                case Keys.F1:
                    //終了処理
                    this.Close();
                    break;


            }

        }


        //////////////////////////////////////////////////
        //メインボタン処理                              //
        //////////////////////////////////////////////////
        private void MainButton_Click(object sender, EventArgs e)
        {

            if (sender.Equals(this.btnEnd)) { this.Close();} //終了処理

            //メインボタン：受注処理を押下
            if (sender.Equals(this.btnMain01))
            {
                btnSub01.Text = "受注仮登録"; btnSub01.Visible = true; //ボタン１設定
                btnSub02.Text = "受注登録"; btnSub02.Visible = true; //ボタン２設定
                btnSub03.Text = ""; btnSub03.Visible = false; //ボタン３設定
                btnSub04.Text = ""; btnSub04.Visible = false; //ボタン４設定
                btnSub05.Text = ""; btnSub05.Visible = false; //ボタン５設定
                btnSub06.Text = ""; btnSub06.Visible = false; //ボタン６設定
                btnSub07.Text = ""; btnSub07.Visible = false; //ボタン７設定
                btnSub08.Text = ""; btnSub08.Visible = false; //ボタン８設定
                btnSub09.Text = ""; btnSub09.Visible = false; //ボタン９設定
                btnSub10.Text = ""; btnSub10.Visible = false; //ボタン１０設定
            }

            //メインボタン：生産処理を押下
            if (sender.Equals(this.btnMain02))
            {
                btnSub01.Text = "部品仮登録"; btnSub01.Visible = true; //ボタン１設定
                btnSub02.Text = "部品本登録"; btnSub02.Visible = true; //ボタン２設定
                btnSub03.Text = "製品生産"; btnSub03.Visible = true; //ボタン３設定
                btnSub04.Text = ""; btnSub04.Visible = false; //ボタン４設定
                btnSub05.Text = ""; btnSub05.Visible = false; //ボタン５設定
                btnSub06.Text = ""; btnSub06.Visible = false; //ボタン６設定
                btnSub07.Text = ""; btnSub07.Visible = false; //ボタン７設定
                btnSub08.Text = ""; btnSub08.Visible = false; //ボタン８設定
                btnSub09.Text = ""; btnSub09.Visible = false; //ボタン９設定
                btnSub10.Text = ""; btnSub10.Visible = false; //ボタン１０設定
            }

            //メインボタン：出荷・売上処理を押下
            if (sender.Equals(this.btnMain03))
            {
                btnSub01.Text = ""; btnSub01.Visible = false; //ボタン１設定
                btnSub02.Text = ""; btnSub02.Visible = false; //ボタン２設定
                btnSub03.Text = ""; btnSub03.Visible = false; //ボタン３設定
                btnSub04.Text = ""; btnSub04.Visible = false; //ボタン４設定
                btnSub05.Text = ""; btnSub05.Visible = false; //ボタン５設定
                btnSub06.Text = ""; btnSub06.Visible = false; //ボタン６設定
                btnSub07.Text = ""; btnSub07.Visible = false; //ボタン７設定
                btnSub08.Text = ""; btnSub08.Visible = false; //ボタン８設定
                btnSub09.Text = ""; btnSub09.Visible = false; //ボタン９設定
                btnSub10.Text = ""; btnSub10.Visible = false; //ボタン１０設定
            }

            //メインボタン：在庫処理を押下
            if (sender.Equals(this.btnMain04))
            {
                btnSub01.Text = ""; btnSub01.Visible = false; //ボタン１設定
                btnSub02.Text = ""; btnSub02.Visible = false; //ボタン２設定
                btnSub03.Text = ""; btnSub03.Visible = false; //ボタン３設定
                btnSub04.Text = ""; btnSub04.Visible = false; //ボタン４設定
                btnSub05.Text = ""; btnSub05.Visible = false; //ボタン５設定
                btnSub06.Text = ""; btnSub06.Visible = false; //ボタン６設定
                btnSub07.Text = ""; btnSub07.Visible = false; //ボタン７設定
                btnSub08.Text = ""; btnSub08.Visible = false; //ボタン８設定
                btnSub09.Text = ""; btnSub09.Visible = false; //ボタン９設定
                btnSub10.Text = ""; btnSub10.Visible = false; //ボタン１０設定
            }

            //メインボタン：マスタメンテナンス処理を押下
            if (sender.Equals(this.btnMain05))
            {
                btnSub01.Text = "社員マスタ"; btnSub01.Visible = true; //ボタン１設定
                btnSub02.Text = "部品マスタ"; btnSub02.Visible = true; //ボタン２設定
                btnSub03.Text = "部品分類マスタ"; btnSub03.Visible = true; //ボタン３設定
                btnSub04.Text = "倉庫マスタ"; btnSub04.Visible = true; //ボタン４設定
                btnSub05.Text = "製品マスタ"; btnSub05.Visible = true; //ボタン５設定
                btnSub06.Text = "ラインマスタ"; btnSub06.Visible = true; //ボタン６設定
                btnSub07.Text = "受注先マスタ"; btnSub07.Visible = true; //ボタン７設定
                btnSub08.Text = ""; btnSub08.Visible = false; //ボタン８設定
                btnSub09.Text = ""; btnSub09.Visible = false; //ボタン９設定
                btnSub10.Text = ""; btnSub10.Visible = false; //ボタン１０設定
            }
            

        }

        //////////////////////////////////////////////////
        //サブボタン処理                                //
        //////////////////////////////////////////////////
        private void SubButton_Click(object sender, EventArgs e)
        {
            //サブボタン１処理
            if (sender.Equals(this.btnSub01)){
                if (btnSub01.Text == "受注仮登録") { CT001.ShowDialog(); }
                if (btnSub01.Text == "社員マスタ") { CT003.ShowDialog(); }
                if (btnSub01.Text == "部品仮登録") { CT010.ShowDialog(); }
                
            }

            //サブボタン２処理
            if (sender.Equals(this.btnSub02)){
                if (btnSub02.Text == "部品マスタ") { CT005.ShowDialog(); }
                if (btnSub02.Text == "受注登録") { CT002.ShowDialog(); }
                if (btnSub02.Text == "部品本登録") { CT011.ShowDialog(); }

            }

            //サブボタン３処理
            if (sender.Equals(this.btnSub03)){
                if (btnSub03.Text == "部品分類マスタ") { CT004.ShowDialog(); }
                if (btnSub03.Text == "製品生産") { CT012.ShowDialog(); }

            }

            //サブボタン４処理
            if (sender.Equals(this.btnSub04)) {
                if (btnSub04.Text == "倉庫マスタ") { CT006.ShowDialog(); }
            }

            //サブボタン５処理
            if (sender.Equals(this.btnSub05)){
                if (btnSub05.Text == "製品マスタ") { CT007.ShowDialog(); }
            }

            //サブボタン６処理
            if (sender.Equals(this.btnSub06)){
                if (btnSub06.Text == "ラインマスタ") { CT008.ShowDialog();  }

            }

            //サブボタン７処理
            if (sender.Equals(this.btnSub07)){
                if (btnSub07.Text == "受注先マスタ") { CT009.ShowDialog(); }
            }




        }

        //////////////////////////////////////////////////
        //値取得用フォーム                              //
        //////////////////////////////////////////////////
        public void Showminiform(string strAdminFLG)
        {
            CTMENU CTMENU = new CTMENU();
            CTMENU.strPublicAdminFLG = strAdminFLG;
            CTMENU.ShowDialog();
            CTMENU.Dispose();
            

        }


        //////////////////////////////////////////////////
        //クリア処理                                    //
        //////////////////////////////////////////////////
        private void smClear()
        {
            //サブボタン非表示
            btnSub01.Visible = false;
            btnSub02.Visible = false;
            btnSub03.Visible = false;
            btnSub04.Visible = false;
            btnSub05.Visible = false;
            btnSub06.Visible = false;
            btnSub07.Visible = false;
            btnSub08.Visible = false;
            btnSub09.Visible = false;
            btnSub10.Visible = false;

            //マスタメンテナンス表示
            if (strPublicAdminFLG == "0") { btnMain05.Enabled = false; }

        }



    }
}

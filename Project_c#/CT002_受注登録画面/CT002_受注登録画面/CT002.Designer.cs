namespace CT002_受注登録画面
{
    partial class CT002
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rboNone = new System.Windows.Forms.RadioButton();
            this.rboDelete = new System.Windows.Forms.RadioButton();
            this.rboSubmit = new System.Windows.Forms.RadioButton();
            this.rboSearch03 = new System.Windows.Forms.RadioButton();
            this.rboSearch02 = new System.Windows.Forms.RadioButton();
            this.rboSearch01 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpOrderDateTo = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtpOrderDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrderMSName = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtOrderMSNo = new System.Windows.Forms.TextBox();
            this.btnOrderMSSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnOrderNoSerach02 = new System.Windows.Forms.Button();
            this.dtpOrderNoSearch02 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpOrderNoSearch01 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrderNoSearch01 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrderNoSearch01 = new System.Windows.Forms.TextBox();
            this.btnOrderNoSerach01 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkOrderNOSearch = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHumanMSNo = new System.Windows.Forms.TextBox();
            this.btnHumanMSSearch = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.rboSearch03);
            this.groupBox1.Controls.Add(this.rboSearch02);
            this.groupBox1.Controls.Add(this.rboSearch01);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索条件";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rboNone);
            this.groupBox6.Controls.Add(this.rboDelete);
            this.groupBox6.Controls.Add(this.rboSubmit);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(3, 51);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(921, 49);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "登録、削除確認";
            // 
            // rboNone
            // 
            this.rboNone.AutoSize = true;
            this.rboNone.Location = new System.Drawing.Point(291, 22);
            this.rboNone.Name = "rboNone";
            this.rboNone.Size = new System.Drawing.Size(59, 16);
            this.rboNone.TabIndex = 5;
            this.rboNone.TabStop = true;
            this.rboNone.Text = "未選択";
            this.rboNone.UseVisualStyleBackColor = true;
            // 
            // rboDelete
            // 
            this.rboDelete.AutoSize = true;
            this.rboDelete.Location = new System.Drawing.Point(161, 22);
            this.rboDelete.Name = "rboDelete";
            this.rboDelete.Size = new System.Drawing.Size(47, 16);
            this.rboDelete.TabIndex = 4;
            this.rboDelete.TabStop = true;
            this.rboDelete.Text = "削除";
            this.rboDelete.UseVisualStyleBackColor = true;
            // 
            // rboSubmit
            // 
            this.rboSubmit.AutoSize = true;
            this.rboSubmit.Location = new System.Drawing.Point(16, 22);
            this.rboSubmit.Name = "rboSubmit";
            this.rboSubmit.Size = new System.Drawing.Size(47, 16);
            this.rboSubmit.TabIndex = 3;
            this.rboSubmit.TabStop = true;
            this.rboSubmit.Text = "登録";
            this.rboSubmit.UseVisualStyleBackColor = true;
            // 
            // rboSearch03
            // 
            this.rboSearch03.AutoSize = true;
            this.rboSearch03.Location = new System.Drawing.Point(294, 22);
            this.rboSearch03.Name = "rboSearch03";
            this.rboSearch03.Size = new System.Drawing.Size(59, 16);
            this.rboSearch03.TabIndex = 2;
            this.rboSearch03.TabStop = true;
            this.rboSearch03.Text = "未選択";
            this.rboSearch03.UseVisualStyleBackColor = true;
            // 
            // rboSearch02
            // 
            this.rboSearch02.AutoSize = true;
            this.rboSearch02.Location = new System.Drawing.Point(164, 22);
            this.rboSearch02.Name = "rboSearch02";
            this.rboSearch02.Size = new System.Drawing.Size(63, 16);
            this.rboSearch02.TabIndex = 1;
            this.rboSearch02.TabStop = true;
            this.rboSearch02.Text = "受注NO";
            this.rboSearch02.UseVisualStyleBackColor = true;
            this.rboSearch02.CheckedChanged += new System.EventHandler(this.rbo_CheckedChanged);
            // 
            // rboSearch01
            // 
            this.rboSearch01.AutoSize = true;
            this.rboSearch01.Location = new System.Drawing.Point(19, 22);
            this.rboSearch01.Name = "rboSearch01";
            this.rboSearch01.Size = new System.Drawing.Size(119, 16);
            this.rboSearch01.TabIndex = 0;
            this.rboSearch01.TabStop = true;
            this.rboSearch01.Text = "受注先NO、受注日";
            this.rboSearch01.UseVisualStyleBackColor = true;
            this.rboSearch01.CheckedChanged += new System.EventHandler(this.rbo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpOrderDateTo);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.dtpOrderDateFrom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblOrderMSName);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.txtOrderMSNo);
            this.groupBox2.Controls.Add(this.btnOrderMSSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "受注先NO、受注日検索";
            // 
            // dtpOrderDateTo
            // 
            this.dtpOrderDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDateTo.Location = new System.Drawing.Point(692, 18);
            this.dtpOrderDateTo.Name = "dtpOrderDateTo";
            this.dtpOrderDateTo.Size = new System.Drawing.Size(130, 19);
            this.dtpOrderDateTo.TabIndex = 22;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label3.Location = new System.Drawing.Point(664, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(22, 15);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "～";
            // 
            // dtpOrderDateFrom
            // 
            this.dtpOrderDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDateFrom.Location = new System.Drawing.Point(531, 18);
            this.dtpOrderDateFrom.Name = "dtpOrderDateFrom";
            this.dtpOrderDateFrom.Size = new System.Drawing.Size(130, 19);
            this.dtpOrderDateFrom.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "受注日";
            // 
            // lblOrderMSName
            // 
            this.lblOrderMSName.AutoSize = true;
            this.lblOrderMSName.Location = new System.Drawing.Point(211, 23);
            this.lblOrderMSName.Name = "lblOrderMSName";
            this.lblOrderMSName.Size = new System.Drawing.Size(90, 12);
            this.lblOrderMSName.TabIndex = 14;
            this.lblOrderMSName.Text = "lblOrderMSName";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(17, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 12);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "受注先NO";
            // 
            // txtOrderMSNo
            // 
            this.txtOrderMSNo.Location = new System.Drawing.Point(108, 19);
            this.txtOrderMSNo.MaxLength = 3;
            this.txtOrderMSNo.Name = "txtOrderMSNo";
            this.txtOrderMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtOrderMSNo.TabIndex = 11;
            this.txtOrderMSNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            this.txtOrderMSNo.Leave += new System.EventHandler(this.text_Leave);
            // 
            // btnOrderMSSearch
            // 
            this.btnOrderMSSearch.Location = new System.Drawing.Point(178, 17);
            this.btnOrderMSSearch.Name = "btnOrderMSSearch";
            this.btnOrderMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnOrderMSSearch.TabIndex = 12;
            this.btnOrderMSSearch.Text = "...";
            this.btnOrderMSSearch.UseVisualStyleBackColor = true;
            this.btnOrderMSSearch.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(927, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "受注NO検索";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOrderNoSerach02);
            this.groupBox5.Controls.Add(this.dtpOrderNoSearch02);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.dtpOrderNoSearch01);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lblOrderNoSearch01);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtOrderNoSearch01);
            this.groupBox5.Controls.Add(this.btnOrderNoSerach01);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(921, 94);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // btnOrderNoSerach02
            // 
            this.btnOrderNoSerach02.Location = new System.Drawing.Point(744, 59);
            this.btnOrderNoSerach02.Name = "btnOrderNoSerach02";
            this.btnOrderNoSerach02.Size = new System.Drawing.Size(75, 23);
            this.btnOrderNoSerach02.TabIndex = 31;
            this.btnOrderNoSerach02.Text = "検索";
            this.btnOrderNoSerach02.UseVisualStyleBackColor = true;
            this.btnOrderNoSerach02.Click += new System.EventHandler(this.button_Click);
            // 
            // dtpOrderNoSearch02
            // 
            this.dtpOrderNoSearch02.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderNoSearch02.Location = new System.Drawing.Point(689, 18);
            this.dtpOrderNoSearch02.Name = "dtpOrderNoSearch02";
            this.dtpOrderNoSearch02.Size = new System.Drawing.Size(130, 19);
            this.dtpOrderNoSearch02.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(661, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "～";
            // 
            // dtpOrderNoSearch01
            // 
            this.dtpOrderNoSearch01.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderNoSearch01.Location = new System.Drawing.Point(528, 18);
            this.dtpOrderNoSearch01.Name = "dtpOrderNoSearch01";
            this.dtpOrderNoSearch01.Size = new System.Drawing.Size(130, 19);
            this.dtpOrderNoSearch01.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "受注日";
            // 
            // lblOrderNoSearch01
            // 
            this.lblOrderNoSearch01.AutoSize = true;
            this.lblOrderNoSearch01.Location = new System.Drawing.Point(208, 23);
            this.lblOrderNoSearch01.Name = "lblOrderNoSearch01";
            this.lblOrderNoSearch01.Size = new System.Drawing.Size(106, 12);
            this.lblOrderNoSearch01.TabIndex = 26;
            this.lblOrderNoSearch01.Text = "lblOrderNoSearch01";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "受注先NO";
            // 
            // txtOrderNoSearch01
            // 
            this.txtOrderNoSearch01.Location = new System.Drawing.Point(105, 19);
            this.txtOrderNoSearch01.MaxLength = 3;
            this.txtOrderNoSearch01.Name = "txtOrderNoSearch01";
            this.txtOrderNoSearch01.Size = new System.Drawing.Size(70, 19);
            this.txtOrderNoSearch01.TabIndex = 23;
            this.txtOrderNoSearch01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            this.txtOrderNoSearch01.Leave += new System.EventHandler(this.text_Leave);
            // 
            // btnOrderNoSerach01
            // 
            this.btnOrderNoSerach01.Location = new System.Drawing.Point(175, 17);
            this.btnOrderNoSerach01.Name = "btnOrderNoSerach01";
            this.btnOrderNoSerach01.Size = new System.Drawing.Size(27, 23);
            this.btnOrderNoSerach01.TabIndex = 24;
            this.btnOrderNoSerach01.Text = "...";
            this.btnOrderNoSerach01.UseVisualStyleBackColor = true;
            this.btnOrderNoSerach01.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkOrderNOSearch);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtOrderNo);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(921, 51);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // chkOrderNOSearch
            // 
            this.chkOrderNOSearch.AutoSize = true;
            this.chkOrderNOSearch.Location = new System.Drawing.Point(210, 19);
            this.chkOrderNOSearch.Name = "chkOrderNOSearch";
            this.chkOrderNOSearch.Size = new System.Drawing.Size(97, 16);
            this.chkOrderNOSearch.TabIndex = 16;
            this.chkOrderNOSearch.Text = "受注NOを検索";
            this.chkOrderNOSearch.UseVisualStyleBackColor = true;
            this.chkOrderNOSearch.CheckedChanged += new System.EventHandler(this.rbo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "受注NO";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(105, 17);
            this.txtOrderNo.MaxLength = 3;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(70, 19);
            this.txtOrderNo.TabIndex = 5;
            this.txtOrderNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnEnd);
            this.groupBox7.Controls.Add(this.btnClear);
            this.groupBox7.Controls.Add(this.btnSubmit);
            this.groupBox7.Controls.Add(this.btnSearch);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.Location = new System.Drawing.Point(0, 684);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(927, 49);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(826, 18);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "F4:終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.button_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(734, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "F3:クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(108, 18);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "F2:";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(19, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "F1:検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.txtHumanMSNo);
            this.groupBox8.Controls.Add(this.btnHumanMSSearch);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox8.Location = new System.Drawing.Point(0, 632);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(927, 52);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "更新担当者";
            // 
            // txtHumanMSNo
            // 
            this.txtHumanMSNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtHumanMSNo.Location = new System.Drawing.Point(108, 21);
            this.txtHumanMSNo.MaxLength = 7;
            this.txtHumanMSNo.Name = "txtHumanMSNo";
            this.txtHumanMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtHumanMSNo.TabIndex = 14;
            // 
            // btnHumanMSSearch
            // 
            this.btnHumanMSSearch.Location = new System.Drawing.Point(178, 19);
            this.btnHumanMSSearch.Name = "btnHumanMSSearch";
            this.btnHumanMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnHumanMSSearch.TabIndex = 15;
            this.btnHumanMSSearch.Text = "...";
            this.btnHumanMSSearch.UseVisualStyleBackColor = true;
            this.btnHumanMSSearch.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dataGridView1);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(0, 328);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(927, 304);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(921, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // CT002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 733);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "CT002";
            this.Text = "CT002_受注登録画面";
            this.Load += new System.EventHandler(this.CT002_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CT002_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rboSearch03;
        private System.Windows.Forms.RadioButton rboSearch02;
        private System.Windows.Forms.RadioButton rboSearch01;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DateTimePicker dtpOrderDateTo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker dtpOrderDateFrom;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label lblOrderMSName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtOrderMSNo;
        private System.Windows.Forms.Button btnOrderMSSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnOrderNoSerach02;
        internal System.Windows.Forms.DateTimePicker dtpOrderNoSearch02;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.DateTimePicker dtpOrderNoSearch01;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lblOrderNoSearch01;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtOrderNoSearch01;
        private System.Windows.Forms.Button btnOrderNoSerach01;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.CheckBox chkOrderNOSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rboNone;
        private System.Windows.Forms.RadioButton rboDelete;
        private System.Windows.Forms.RadioButton rboSubmit;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtHumanMSNo;
        private System.Windows.Forms.Button btnHumanMSSearch;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.DataGridView dataGridView1;
    }
}


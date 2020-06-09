namespace CT005_部品マスタメンテナンス
{
    partial class CT005
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
            this.btnSearchPartsCodeSearch = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSearchPartsCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnPartsClassNoSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPartsClassNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPartsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartsCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartsNo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOriginalMoney = new System.Windows.Forms.TextBox();
            this.btnHumanNoSearch = new System.Windows.Forms.Button();
            this.txtHumanNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdateMoney = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchPartsCodeSearch);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.txtSearchPartsCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnSearchPartsCodeSearch
            // 
            this.btnSearchPartsCodeSearch.Location = new System.Drawing.Point(225, 14);
            this.btnSearchPartsCodeSearch.Name = "btnSearchPartsCodeSearch";
            this.btnSearchPartsCodeSearch.Size = new System.Drawing.Size(27, 23);
            this.btnSearchPartsCodeSearch.TabIndex = 2;
            this.btnSearchPartsCodeSearch.Text = "...";
            this.btnSearchPartsCodeSearch.UseVisualStyleBackColor = true;
            this.btnSearchPartsCodeSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 12);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "部品コード";
            // 
            // txtSearchPartsCode
            // 
            this.txtSearchPartsCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtSearchPartsCode.Location = new System.Drawing.Point(120, 16);
            this.txtSearchPartsCode.MaxLength = 10;
            this.txtSearchPartsCode.Name = "txtSearchPartsCode";
            this.txtSearchPartsCode.Size = new System.Drawing.Size(103, 19);
            this.txtSearchPartsCode.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnd);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(552, 18);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "F5:終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(459, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "F4:クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(193, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "F3:削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(103, 19);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "F2:更新";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(14, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "F1:検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbcMain);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(639, 337);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabPage1);
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(3, 15);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(633, 319);
            this.tbcMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblMode);
            this.tabPage1.Controls.Add(this.btnPartsClassNoSearch);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtPartsClassNo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPartsName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPartsCode);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPartsNo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "部品情報";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMode.Location = new System.Drawing.Point(528, 250);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(51, 12);
            this.lblMode.TabIndex = 33;
            this.lblMode.Text = "lblMode";
            // 
            // btnPartsClassNoSearch
            // 
            this.btnPartsClassNoSearch.Location = new System.Drawing.Point(144, 149);
            this.btnPartsClassNoSearch.Name = "btnPartsClassNoSearch";
            this.btnPartsClassNoSearch.Size = new System.Drawing.Size(27, 23);
            this.btnPartsClassNoSearch.TabIndex = 5;
            this.btnPartsClassNoSearch.Text = "...";
            this.btnPartsClassNoSearch.UseVisualStyleBackColor = true;
            this.btnPartsClassNoSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "部品分類NO";
            // 
            // txtPartsClassNo
            // 
            this.txtPartsClassNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPartsClassNo.Location = new System.Drawing.Point(113, 151);
            this.txtPartsClassNo.MaxLength = 3;
            this.txtPartsClassNo.Name = "txtPartsClassNo";
            this.txtPartsClassNo.Size = new System.Drawing.Size(29, 19);
            this.txtPartsClassNo.TabIndex = 4;
            this.txtPartsClassNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "部品名";
            // 
            // txtPartsName
            // 
            this.txtPartsName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPartsName.Location = new System.Drawing.Point(113, 105);
            this.txtPartsName.MaxLength = 40;
            this.txtPartsName.Name = "txtPartsName";
            this.txtPartsName.Size = new System.Drawing.Size(284, 19);
            this.txtPartsName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "部品コード";
            // 
            // txtPartsCode
            // 
            this.txtPartsCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPartsCode.Location = new System.Drawing.Point(113, 62);
            this.txtPartsCode.MaxLength = 10;
            this.txtPartsCode.Name = "txtPartsCode";
            this.txtPartsCode.Size = new System.Drawing.Size(103, 19);
            this.txtPartsCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "部品NO";
            // 
            // txtPartsNo
            // 
            this.txtPartsNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPartsNo.Location = new System.Drawing.Point(113, 21);
            this.txtPartsNo.MaxLength = 10;
            this.txtPartsNo.Name = "txtPartsNo";
            this.txtPartsNo.Size = new System.Drawing.Size(70, 19);
            this.txtPartsNo.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "単価情報";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(619, 192);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "更新履歴";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(613, 174);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtOriginalMoney);
            this.groupBox4.Controls.Add(this.btnHumanNoSearch);
            this.groupBox4.Controls.Add(this.txtHumanNo);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtUpdateMoney);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(619, 95);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "単価更新";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 54;
            this.label8.Text = "元の単価";
            // 
            // txtOriginalMoney
            // 
            this.txtOriginalMoney.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtOriginalMoney.Location = new System.Drawing.Point(324, 21);
            this.txtOriginalMoney.MaxLength = 6;
            this.txtOriginalMoney.Name = "txtOriginalMoney";
            this.txtOriginalMoney.Size = new System.Drawing.Size(65, 19);
            this.txtOriginalMoney.TabIndex = 53;
            // 
            // btnHumanNoSearch
            // 
            this.btnHumanNoSearch.Location = new System.Drawing.Point(175, 52);
            this.btnHumanNoSearch.Name = "btnHumanNoSearch";
            this.btnHumanNoSearch.Size = new System.Drawing.Size(24, 23);
            this.btnHumanNoSearch.TabIndex = 3;
            this.btnHumanNoSearch.Text = "...";
            this.btnHumanNoSearch.UseVisualStyleBackColor = true;
            this.btnHumanNoSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // txtHumanNo
            // 
            this.txtHumanNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtHumanNo.Location = new System.Drawing.Point(88, 54);
            this.txtHumanNo.MaxLength = 10;
            this.txtHumanNo.Name = "txtHumanNo";
            this.txtHumanNo.Size = new System.Drawing.Size(87, 19);
            this.txtHumanNo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 52;
            this.label6.Text = "更新担当者";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 51;
            this.label7.Text = "単価";
            // 
            // txtUpdateMoney
            // 
            this.txtUpdateMoney.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUpdateMoney.Location = new System.Drawing.Point(88, 21);
            this.txtUpdateMoney.MaxLength = 6;
            this.txtUpdateMoney.Name = "txtUpdateMoney";
            this.txtUpdateMoney.Size = new System.Drawing.Size(65, 19);
            this.txtUpdateMoney.TabIndex = 1;
            this.txtUpdateMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // CT005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 442);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "CT005";
            this.Text = "CT005_部品マスタメンテナンス";
            this.Load += new System.EventHandler(this.CT005_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CT005_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchPartsCodeSearch;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSearchPartsCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPartsClassNoSearch;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtPartsClassNo;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtPartsName;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtPartsCode;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtPartsNo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Button btnHumanNoSearch;
        internal System.Windows.Forms.TextBox txtHumanNo;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtUpdateMoney;
        internal System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSubmit;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtOriginalMoney;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
    }
}


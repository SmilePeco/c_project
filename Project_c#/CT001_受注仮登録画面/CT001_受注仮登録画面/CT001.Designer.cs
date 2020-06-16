namespace CT001_受注仮登録画面
{
    partial class CT001
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
            this.chkNoneWorkLine = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHumanMSNo = new System.Windows.Forms.TextBox();
            this.btnHumanMSSearch = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProductMSSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWorklineMSName = new System.Windows.Forms.Label();
            this.btnWorklineMSSearch = new System.Windows.Forms.Button();
            this.txtWorklineMSNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblOrderMSName = new System.Windows.Forms.Label();
            this.btnOrderMSSearch = new System.Windows.Forms.Button();
            this.txtOrderMSNo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNoneWorkLine);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOrderNo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chkNoneWorkLine
            // 
            this.chkNoneWorkLine.AutoSize = true;
            this.chkNoneWorkLine.Location = new System.Drawing.Point(241, 18);
            this.chkNoneWorkLine.Name = "chkNoneWorkLine";
            this.chkNoneWorkLine.Size = new System.Drawing.Size(136, 16);
            this.chkNoneWorkLine.TabIndex = 1;
            this.chkNoneWorkLine.Text = "作業ラインを使用しない";
            this.chkNoneWorkLine.UseVisualStyleBackColor = true;
            this.chkNoneWorkLine.CheckedChanged += new System.EventHandler(this.Checkbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "受注NO";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(76, 16);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(70, 19);
            this.txtOrderNo.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEnd);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnSubmit);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(745, 57);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(658, 18);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "F3:終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.button_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(563, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "F2:クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(14, 18);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "F1:登録";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtHumanMSNo);
            this.groupBox5.Controls.Add(this.btnHumanMSSearch);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 306);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(745, 51);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "更新担当者";
            // 
            // txtHumanMSNo
            // 
            this.txtHumanMSNo.Location = new System.Drawing.Point(103, 20);
            this.txtHumanMSNo.Name = "txtHumanMSNo";
            this.txtHumanMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtHumanMSNo.TabIndex = 1;
            // 
            // btnHumanMSSearch
            // 
            this.btnHumanMSSearch.Location = new System.Drawing.Point(173, 18);
            this.btnHumanMSSearch.Name = "btnHumanMSSearch";
            this.btnHumanMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnHumanMSSearch.TabIndex = 2;
            this.btnHumanMSSearch.Text = "...";
            this.btnHumanMSSearch.UseVisualStyleBackColor = true;
            this.btnHumanMSSearch.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tabControl1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 54);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(745, 252);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 234);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Controls.Add(this.lblOrderMSName);
            this.tabPage1.Controls.Add(this.btnOrderMSSearch);
            this.tabPage1.Controls.Add(this.txtOrderMSNo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "受注情報";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProductMSSearch);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblProductName);
            this.groupBox2.Controls.Add(this.txtProductCode);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnProductMSSearch
            // 
            this.btnProductMSSearch.Location = new System.Drawing.Point(177, 30);
            this.btnProductMSSearch.Name = "btnProductMSSearch";
            this.btnProductMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnProductMSSearch.TabIndex = 2;
            this.btnProductMSSearch.Text = "...";
            this.btnProductMSSearch.UseVisualStyleBackColor = true;
            this.btnProductMSSearch.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblWorklineMSName);
            this.groupBox3.Controls.Add(this.btnWorklineMSSearch);
            this.groupBox3.Controls.Add(this.txtWorklineMSNo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(719, 78);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "作業ラインNO";
            // 
            // lblWorklineMSName
            // 
            this.lblWorklineMSName.AutoSize = true;
            this.lblWorklineMSName.Location = new System.Drawing.Point(205, 36);
            this.lblWorklineMSName.Name = "lblWorklineMSName";
            this.lblWorklineMSName.Size = new System.Drawing.Size(128, 12);
            this.lblWorklineMSName.TabIndex = 15;
            this.lblWorklineMSName.Text = "lblWorkProcessMSName";
            // 
            // btnWorklineMSSearch
            // 
            this.btnWorklineMSSearch.Location = new System.Drawing.Point(102, 30);
            this.btnWorklineMSSearch.Name = "btnWorklineMSSearch";
            this.btnWorklineMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnWorklineMSSearch.TabIndex = 1;
            this.btnWorklineMSSearch.Text = "...";
            this.btnWorklineMSSearch.UseVisualStyleBackColor = true;
            this.btnWorklineMSSearch.Click += new System.EventHandler(this.button_Click);
            // 
            // txtWorklineMSNo
            // 
            this.txtWorklineMSNo.Location = new System.Drawing.Point(129, 32);
            this.txtWorklineMSNo.MaxLength = 3;
            this.txtWorklineMSNo.Name = "txtWorklineMSNo";
            this.txtWorklineMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtWorklineMSNo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "製品コード";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(208, 36);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(85, 12);
            this.lblProductName.TabIndex = 19;
            this.lblProductName.Text = "lblProductName";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(105, 32);
            this.txtProductCode.MaxLength = 10;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(70, 19);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.Leave += new System.EventHandler(this.text_Leave);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(17, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 12);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "受注先NO";
            // 
            // lblOrderMSName
            // 
            this.lblOrderMSName.AutoSize = true;
            this.lblOrderMSName.Location = new System.Drawing.Point(211, 27);
            this.lblOrderMSName.Name = "lblOrderMSName";
            this.lblOrderMSName.Size = new System.Drawing.Size(90, 12);
            this.lblOrderMSName.TabIndex = 10;
            this.lblOrderMSName.Text = "lblOrderMSName";
            // 
            // btnOrderMSSearch
            // 
            this.btnOrderMSSearch.Location = new System.Drawing.Point(178, 21);
            this.btnOrderMSSearch.Name = "btnOrderMSSearch";
            this.btnOrderMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnOrderMSSearch.TabIndex = 2;
            this.btnOrderMSSearch.Text = "...";
            this.btnOrderMSSearch.UseVisualStyleBackColor = true;
            this.btnOrderMSSearch.Click += new System.EventHandler(this.button_Click);
            // 
            // txtOrderMSNo
            // 
            this.txtOrderMSNo.Location = new System.Drawing.Point(108, 23);
            this.txtOrderMSNo.MaxLength = 3;
            this.txtOrderMSNo.Name = "txtOrderMSNo";
            this.txtOrderMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtOrderMSNo.TabIndex = 1;
            this.txtOrderMSNo.Leave += new System.EventHandler(this.text_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtOrderNumber);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "受注数・金額情報";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(110, 22);
            this.txtOrderNumber.MaxLength = 5;
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(70, 19);
            this.txtOrderNumber.TabIndex = 1;
            this.txtOrderNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrderNumber_KeyDown);
            this.txtOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(204, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "※Enterキー押下で、受注金額が最新化されます。";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.txtOrderPrice);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.txtOrderUnitPrice);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox7.Location = new System.Drawing.Point(3, 83);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(725, 122);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "受注金額";
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.Location = new System.Drawing.Point(107, 80);
            this.txtOrderPrice.MaxLength = 5;
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.Size = new System.Drawing.Size(70, 19);
            this.txtOrderPrice.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "受注単価";
            // 
            // txtOrderUnitPrice
            // 
            this.txtOrderUnitPrice.Location = new System.Drawing.Point(107, 30);
            this.txtOrderUnitPrice.MaxLength = 5;
            this.txtOrderUnitPrice.Name = "txtOrderUnitPrice";
            this.txtOrderUnitPrice.Size = new System.Drawing.Size(70, 19);
            this.txtOrderUnitPrice.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "受注数";
            // 
            // CT001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 414);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "CT001";
            this.Text = "CT001_受注仮登録画面";
            this.Load += new System.EventHandler(this.CT001_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CT001_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtHumanMSNo;
        private System.Windows.Forms.Button btnHumanMSSearch;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lblWorklineMSName;
        private System.Windows.Forms.Button btnWorklineMSSearch;
        internal System.Windows.Forms.TextBox txtWorklineMSNo;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lblProductName;
        internal System.Windows.Forms.TextBox txtProductCode;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblOrderMSName;
        private System.Windows.Forms.Button btnOrderMSSearch;
        internal System.Windows.Forms.TextBox txtOrderMSNo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtOrderPrice;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtOrderUnitPrice;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.CheckBox chkNoneWorkLine;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnProductMSSearch;
    }
}


namespace CT010_部品仮登録画面
{
    partial class CT010
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
            this.lblPartsName = new System.Windows.Forms.Label();
            this.btnPartsMSSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartsCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHumanMSNo = new System.Windows.Forms.TextBox();
            this.btnHumanMSSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartsNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartsNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPartsName);
            this.groupBox1.Controls.Add(this.btnPartsMSSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPartsCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblPartsName
            // 
            this.lblPartsName.AutoSize = true;
            this.lblPartsName.Location = new System.Drawing.Point(220, 25);
            this.lblPartsName.Name = "lblPartsName";
            this.lblPartsName.Size = new System.Drawing.Size(73, 12);
            this.lblPartsName.TabIndex = 15;
            this.lblPartsName.Text = "lblPartsName";
            // 
            // btnPartsMSSearch
            // 
            this.btnPartsMSSearch.Location = new System.Drawing.Point(187, 20);
            this.btnPartsMSSearch.Name = "btnPartsMSSearch";
            this.btnPartsMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnPartsMSSearch.TabIndex = 2;
            this.btnPartsMSSearch.Text = "...";
            this.btnPartsMSSearch.UseVisualStyleBackColor = true;
            this.btnPartsMSSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "部品コード";
            // 
            // txtPartsCode
            // 
            this.txtPartsCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPartsCode.Location = new System.Drawing.Point(93, 22);
            this.txtPartsCode.MaxLength = 10;
            this.txtPartsCode.Name = "txtPartsCode";
            this.txtPartsCode.Size = new System.Drawing.Size(91, 19);
            this.txtPartsCode.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.btnEnd);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 49);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(120, 18);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "F2:登録";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(497, 18);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "F4:終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(402, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "F3:クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(14, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "F1:検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtHumanMSNo);
            this.groupBox5.Controls.Add(this.btnHumanMSSearch);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(593, 51);
            this.groupBox5.TabIndex = 3;
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
            this.txtHumanMSNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtHumanMSNo.Location = new System.Drawing.Point(103, 20);
            this.txtHumanMSNo.MaxLength = 15;
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
            this.btnHumanMSSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtPartsNumber);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtPartsNo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 187);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "登録数";
            // 
            // txtPartsNumber
            // 
            this.txtPartsNumber.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPartsNumber.Location = new System.Drawing.Point(93, 76);
            this.txtPartsNumber.MaxLength = 5;
            this.txtPartsNumber.Name = "txtPartsNumber";
            this.txtPartsNumber.Size = new System.Drawing.Size(91, 19);
            this.txtPartsNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "部品登録NO";
            // 
            // txtPartsNo
            // 
            this.txtPartsNo.Location = new System.Drawing.Point(93, 27);
            this.txtPartsNo.Name = "txtPartsNo";
            this.txtPartsNo.Size = new System.Drawing.Size(91, 19);
            this.txtPartsNo.TabIndex = 1;
            // 
            // CT010
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 344);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "CT010";
            this.Text = "CT010_部品仮登録画面";
            this.Load += new System.EventHandler(this.CT010_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CT010_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPartsMSSearch;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtPartsCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Label lblPartsName;
        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtHumanMSNo;
        private System.Windows.Forms.Button btnHumanMSSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtPartsNumber;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtPartsNo;
    }
}


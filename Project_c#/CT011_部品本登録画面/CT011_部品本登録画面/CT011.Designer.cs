namespace CT011_部品本登録画面
{
    partial class CT011
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
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHumanMSNo = new System.Windows.Forms.TextBox();
            this.btnHumanMSSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPartsName = new System.Windows.Forms.Label();
            this.btnPartsMSSearch = new System.Windows.Forms.Button();
            this.txtPartsCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSubmitFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSubmitTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 45);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cboClass
            // 
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(84, 15);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(91, 20);
            this.cboClass.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "分類";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.btnEnd);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 41);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(117, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "F2:登録";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(647, 12);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "F4:終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(552, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "F3:クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(11, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "F1:検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtHumanMSNo);
            this.groupBox3.Controls.Add(this.btnHumanMSSearch);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(734, 48);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "更新担当者";
            // 
            // txtHumanMSNo
            // 
            this.txtHumanMSNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtHumanMSNo.Location = new System.Drawing.Point(103, 21);
            this.txtHumanMSNo.MaxLength = 15;
            this.txtHumanMSNo.Name = "txtHumanMSNo";
            this.txtHumanMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtHumanMSNo.TabIndex = 1;
            // 
            // btnHumanMSSearch
            // 
            this.btnHumanMSSearch.Location = new System.Drawing.Point(173, 19);
            this.btnHumanMSSearch.Name = "btnHumanMSSearch";
            this.btnHumanMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnHumanMSSearch.TabIndex = 2;
            this.btnHumanMSSearch.Text = "...";
            this.btnHumanMSSearch.UseVisualStyleBackColor = true;
            this.btnHumanMSSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "部品コード";
            // 
            // lblPartsName
            // 
            this.lblPartsName.AutoSize = true;
            this.lblPartsName.Location = new System.Drawing.Point(211, 29);
            this.lblPartsName.Name = "lblPartsName";
            this.lblPartsName.Size = new System.Drawing.Size(73, 12);
            this.lblPartsName.TabIndex = 18;
            this.lblPartsName.Text = "lblPartsName";
            // 
            // btnPartsMSSearch
            // 
            this.btnPartsMSSearch.Location = new System.Drawing.Point(178, 24);
            this.btnPartsMSSearch.Name = "btnPartsMSSearch";
            this.btnPartsMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnPartsMSSearch.TabIndex = 2;
            this.btnPartsMSSearch.Text = "...";
            this.btnPartsMSSearch.UseVisualStyleBackColor = true;
            this.btnPartsMSSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // txtPartsCode
            // 
            this.txtPartsCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPartsCode.Location = new System.Drawing.Point(84, 26);
            this.txtPartsCode.MaxLength = 10;
            this.txtPartsCode.Name = "txtPartsCode";
            this.txtPartsCode.Size = new System.Drawing.Size(91, 19);
            this.txtPartsCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "登録日";
            // 
            // dtpSubmitFrom
            // 
            this.dtpSubmitFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSubmitFrom.Location = new System.Drawing.Point(84, 60);
            this.dtpSubmitFrom.Name = "dtpSubmitFrom";
            this.dtpSubmitFrom.Size = new System.Drawing.Size(121, 19);
            this.dtpSubmitFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "～";
            // 
            // dtpSubmitTo
            // 
            this.dtpSubmitTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSubmitTo.Location = new System.Drawing.Point(234, 60);
            this.dtpSubmitTo.Name = "dtpSubmitTo";
            this.dtpSubmitTo.Size = new System.Drawing.Size(121, 19);
            this.dtpSubmitTo.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtpSubmitTo);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtPartsCode);
            this.groupBox5.Controls.Add(this.dtpSubmitFrom);
            this.groupBox5.Controls.Add(this.btnPartsMSSearch);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.lblPartsName);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(734, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(734, 250);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
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
            this.dataGridView1.Size = new System.Drawing.Size(728, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // CT011
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 484);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "CT011";
            this.Text = "CT011_部品本登録";
            this.Load += new System.EventHandler(this.CT011_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CT011_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpSubmitTo;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSubmitFrom;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblPartsName;
        private System.Windows.Forms.Button btnPartsMSSearch;
        internal System.Windows.Forms.TextBox txtPartsCode;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtHumanMSNo;
        private System.Windows.Forms.Button btnHumanMSSearch;
        private System.Windows.Forms.ComboBox cboClass;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}


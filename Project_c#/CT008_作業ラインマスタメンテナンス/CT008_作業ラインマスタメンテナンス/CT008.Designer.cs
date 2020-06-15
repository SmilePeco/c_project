namespace CT008_作業ラインマスタメンテナンス
{
    partial class CT008
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.btnProductCodeSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProcessNo = new System.Windows.Forms.TextBox();
            this.btnProcessNoSearch = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHumanMSNo = new System.Windows.Forms.TextBox();
            this.btnHumanMSSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorklineName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtWorklineNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSerach = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblProcessName);
            this.groupBox3.Controls.Add(this.lblProductName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtProductCode);
            this.groupBox3.Controls.Add(this.btnProductCodeSearch);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtProcessNo);
            this.groupBox3.Controls.Add(this.btnProcessNoSearch);
            this.groupBox3.Controls.Add(this.lblMode);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtHumanMSNo);
            this.groupBox3.Controls.Add(this.btnHumanMSSearch);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtWorklineName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 251);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 38;
            this.label4.Text = "製品コード";
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductCode.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtProductCode.Location = new System.Drawing.Point(120, 114);
            this.txtProductCode.MaxLength = 7;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(100, 19);
            this.txtProductCode.TabIndex = 4;
            // 
            // btnProductCodeSearch
            // 
            this.btnProductCodeSearch.Location = new System.Drawing.Point(223, 112);
            this.btnProductCodeSearch.Name = "btnProductCodeSearch";
            this.btnProductCodeSearch.Size = new System.Drawing.Size(27, 23);
            this.btnProductCodeSearch.TabIndex = 5;
            this.btnProductCodeSearch.Text = "...";
            this.btnProductCodeSearch.UseVisualStyleBackColor = true;
            this.btnProductCodeSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "工程NO";
            // 
            // txtProcessNo
            // 
            this.txtProcessNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtProcessNo.Location = new System.Drawing.Point(120, 70);
            this.txtProcessNo.MaxLength = 7;
            this.txtProcessNo.Name = "txtProcessNo";
            this.txtProcessNo.Size = new System.Drawing.Size(70, 19);
            this.txtProcessNo.TabIndex = 2;
            // 
            // btnProcessNoSearch
            // 
            this.btnProcessNoSearch.Location = new System.Drawing.Point(190, 68);
            this.btnProcessNoSearch.Name = "btnProcessNoSearch";
            this.btnProcessNoSearch.Size = new System.Drawing.Size(27, 23);
            this.btnProcessNoSearch.TabIndex = 3;
            this.btnProcessNoSearch.Text = "...";
            this.btnProcessNoSearch.UseVisualStyleBackColor = true;
            this.btnProcessNoSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMode.Location = new System.Drawing.Point(524, 220);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(51, 12);
            this.lblMode.TabIndex = 32;
            this.lblMode.Text = "lblMode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "更新担当者";
            // 
            // txtHumanMSNo
            // 
            this.txtHumanMSNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtHumanMSNo.Location = new System.Drawing.Point(120, 155);
            this.txtHumanMSNo.MaxLength = 7;
            this.txtHumanMSNo.Name = "txtHumanMSNo";
            this.txtHumanMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtHumanMSNo.TabIndex = 6;
            // 
            // btnHumanMSSearch
            // 
            this.btnHumanMSSearch.Location = new System.Drawing.Point(190, 153);
            this.btnHumanMSSearch.Name = "btnHumanMSSearch";
            this.btnHumanMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnHumanMSSearch.TabIndex = 7;
            this.btnHumanMSSearch.Text = "...";
            this.btnHumanMSSearch.UseVisualStyleBackColor = true;
            this.btnHumanMSSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "作業ライン名";
            // 
            // txtWorklineName
            // 
            this.txtWorklineName.Location = new System.Drawing.Point(120, 27);
            this.txtWorklineName.MaxLength = 12;
            this.txtWorklineName.Name = "txtWorklineName";
            this.txtWorklineName.Size = new System.Drawing.Size(217, 19);
            this.txtWorklineName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.txtWorklineNo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 12);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "作業ラインNO";
            // 
            // txtWorklineNo
            // 
            this.txtWorklineNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtWorklineNo.Location = new System.Drawing.Point(120, 26);
            this.txtWorklineNo.MaxLength = 3;
            this.txtWorklineNo.Name = "txtWorklineNo";
            this.txtWorklineNo.Size = new System.Drawing.Size(70, 19);
            this.txtWorklineNo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnd);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.btnSerach);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 48);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(514, 17);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "F5:終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(424, 17);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "F4:クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(201, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "F3:削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(105, 17);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "F2:更新";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnSerach
            // 
            this.btnSerach.Location = new System.Drawing.Point(14, 17);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(75, 23);
            this.btnSerach.TabIndex = 1;
            this.btnSerach.Text = "F1:検索";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(252, 117);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(85, 12);
            this.lblProductName.TabIndex = 39;
            this.lblProductName.Text = "lblProductName";
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(221, 73);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(87, 12);
            this.lblProcessName.TabIndex = 40;
            this.lblProcessName.Text = "lblProcessName";
            // 
            // CT008
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 368);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.Name = "CT008";
            this.Text = "CT008_作業ラインマスタメンテナンス";
            this.Load += new System.EventHandler(this.CT008_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CT008_KeyDown);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Button btnProductCodeSearch;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtProcessNo;
        private System.Windows.Forms.Button btnProcessNoSearch;
        internal System.Windows.Forms.Label lblMode;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtHumanMSNo;
        private System.Windows.Forms.Button btnHumanMSSearch;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtWorklineName;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtWorklineNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.Label lblProductName;
    }
}


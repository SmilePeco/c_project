namespace CT004_部品分類マスタメンテナンス
{
    partial class CT004
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPartsClassNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSerach = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHumanMSNo = new System.Windows.Forms.TextBox();
            this.btnHumanMSSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartsClassName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.txtPartsClassNo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 12);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "部品分類NO";
            // 
            // txtPartsClassNo
            // 
            this.txtPartsClassNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPartsClassNo.Location = new System.Drawing.Point(120, 26);
            this.txtPartsClassNo.MaxLength = 3;
            this.txtPartsClassNo.Name = "txtPartsClassNo";
            this.txtPartsClassNo.Size = new System.Drawing.Size(70, 19);
            this.txtPartsClassNo.TabIndex = 1;
            this.txtPartsClassNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnd);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.btnSerach);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 48);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(508, 17);
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
            this.btnClear.Location = new System.Drawing.Point(418, 17);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMode);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtHumanMSNo);
            this.groupBox3.Controls.Add(this.btnHumanMSSearch);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPartsClassName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 211);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMode.Location = new System.Drawing.Point(518, 180);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(51, 12);
            this.lblMode.TabIndex = 32;
            this.lblMode.Text = "lblMode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "更新担当者";
            // 
            // txtHumanMSNo
            // 
            this.txtHumanMSNo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtHumanMSNo.Location = new System.Drawing.Point(120, 74);
            this.txtHumanMSNo.MaxLength = 7;
            this.txtHumanMSNo.Name = "txtHumanMSNo";
            this.txtHumanMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtHumanMSNo.TabIndex = 2;
            // 
            // btnHumanMSSearch
            // 
            this.btnHumanMSSearch.Location = new System.Drawing.Point(190, 72);
            this.btnHumanMSSearch.Name = "btnHumanMSSearch";
            this.btnHumanMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnHumanMSSearch.TabIndex = 3;
            this.btnHumanMSSearch.Text = "...";
            this.btnHumanMSSearch.UseVisualStyleBackColor = true;
            this.btnHumanMSSearch.Click += new System.EventHandler(this.Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "部品分類名";
            // 
            // txtPartsClassName
            // 
            this.txtPartsClassName.Location = new System.Drawing.Point(120, 27);
            this.txtPartsClassName.MaxLength = 12;
            this.txtPartsClassName.Name = "txtPartsClassName";
            this.txtPartsClassName.Size = new System.Drawing.Size(217, 19);
            this.txtPartsClassName.TabIndex = 1;
            // 
            // CT004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 328);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "CT004";
            this.Text = "CT004_部品分類マスタメンテナンス";
            this.Load += new System.EventHandler(this.CT004_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CT004_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtPartsClassNo;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtHumanMSNo;
        private System.Windows.Forms.Button btnHumanMSSearch;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtPartsClassName;
        private System.Windows.Forms.Button btnSerach;
        internal System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
    }
}


namespace CT001_受注登録画面
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
            this.txtOrderMSNo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnOrderMSSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWorkProcessMSName = new System.Windows.Forms.Label();
            this.lblOrderMSName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorkProcessMSNo = new System.Windows.Forms.TextBox();
            this.btnWorkProcessMSSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHumanMSNo = new System.Windows.Forms.TextBox();
            this.btnHumanMSSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrderMSNo
            // 
            this.txtOrderMSNo.Location = new System.Drawing.Point(103, 21);
            this.txtOrderMSNo.MaxLength = 3;
            this.txtOrderMSNo.Name = "txtOrderMSNo";
            this.txtOrderMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtOrderMSNo.TabIndex = 1;
            this.txtOrderMSNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            this.txtOrderMSNo.Leave += new System.EventHandler(this.text_Leave);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 12);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "受注先NO";
            // 
            // btnOrderMSSearch
            // 
            this.btnOrderMSSearch.Location = new System.Drawing.Point(173, 19);
            this.btnOrderMSSearch.Name = "btnOrderMSSearch";
            this.btnOrderMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnOrderMSSearch.TabIndex = 2;
            this.btnOrderMSSearch.Text = "...";
            this.btnOrderMSSearch.UseVisualStyleBackColor = true;
            this.btnOrderMSSearch.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOrderNo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWorkProcessMSName);
            this.groupBox2.Controls.Add(this.lblOrderMSName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtWorkProcessMSNo);
            this.groupBox2.Controls.Add(this.btnWorkProcessMSSearch);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.txtOrderMSNo);
            this.groupBox2.Controls.Add(this.btnOrderMSSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 116);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lblWorkProcessMSName
            // 
            this.lblWorkProcessMSName.AutoSize = true;
            this.lblWorkProcessMSName.Location = new System.Drawing.Point(206, 73);
            this.lblWorkProcessMSName.Name = "lblWorkProcessMSName";
            this.lblWorkProcessMSName.Size = new System.Drawing.Size(128, 12);
            this.lblWorkProcessMSName.TabIndex = 11;
            this.lblWorkProcessMSName.Text = "lblWorkProcessMSName";
            // 
            // lblOrderMSName
            // 
            this.lblOrderMSName.AutoSize = true;
            this.lblOrderMSName.Location = new System.Drawing.Point(206, 25);
            this.lblOrderMSName.Name = "lblOrderMSName";
            this.lblOrderMSName.Size = new System.Drawing.Size(90, 12);
            this.lblOrderMSName.TabIndex = 10;
            this.lblOrderMSName.Text = "lblOrderMSName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "作業工程NO";
            // 
            // txtWorkProcessMSNo
            // 
            this.txtWorkProcessMSNo.Location = new System.Drawing.Point(103, 69);
            this.txtWorkProcessMSNo.MaxLength = 3;
            this.txtWorkProcessMSNo.Name = "txtWorkProcessMSNo";
            this.txtWorkProcessMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtWorkProcessMSNo.TabIndex = 3;
            this.txtWorkProcessMSNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            this.txtWorkProcessMSNo.Leave += new System.EventHandler(this.text_Leave);
            // 
            // btnWorkProcessMSSearch
            // 
            this.btnWorkProcessMSSearch.Location = new System.Drawing.Point(173, 67);
            this.btnWorkProcessMSSearch.Name = "btnWorkProcessMSSearch";
            this.btnWorkProcessMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnWorkProcessMSSearch.TabIndex = 4;
            this.btnWorkProcessMSSearch.Text = "...";
            this.btnWorkProcessMSSearch.UseVisualStyleBackColor = true;
            this.btnWorkProcessMSSearch.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtOrderNumber);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 59);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "受注数";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(103, 21);
            this.txtOrderNumber.MaxLength = 5;
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(70, 19);
            this.txtOrderNumber.TabIndex = 1;
            this.txtOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEnd);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnSubmit);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 319);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(583, 57);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(496, 18);
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
            this.btnClear.Location = new System.Drawing.Point(401, 18);
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
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 229);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(583, 54);
            this.groupBox5.TabIndex = 4;
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
            // CT001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 376);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "CT001";
            this.Text = "CT001_受注仮登録画面";
            this.Load += new System.EventHandler(this.CT001_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CT001_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txtOrderMSNo;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnOrderMSSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtWorkProcessMSNo;
        private System.Windows.Forms.Button btnWorkProcessMSSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtHumanMSNo;
        private System.Windows.Forms.Button btnHumanMSSearch;
        internal System.Windows.Forms.Label lblOrderMSName;
        internal System.Windows.Forms.Label lblWorkProcessMSName;
    }
}


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
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorkProcessMSNo = new System.Windows.Forms.TextBox();
            this.btnWorkProcessMSSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrderMSNo
            // 
            this.txtOrderMSNo.Location = new System.Drawing.Point(103, 21);
            this.txtOrderMSNo.Name = "txtOrderMSNo";
            this.txtOrderMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtOrderMSNo.TabIndex = 7;
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
            this.btnOrderMSSearch.TabIndex = 8;
            this.btnOrderMSSearch.Text = "...";
            this.btnOrderMSSearch.UseVisualStyleBackColor = true;
            this.btnOrderMSSearch.Click += new System.EventHandler(this.btnOrderMSSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOrderNo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 54);
            this.groupBox1.TabIndex = 9;
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
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
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
            this.txtWorkProcessMSNo.Name = "txtWorkProcessMSNo";
            this.txtWorkProcessMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtWorkProcessMSNo.TabIndex = 10;
            // 
            // btnWorkProcessMSSearch
            // 
            this.btnWorkProcessMSSearch.Location = new System.Drawing.Point(173, 67);
            this.btnWorkProcessMSSearch.Name = "btnWorkProcessMSSearch";
            this.btnWorkProcessMSSearch.Size = new System.Drawing.Size(27, 23);
            this.btnWorkProcessMSSearch.TabIndex = 11;
            this.btnWorkProcessMSSearch.Text = "...";
            this.btnWorkProcessMSSearch.UseVisualStyleBackColor = true;
            this.btnWorkProcessMSSearch.Click += new System.EventHandler(this.btnWorkProcessMSSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtOrderNumber);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(583, 59);
            this.groupBox3.TabIndex = 11;
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
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(70, 19);
            this.txtOrderNumber.TabIndex = 12;
            this.txtOrderNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderNumber_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEnd);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnSubmit);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 254);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(583, 57);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(14, 18);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "F1:登録";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(401, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "F2:クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(496, 18);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "F3:終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // CT001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 311);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "CT001";
            this.Text = "CT001_受注登録画面";
            this.Load += new System.EventHandler(this.CT001_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CT001_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
    }
}


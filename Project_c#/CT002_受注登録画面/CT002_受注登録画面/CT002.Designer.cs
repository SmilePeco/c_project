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
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rboSearch03);
            this.groupBox1.Controls.Add(this.rboSearch02);
            this.groupBox1.Controls.Add(this.rboSearch01);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索条件";
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
            this.groupBox2.Location = new System.Drawing.Point(0, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 60);
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
            this.groupBox3.Location = new System.Drawing.Point(0, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(927, 180);
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
            this.groupBox5.Location = new System.Drawing.Point(3, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(921, 102);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // btnOrderNoSerach02
            // 
            this.btnOrderNoSerach02.Location = new System.Drawing.Point(744, 62);
            this.btnOrderNoSerach02.Name = "btnOrderNoSerach02";
            this.btnOrderNoSerach02.Size = new System.Drawing.Size(75, 23);
            this.btnOrderNoSerach02.TabIndex = 31;
            this.btnOrderNoSerach02.Text = "検索";
            this.btnOrderNoSerach02.UseVisualStyleBackColor = true;
            // 
            // dtpOrderNoSearch02
            // 
            this.dtpOrderNoSearch02.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderNoSearch02.Location = new System.Drawing.Point(689, 21);
            this.dtpOrderNoSearch02.Name = "dtpOrderNoSearch02";
            this.dtpOrderNoSearch02.Size = new System.Drawing.Size(130, 19);
            this.dtpOrderNoSearch02.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(661, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "～";
            // 
            // dtpOrderNoSearch01
            // 
            this.dtpOrderNoSearch01.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderNoSearch01.Location = new System.Drawing.Point(528, 21);
            this.dtpOrderNoSearch01.Name = "dtpOrderNoSearch01";
            this.dtpOrderNoSearch01.Size = new System.Drawing.Size(130, 19);
            this.dtpOrderNoSearch01.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "受注日";
            // 
            // lblOrderNoSearch01
            // 
            this.lblOrderNoSearch01.AutoSize = true;
            this.lblOrderNoSearch01.Location = new System.Drawing.Point(208, 26);
            this.lblOrderNoSearch01.Name = "lblOrderNoSearch01";
            this.lblOrderNoSearch01.Size = new System.Drawing.Size(106, 12);
            this.lblOrderNoSearch01.TabIndex = 26;
            this.lblOrderNoSearch01.Text = "lblOrderNoSearch01";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "受注先NO";
            // 
            // txtOrderNoSearch01
            // 
            this.txtOrderNoSearch01.Location = new System.Drawing.Point(105, 22);
            this.txtOrderNoSearch01.MaxLength = 3;
            this.txtOrderNoSearch01.Name = "txtOrderNoSearch01";
            this.txtOrderNoSearch01.Size = new System.Drawing.Size(70, 19);
            this.txtOrderNoSearch01.TabIndex = 23;
            this.txtOrderNoSearch01.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            this.txtOrderNoSearch01.Leave += new System.EventHandler(this.text_Leave);
            // 
            // btnOrderNoSerach01
            // 
            this.btnOrderNoSerach01.Location = new System.Drawing.Point(175, 20);
            this.btnOrderNoSerach01.Name = "btnOrderNoSerach01";
            this.btnOrderNoSerach01.Size = new System.Drawing.Size(27, 23);
            this.btnOrderNoSerach01.TabIndex = 24;
            this.btnOrderNoSerach01.Text = "...";
            this.btnOrderNoSerach01.UseVisualStyleBackColor = true;
            this.btnOrderNoSerach01.Click += new System.EventHandler(this.button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtOrderNo);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(921, 57);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "受注NO";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(105, 22);
            this.txtOrderNo.MaxLength = 3;
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(70, 19);
            this.txtOrderNo.TabIndex = 5;
            this.txtOrderNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // CT002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CT002";
            this.Text = "CT002_受注登録画面";
            this.Load += new System.EventHandler(this.CT002_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
    }
}


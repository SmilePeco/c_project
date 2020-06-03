namespace CTCommon
{
    partial class CTOrderNOSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOrderDateTo = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtpOrderDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderMSNo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dtpOrderDateTo);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.dtpOrderDateFrom);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.txtOrderMSNo);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(560, 101);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            // 
            // dtpOrderDateTo
            // 
            this.dtpOrderDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDateTo.Location = new System.Drawing.Point(253, 53);
            this.dtpOrderDateTo.Name = "dtpOrderDateTo";
            this.dtpOrderDateTo.Size = new System.Drawing.Size(130, 19);
            this.dtpOrderDateTo.TabIndex = 26;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label3.Location = new System.Drawing.Point(225, 55);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(22, 15);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "～";
            // 
            // dtpOrderDateFrom
            // 
            this.dtpOrderDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDateFrom.Location = new System.Drawing.Point(92, 53);
            this.dtpOrderDateFrom.Name = "dtpOrderDateFrom";
            this.dtpOrderDateFrom.Size = new System.Drawing.Size(130, 19);
            this.dtpOrderDateFrom.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "受注日";
            // 
            // txtOrderMSNo
            // 
            this.txtOrderMSNo.Location = new System.Drawing.Point(92, 20);
            this.txtOrderMSNo.Name = "txtOrderMSNo";
            this.txtOrderMSNo.Size = new System.Drawing.Size(70, 19);
            this.txtOrderMSNo.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 12);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "受注先NO";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnEnd);
            this.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBox3.Location = new System.Drawing.Point(0, 377);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(560, 49);
            this.GroupBox3.TabIndex = 11;
            this.GroupBox3.TabStop = false;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(458, 17);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "F1:終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.button_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.DataGridView1);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.Location = new System.Drawing.Point(0, 101);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(560, 276);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(3, 15);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 21;
            this.DataGridView1.Size = new System.Drawing.Size(554, 258);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentDoubleClick);
            // 
            // CTOrderNOSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 426);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox3);
            this.KeyPreview = true;
            this.Name = "CTOrderNOSearch";
            this.Text = "受注NO検索";
            this.Load += new System.EventHandler(this.CTOrderNOSearch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CTOrderNOSearch_KeyDown);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtOrderMSNo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnEnd;
        internal System.Windows.Forms.GroupBox GroupBox2;
        public System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.DateTimePicker dtpOrderDateTo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker dtpOrderDateFrom;
        internal System.Windows.Forms.Label label4;
    }
}
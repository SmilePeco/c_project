namespace CTMENU_メインメニュー
{
    partial class CTPASSCHANGE
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNewPass2 = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnChange);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(260, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.Location = new System.Drawing.Point(152, 24);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "変更";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNewPass2);
            this.groupBox2.Controls.Add(this.txtNewPass);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.Label2);
            this.groupBox2.Controls.Add(this.txtCurrentPass);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtNewPass2
            // 
            this.txtNewPass2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNewPass2.Location = new System.Drawing.Point(152, 101);
            this.txtNewPass2.MaxLength = 10;
            this.txtNewPass2.Name = "txtNewPass2";
            this.txtNewPass2.Size = new System.Drawing.Size(100, 19);
            this.txtNewPass2.TabIndex = 3;
            this.txtNewPass2.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNewPass.Location = new System.Drawing.Point(152, 66);
            this.txtNewPass.MaxLength = 10;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(100, 19);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(15, 104);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(127, 12);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "新しいパスワード(確認用)";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 69);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 12);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "新しいパスワード";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtCurrentPass.Location = new System.Drawing.Point(152, 27);
            this.txtCurrentPass.MaxLength = 10;
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(100, 19);
            this.txtCurrentPass.TabIndex = 1;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 12);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "現在のパスワード";
            // 
            // CTPASSCHANGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 248);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CTPASSCHANGE";
            this.Text = "パスワード変更画面";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtNewPass2;
        internal System.Windows.Forms.TextBox txtNewPass;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCurrentPass;
        internal System.Windows.Forms.Label Label1;
    }
}
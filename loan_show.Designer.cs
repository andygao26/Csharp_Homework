namespace Csharp_form1
{
    partial class loan_show
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
            this.label1 = new System.Windows.Forms.Label();
            this.money_txt = new System.Windows.Forms.TextBox();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rate_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.monthpay_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalpay_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(146, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "貸款金額:";
            // 
            // money_txt
            // 
            this.money_txt.Enabled = false;
            this.money_txt.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.money_txt.Location = new System.Drawing.Point(295, 70);
            this.money_txt.Margin = new System.Windows.Forms.Padding(10);
            this.money_txt.Name = "money_txt";
            this.money_txt.Size = new System.Drawing.Size(150, 40);
            this.money_txt.TabIndex = 1;
            // 
            // date_txt
            // 
            this.date_txt.Enabled = false;
            this.date_txt.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date_txt.Location = new System.Drawing.Point(295, 130);
            this.date_txt.Margin = new System.Windows.Forms.Padding(10);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(150, 40);
            this.date_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(146, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "期限(年):";
            // 
            // rate_txt
            // 
            this.rate_txt.Enabled = false;
            this.rate_txt.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rate_txt.Location = new System.Drawing.Point(295, 190);
            this.rate_txt.Margin = new System.Windows.Forms.Padding(10);
            this.rate_txt.Name = "rate_txt";
            this.rate_txt.Size = new System.Drawing.Size(150, 40);
            this.rate_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(146, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "年利率(%):";
            // 
            // monthpay_txt
            // 
            this.monthpay_txt.Enabled = false;
            this.monthpay_txt.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthpay_txt.Location = new System.Drawing.Point(295, 250);
            this.monthpay_txt.Margin = new System.Windows.Forms.Padding(10);
            this.monthpay_txt.Name = "monthpay_txt";
            this.monthpay_txt.Size = new System.Drawing.Size(150, 40);
            this.monthpay_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(146, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "月付款:";
            // 
            // totalpay_txt
            // 
            this.totalpay_txt.Enabled = false;
            this.totalpay_txt.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.totalpay_txt.Location = new System.Drawing.Point(295, 310);
            this.totalpay_txt.Margin = new System.Windows.Forms.Padding(10);
            this.totalpay_txt.Name = "totalpay_txt";
            this.totalpay_txt.Size = new System.Drawing.Size(150, 40);
            this.totalpay_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(146, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "總付款:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(598, 310);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(137, 40);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            this.Email.UseVisualStyleBackColor = true;
            // 
            // loan_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.totalpay_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthpay_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rate_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.money_txt);
            this.Controls.Add(this.label1);
            this.Name = "loan_show";
            this.Text = "loan_show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox money_txt;
        public System.Windows.Forms.TextBox date_txt;
        public System.Windows.Forms.TextBox rate_txt;
        public System.Windows.Forms.TextBox monthpay_txt;
        public System.Windows.Forms.TextBox totalpay_txt;
        private System.Windows.Forms.Button Email;
    }
}
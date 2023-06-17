namespace Csharp_form1
{
    partial class Loan
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
            this.monthpay_btn = new System.Windows.Forms.Button();
            this.sumpay_btn = new System.Windows.Forms.Button();
            this.report_btn = new System.Windows.Forms.Button();
            this.money_lab = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.rate_label = new System.Windows.Forms.Label();
            this.prepare_label = new System.Windows.Forms.Label();
            this.money_txt = new System.Windows.Forms.TextBox();
            this.date_txt = new System.Windows.Forms.TextBox();
            this.rate_txt = new System.Windows.Forms.TextBox();
            this.prepare_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthpay_btn
            // 
            this.monthpay_btn.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthpay_btn.Location = new System.Drawing.Point(206, 338);
            this.monthpay_btn.Margin = new System.Windows.Forms.Padding(10);
            this.monthpay_btn.Name = "monthpay_btn";
            this.monthpay_btn.Size = new System.Drawing.Size(114, 35);
            this.monthpay_btn.TabIndex = 0;
            this.monthpay_btn.Text = "月付金額";
            this.monthpay_btn.UseVisualStyleBackColor = true;
            this.monthpay_btn.Click += new System.EventHandler(this.monthpay_btn_Click);
            // 
            // sumpay_btn
            // 
            this.sumpay_btn.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sumpay_btn.Location = new System.Drawing.Point(331, 338);
            this.sumpay_btn.Margin = new System.Windows.Forms.Padding(10);
            this.sumpay_btn.Name = "sumpay_btn";
            this.sumpay_btn.Size = new System.Drawing.Size(114, 35);
            this.sumpay_btn.TabIndex = 1;
            this.sumpay_btn.Text = "總金額";
            this.sumpay_btn.UseVisualStyleBackColor = true;
            this.sumpay_btn.Click += new System.EventHandler(this.sumpay_btn_Click);
            // 
            // report_btn
            // 
            this.report_btn.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.report_btn.Location = new System.Drawing.Point(492, 338);
            this.report_btn.Margin = new System.Windows.Forms.Padding(10);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(114, 35);
            this.report_btn.TabIndex = 2;
            this.report_btn.Text = "Report";
            this.report_btn.UseVisualStyleBackColor = true;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // money_lab
            // 
            this.money_lab.AutoSize = true;
            this.money_lab.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.money_lab.Location = new System.Drawing.Point(124, 120);
            this.money_lab.Margin = new System.Windows.Forms.Padding(10);
            this.money_lab.Name = "money_lab";
            this.money_lab.Size = new System.Drawing.Size(106, 23);
            this.money_lab.TabIndex = 3;
            this.money_lab.Text = "貸款金額";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.date_label.Location = new System.Drawing.Point(124, 163);
            this.date_label.Margin = new System.Windows.Forms.Padding(10);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(106, 23);
            this.date_label.TabIndex = 4;
            this.date_label.Text = "期限(年)";
            // 
            // rate_label
            // 
            this.rate_label.AutoSize = true;
            this.rate_label.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rate_label.Location = new System.Drawing.Point(124, 206);
            this.rate_label.Margin = new System.Windows.Forms.Padding(10);
            this.rate_label.Name = "rate_label";
            this.rate_label.Size = new System.Drawing.Size(118, 23);
            this.rate_label.TabIndex = 5;
            this.rate_label.Text = "年利率(%)";
            // 
            // prepare_label
            // 
            this.prepare_label.AutoSize = true;
            this.prepare_label.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.prepare_label.Location = new System.Drawing.Point(124, 249);
            this.prepare_label.Margin = new System.Windows.Forms.Padding(10);
            this.prepare_label.Name = "prepare_label";
            this.prepare_label.Size = new System.Drawing.Size(82, 23);
            this.prepare_label.TabIndex = 6;
            this.prepare_label.Text = "頭期款";
            // 
            // money_txt
            // 
            this.money_txt.Location = new System.Drawing.Point(267, 120);
            this.money_txt.Name = "money_txt";
            this.money_txt.Size = new System.Drawing.Size(178, 25);
            this.money_txt.TabIndex = 7;
            // 
            // date_txt
            // 
            this.date_txt.Location = new System.Drawing.Point(267, 163);
            this.date_txt.Name = "date_txt";
            this.date_txt.Size = new System.Drawing.Size(178, 25);
            this.date_txt.TabIndex = 8;
            // 
            // rate_txt
            // 
            this.rate_txt.Location = new System.Drawing.Point(267, 209);
            this.rate_txt.Name = "rate_txt";
            this.rate_txt.Size = new System.Drawing.Size(178, 25);
            this.rate_txt.TabIndex = 9;
            // 
            // prepare_txt
            // 
            this.prepare_txt.Location = new System.Drawing.Point(267, 252);
            this.prepare_txt.Name = "prepare_txt";
            this.prepare_txt.Size = new System.Drawing.Size(178, 25);
            this.prepare_txt.TabIndex = 10;
            // 
            // loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prepare_txt);
            this.Controls.Add(this.rate_txt);
            this.Controls.Add(this.date_txt);
            this.Controls.Add(this.money_txt);
            this.Controls.Add(this.prepare_label);
            this.Controls.Add(this.rate_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.money_lab);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.sumpay_btn);
            this.Controls.Add(this.monthpay_btn);
            this.Name = "loan";
            this.Text = "loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monthpay_btn;
        private System.Windows.Forms.Button sumpay_btn;
        private System.Windows.Forms.Button report_btn;
        private System.Windows.Forms.Label money_lab;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label rate_label;
        private System.Windows.Forms.Label prepare_label;
        private System.Windows.Forms.TextBox money_txt;
        private System.Windows.Forms.TextBox date_txt;
        private System.Windows.Forms.TextBox rate_txt;
        private System.Windows.Forms.TextBox prepare_txt;
    }
}
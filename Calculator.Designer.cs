namespace Csharp_form1
{
    partial class Calculator
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
            this.add_btn = new System.Windows.Forms.Button();
            this.sub_btn = new System.Windows.Forms.Button();
            this.mul_btn = new System.Windows.Forms.Button();
            this.div_btn = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.Num1_text = new System.Windows.Forms.TextBox();
            this.Num2_text = new System.Windows.Forms.TextBox();
            this.Answer_text = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add_btn.Location = new System.Drawing.Point(314, 67);
            this.add_btn.Margin = new System.Windows.Forms.Padding(10);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(50, 30);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // sub_btn
            // 
            this.sub_btn.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sub_btn.Location = new System.Drawing.Point(314, 110);
            this.sub_btn.Margin = new System.Windows.Forms.Padding(10);
            this.sub_btn.Name = "sub_btn";
            this.sub_btn.Size = new System.Drawing.Size(50, 30);
            this.sub_btn.TabIndex = 1;
            this.sub_btn.Text = "-";
            this.sub_btn.UseVisualStyleBackColor = true;
            this.sub_btn.Click += new System.EventHandler(this.sub_btn_Click);
            // 
            // mul_btn
            // 
            this.mul_btn.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mul_btn.Location = new System.Drawing.Point(314, 153);
            this.mul_btn.Margin = new System.Windows.Forms.Padding(10);
            this.mul_btn.Name = "mul_btn";
            this.mul_btn.Size = new System.Drawing.Size(50, 30);
            this.mul_btn.TabIndex = 2;
            this.mul_btn.Text = "*";
            this.mul_btn.UseVisualStyleBackColor = true;
            this.mul_btn.Click += new System.EventHandler(this.mul_btn_Click);
            // 
            // div_btn
            // 
            this.div_btn.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.div_btn.Location = new System.Drawing.Point(314, 209);
            this.div_btn.Margin = new System.Windows.Forms.Padding(10);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(50, 30);
            this.div_btn.TabIndex = 3;
            this.div_btn.Text = "/";
            this.div_btn.UseVisualStyleBackColor = true;
            this.div_btn.Click += new System.EventHandler(this.div_btn_Click);
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Num1.Location = new System.Drawing.Point(90, 107);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(59, 20);
            this.Num1.TabIndex = 4;
            this.Num1.Text = "Num1:";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Num2.Location = new System.Drawing.Point(90, 152);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(59, 20);
            this.Num2.TabIndex = 5;
            this.Num2.Text = "Num2:";
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Answer.Location = new System.Drawing.Point(90, 209);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(79, 20);
            this.Answer.TabIndex = 6;
            this.Answer.Text = "Answer:";
            // 
            // Num1_text
            // 
            this.Num1_text.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Num1_text.Location = new System.Drawing.Point(180, 107);
            this.Num1_text.Margin = new System.Windows.Forms.Padding(10);
            this.Num1_text.Name = "Num1_text";
            this.Num1_text.Size = new System.Drawing.Size(100, 31);
            this.Num1_text.TabIndex = 7;
            // 
            // Num2_text
            // 
            this.Num2_text.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Num2_text.Location = new System.Drawing.Point(180, 152);
            this.Num2_text.Margin = new System.Windows.Forms.Padding(10);
            this.Num2_text.Name = "Num2_text";
            this.Num2_text.Size = new System.Drawing.Size(100, 31);
            this.Num2_text.TabIndex = 8;
            // 
            // Answer_text
            // 
            this.Answer_text.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Answer_text.Location = new System.Drawing.Point(180, 209);
            this.Answer_text.Margin = new System.Windows.Forms.Padding(10);
            this.Answer_text.Name = "Answer_text";
            this.Answer_text.ReadOnly = true;
            this.Answer_text.Size = new System.Drawing.Size(100, 31);
            this.Answer_text.TabIndex = 9;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("標楷體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.title.Location = new System.Drawing.Point(125, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(212, 37);
            this.title.TabIndex = 10;
            this.title.Text = "簡易計算機";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(77, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "========================";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Answer_text);
            this.Controls.Add(this.Num2_text);
            this.Controls.Add(this.Num1_text);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.div_btn);
            this.Controls.Add(this.mul_btn);
            this.Controls.Add(this.sub_btn);
            this.Controls.Add(this.add_btn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button sub_btn;
        private System.Windows.Forms.Button mul_btn;
        private System.Windows.Forms.Button div_btn;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.TextBox Num1_text;
        private System.Windows.Forms.TextBox Num2_text;
        private System.Windows.Forms.TextBox Answer_text;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
    }
}
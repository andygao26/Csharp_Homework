namespace Csharp_form1
{
    partial class Student
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
            this.name_txt = new System.Windows.Forms.TextBox();
            this.chinese_txt = new System.Windows.Forms.TextBox();
            this.english_txt = new System.Windows.Forms.TextBox();
            this.math_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.hightlow_btn = new System.Windows.Forms.Button();
            this.score_group = new System.Windows.Forms.GroupBox();
            this.hightlow_txt = new System.Windows.Forms.TextBox();
            this.score_txt = new System.Windows.Forms.TextBox();
            this.score_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name_txt.Location = new System.Drawing.Point(250, 115);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(153, 31);
            this.name_txt.TabIndex = 0;
            // 
            // chinese_txt
            // 
            this.chinese_txt.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chinese_txt.Location = new System.Drawing.Point(250, 160);
            this.chinese_txt.Name = "chinese_txt";
            this.chinese_txt.Size = new System.Drawing.Size(153, 31);
            this.chinese_txt.TabIndex = 1;
            // 
            // english_txt
            // 
            this.english_txt.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.english_txt.Location = new System.Drawing.Point(250, 207);
            this.english_txt.Name = "english_txt";
            this.english_txt.Size = new System.Drawing.Size(153, 31);
            this.english_txt.TabIndex = 2;
            // 
            // math_txt
            // 
            this.math_txt.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.math_txt.Location = new System.Drawing.Point(250, 252);
            this.math_txt.Name = "math_txt";
            this.math_txt.Size = new System.Drawing.Size(153, 31);
            this.math_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(129, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(129, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(129, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "英文:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(129, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "數學:";
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.save_btn.Location = new System.Drawing.Point(158, 323);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(145, 51);
            this.save_btn.TabIndex = 10;
            this.save_btn.Text = "儲存";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.load_btn.Location = new System.Drawing.Point(345, 323);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(145, 51);
            this.load_btn.TabIndex = 11;
            this.load_btn.Text = "顯示儲存內容";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // hightlow_btn
            // 
            this.hightlow_btn.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hightlow_btn.Location = new System.Drawing.Point(569, 323);
            this.hightlow_btn.Name = "hightlow_btn";
            this.hightlow_btn.Size = new System.Drawing.Size(151, 51);
            this.hightlow_btn.TabIndex = 12;
            this.hightlow_btn.Text = "最高/低分課目";
            this.hightlow_btn.UseVisualStyleBackColor = true;
            this.hightlow_btn.Click += new System.EventHandler(this.hightlow_btn_Click);
            // 
            // score_group
            // 
            this.score_group.BackColor = System.Drawing.SystemColors.Control;
            this.score_group.Controls.Add(this.hightlow_txt);
            this.score_group.Controls.Add(this.score_txt);
            this.score_group.Enabled = false;
            this.score_group.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.score_group.Location = new System.Drawing.Point(489, 37);
            this.score_group.Name = "score_group";
            this.score_group.Size = new System.Drawing.Size(251, 246);
            this.score_group.TabIndex = 13;
            this.score_group.TabStop = false;
            this.score_group.Text = "成績:";
            // 
            // hightlow_txt
            // 
            this.hightlow_txt.BackColor = System.Drawing.SystemColors.Control;
            this.hightlow_txt.Location = new System.Drawing.Point(6, 153);
            this.hightlow_txt.Multiline = true;
            this.hightlow_txt.Name = "hightlow_txt";
            this.hightlow_txt.Size = new System.Drawing.Size(239, 87);
            this.hightlow_txt.TabIndex = 1;
            // 
            // score_txt
            // 
            this.score_txt.BackColor = System.Drawing.SystemColors.Control;
            this.score_txt.Location = new System.Drawing.Point(6, 22);
            this.score_txt.Multiline = true;
            this.score_txt.Name = "score_txt";
            this.score_txt.Size = new System.Drawing.Size(239, 132);
            this.score_txt.TabIndex = 0;
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score_group);
            this.Controls.Add(this.hightlow_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.math_txt);
            this.Controls.Add(this.english_txt);
            this.Controls.Add(this.chinese_txt);
            this.Controls.Add(this.name_txt);
            this.Name = "student";
            this.Text = "student";
            this.score_group.ResumeLayout(false);
            this.score_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox chinese_txt;
        private System.Windows.Forms.TextBox english_txt;
        private System.Windows.Forms.TextBox math_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Button hightlow_btn;
        private System.Windows.Forms.GroupBox score_group;
        private System.Windows.Forms.TextBox hightlow_txt;
        private System.Windows.Forms.TextBox score_txt;
    }
}
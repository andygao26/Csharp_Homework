namespace Csharp_form1
{
    partial class HelloHi
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloHi));
            this.HI = new System.Windows.Forms.Button();
            this.HELLO = new System.Windows.Forms.Button();
            this.chname = new System.Windows.Forms.TextBox();
            this.enname = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HI
            // 
            this.HI.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HI.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.HI.FlatAppearance.BorderSize = 4;
            this.HI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.HI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.HI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HI.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HI.Location = new System.Drawing.Point(51, 217);
            this.HI.Name = "HI";
            this.HI.Size = new System.Drawing.Size(137, 45);
            this.HI.TabIndex = 0;
            this.HI.Text = "HI";
            this.HI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HI.UseVisualStyleBackColor = false;
            this.HI.Click += new System.EventHandler(this.HI_Click);
            // 
            // HELLO
            // 
            this.HELLO.BackColor = System.Drawing.Color.WhiteSmoke;
            this.HELLO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HELLO.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.HELLO.FlatAppearance.BorderSize = 4;
            this.HELLO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.HELLO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.HELLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HELLO.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HELLO.Location = new System.Drawing.Point(200, 217);
            this.HELLO.Name = "HELLO";
            this.HELLO.Size = new System.Drawing.Size(137, 45);
            this.HELLO.TabIndex = 1;
            this.HELLO.Text = "HELLO";
            this.HELLO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HELLO.UseVisualStyleBackColor = false;
            this.HELLO.Click += new System.EventHandler(this.HELLO_Click);
            // 
            // chname
            // 
            this.chname.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chname.Location = new System.Drawing.Point(157, 52);
            this.chname.Margin = new System.Windows.Forms.Padding(10);
            this.chname.Name = "chname";
            this.chname.Size = new System.Drawing.Size(180, 31);
            this.chname.TabIndex = 2;
            // 
            // enname
            // 
            this.enname.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enname.Location = new System.Drawing.Point(157, 92);
            this.enname.Margin = new System.Windows.Forms.Padding(10);
            this.enname.Name = "enname";
            this.enname.Size = new System.Drawing.Size(180, 31);
            this.enname.TabIndex = 3;
            // 
            // sex
            // 
            this.sex.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sex.Location = new System.Drawing.Point(157, 132);
            this.sex.Margin = new System.Windows.Forms.Padding(10);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(180, 31);
            this.sex.TabIndex = 4;
            // 
            // sign
            // 
            this.sign.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sign.Location = new System.Drawing.Point(157, 172);
            this.sign.Margin = new System.Windows.Forms.Padding(10);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(180, 31);
            this.sign.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(47, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "英文名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(47, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "性別:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(47, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "星座:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(53, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(202, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // HelloHi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.enname);
            this.Controls.Add(this.chname);
            this.Controls.Add(this.HELLO);
            this.Name = "HelloHi";
            this.Text = "HelloHi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HI;
        private System.Windows.Forms.Button HELLO;
        private System.Windows.Forms.TextBox chname;
        private System.Windows.Forms.TextBox enname;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox sign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


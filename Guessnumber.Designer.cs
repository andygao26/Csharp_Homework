namespace Csharp_form1
{
    partial class Guessnumber
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
            this.Guess = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Button();
            this.Text_lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guess
            // 
            this.Guess.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Guess.Location = new System.Drawing.Point(238, 248);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(143, 60);
            this.Guess.TabIndex = 0;
            this.Guess.Text = "Guess";
            this.Guess.UseVisualStyleBackColor = true;
            this.Guess.Click += new System.EventHandler(this.Guess_Click);
            // 
            // Answer
            // 
            this.Answer.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Answer.Location = new System.Drawing.Point(401, 248);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(143, 60);
            this.Answer.TabIndex = 1;
            this.Answer.Text = "Show Answer";
            this.Answer.UseVisualStyleBackColor = true;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // Text_lab
            // 
            this.Text_lab.BackColor = System.Drawing.Color.Transparent;
            this.Text_lab.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Text_lab.Location = new System.Drawing.Point(89, 139);
            this.Text_lab.Name = "Text_lab";
            this.Text_lab.Size = new System.Drawing.Size(679, 106);
            this.Text_lab.TabIndex = 2;
            this.Text_lab.Text = "Please Select A Number Between 1 to 100! ";
            // 
            // guessnumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.Text_lab);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Guess);
            this.Name = "guessnumber";
            this.Text = "guessnumber";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Guess;
        private System.Windows.Forms.Button Answer;
        public System.Windows.Forms.Label Text_lab;
    }
}
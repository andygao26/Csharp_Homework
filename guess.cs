using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_form1
{
    public partial class guess : Form
    {
        public guess()
        {
            InitializeComponent();
        }
        int guess_ans;
        int minnumber = 0;
        int maxnumber = 100;
        private void enter_btn_Click(object sender, EventArgs e)
        {
            Guessnumber guessnum = (Guessnumber)this.Owner;
            int ans = guessnum.answer;

            if (int.TryParse(guess_txt.Text, out int number) & number < maxnumber & number > minnumber)
            {
                guess_ans = number;
            }
            else
            {
                MessageBox.Show($"請輸入{minnumber}~{maxnumber}之間的數字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (guess_ans > ans)
            {
                maxnumber = guess_ans;
                guessnum.SetLabelText($"Too Large!!! \nBetween {minnumber}and{maxnumber}");
            }
            else if (guess_ans < ans)
            {
                minnumber = guess_ans;
                guessnum.SetLabelText($"Too Small!!! \nBetween {minnumber}and{maxnumber}");
            }
            else if (guess_ans == ans)
            {
                MessageBox.Show($"Congradulations!!! You got {ans}!!!","",MessageBoxButtons.OK);
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

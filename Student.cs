using System;
using System.Collections;
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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        string name;
        int hightscore;
        int lowscore;
        string hightclass;
        string lowclass;
        int[] score = new int[3];
        string[] subject = { "國文", "英文", "數學" };
        private void save_btn_Click(object sender, EventArgs e)
        {
            name=name_txt.Text;
            bool ch_score = int.TryParse(chinese_txt.Text, out int score0);
            bool en_score = int.TryParse(english_txt.Text, out int score1);
            bool ma_score = int.TryParse(math_txt.Text, out int score2);
            if (ch_score && en_score && ma_score)
            {
                score[0] = score0;
                score[1] = score1;
                score[2] = score2;
            }
            else
            {
                MessageBox.Show("請輸入正確數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            score_txt.Text = $"姓名:{name}\r\n國文:{score[0]}分\r\n英文:{score[1]}分\r\n數學:{score[2]}分";
        }

        private void hightlow_btn_Click(object sender, EventArgs e)
        {
            hightscore = score[0];
            lowscore = score[0];
            hightclass = subject[0];
            lowclass = subject[0];
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] > hightscore)
                {
                    hightscore = score[i];
                    hightclass=subject[i];

                }
                if (score[i] < lowscore)
                {
                    lowscore = score[i];
                    lowclass = subject[i];

                }
            }

            hightlow_txt.Text = $"最高分課目為:{hightclass} {hightscore}\n最低分課目為:{lowclass} {lowscore}";


            /*hightscore = chinese_score;
            hightclass = "國文";
            if (english_score > hightscore && english_score> math_score)
            {
                hightscore=english_score;
                hightclass = "英文";
            }
            else if (math_score> hightscore)
            {
                hightscore=math_score;
                hightclass = "數學";
            }

            lowscore = chinese_score;
            lowclass = "國文";
            if (english_score < lowscore && english_score < math_score)
            {
                lowscore = english_score;
                lowclass = "英文";
            }
            else if (math_score < lowscore)
            {
                lowscore = math_score;
                lowclass = "數學";
            }
            hightlow_txt.Text = $"最高分課目為:{hightclass} {hightscore}\n最低分課目為:{lowclass} {lowscore}";
            */
        }
    }
}

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
    public partial class Pos : Form
    {
        public Pos()
        {
            InitializeComponent();
        }

        List<int> buy_list = new List<int> { 0,0,0,0,0,0};
        List<int> count_list = new List<int> { 0, 0, 0, 0, 0, 0 };
        List<string> buy_txt = new List<string> { "", "", "", "", "", "" };
        int money = 0;
        void Showlist()
        {
            list_txt.Clear();
            cash_txt.Clear();
            int total_price = 0;
            for (int i = 0; i < count_list.Count; i++)
            {
                if (count_list[i] != 0)
                {
                    list_txt.Text += buy_txt[i] + "\r\n";
                    total_price += count_list[i];
                }
            }
            money = total_price;
            cash_txt.Text ="NT$"+ money.ToString();
            
        }
        private void beer_btn_Click(object sender, EventArgs e) 
        {
            buy_list[0] += 1;
            count_list[0] += 120;
            buy_txt[0] = $"啤酒 Beer X{buy_list[0]},共NT${count_list[0]}元";
            Showlist();
        }

        private void whiskey_btn_Click(object sender, EventArgs e) 
        {
            buy_list[1] += 1;
            count_list[1] += 420;
            buy_txt[1]= $"威士忌 Whiskey X{buy_list[1]},共NT${count_list[1]}元";
            Showlist();

        }

        private void vodka_btn_Click(object sender, EventArgs e) 
        {
            buy_list[2] += 1;
            count_list[2] += 360;
            buy_txt[2] = $"伏特加 Vodka X{buy_list[2]},共NT${count_list[2]}元";
            Showlist();

        }

        private void rum_btn_Click(object sender, EventArgs e) 
        {
            buy_list[3] += 1;
            count_list[3] += 180;
            buy_txt[3] = $"蘭姆酒 Rum X{buy_list[3]},共NT${count_list[3]}元";
            Showlist();
        }

        private void gin_btn_Click(object sender, EventArgs e) 
        {
            buy_list[4] += 1;
            count_list[4] += 240;
            buy_txt[4] = $"琴酒 Gin X{buy_list[4]},共NT${count_list[4]}元";
            Showlist();
        }

        private void tequila_btn_Click(object sender, EventArgs e) 
        {
            buy_list[5] += 1;
            count_list[5] += 300;
            buy_txt[5] = $"龍舌蘭 Tequila X{buy_list[5]},共NT${count_list[5]}元";
            Showlist();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            for(int i = 0;  i < count_list.Count; i++) 
            {
                buy_list[i] = 0;
                count_list[i] = 0;
                Showlist();
                list_txt.Text = "尚未點餐";
            }
        }

        private void cash_btn_Click(object sender, EventArgs e)
        {
            if (money == 0)
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額:NT$" + money, "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void card_btn_Click(object sender, EventArgs e)
        {
            if (money == 0)
            {
                MessageBox.Show("尚未點餐", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額:NT$" + money+"\n折扣後金額:NT$"+money*0.9, "確認付款", MessageBoxButtons.OKCancel);
            }
        }
    }
}

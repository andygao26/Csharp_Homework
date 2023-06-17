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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }
        double rate;
        int money;
        int date;
        string monthlyPayment;
        string totalPayment;
        private void monthpay_btn_Click(object sender, EventArgs e)
        {
            if (money_txt.Text == "" || date_txt.Text == "" || rate_txt.Text == "" || prepare_txt.Text == "")
            {
                MessageBox.Show("請輸入正確數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rate = double.Parse(rate_txt.Text) / 100 / 12;
                money = (int.Parse(money_txt.Text) - int.Parse(prepare_txt.Text));
                date = int.Parse(date_txt.Text) * 12;
                monthlyPayment = (Math.Round(money * rate * Math.Pow(1 + rate, date) / (Math.Pow(1 + rate, date) - 1), 1)).ToString();
                MessageBox.Show("月付款:" + monthlyPayment + "元");
            }
        }

        private void sumpay_btn_Click(object sender, EventArgs e)
        {
            rate = double.Parse(rate_txt.Text) / 100 / 12;
            money = (int.Parse(money_txt.Text) - int.Parse(prepare_txt.Text));
            date = int.Parse(date_txt.Text) * 12;
            totalPayment = (Math.Round(money * rate * Math.Pow(1 + rate, date) / (Math.Pow(1 + rate, date) - 1), 1)*date).ToString();
            MessageBox.Show("總金額:" + totalPayment + "元");

        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            loan_show ls = new loan_show();
            ls.money_txt.Text=money_txt.Text;
            ls.date_txt.Text=date_txt.Text;
            ls.rate_txt.Text=rate_txt.Text;
            ls.monthpay_txt.Text=monthlyPayment;
            ls.totalpay_txt.Text=totalPayment;
            ls.Show();

        }
    }
}

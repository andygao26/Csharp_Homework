using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_form1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        char symbol;
        string answer  ;
        void calculator(char symbol)
        {
            bool isNumeric01 = float.TryParse(Num1_text.Text, out float num_1);
            bool isNumeric02 = float.TryParse(Num2_text.Text, out float num_2);
            if (isNumeric01 & isNumeric02 )
            {
                num_1 = float.Parse(Num1_text.Text);
                num_2 = float.Parse(Num2_text.Text);
                if (symbol == '+')
                {
                    float total = num_1 + num_2;
                    string answer = Convert.ToString(total);
                    Answer_text.Text = answer;
                    Answer_text.Show();
                }
                if (symbol == '-')
                {
                    float total = num_1 - num_2;
                    string answer = Convert.ToString(total);
                    Answer_text.Text = answer;
                    Answer_text.Show();
                }
                if (symbol == '*')
                {
                    float total = num_1 * num_2;
                    string answer = Convert.ToString(total);
                    Answer_text.Text = answer;
                    Answer_text.Show();
                }
                if (symbol == '/')
                {
                    float total = num_1 / num_2;
                    string answer = Convert.ToString(total);
                    Answer_text.Text = answer;
                    Answer_text.Show();
                }
            }
            else
            {
                MessageBox.Show("請輸入正確數值");
            }
            
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            calculator(symbol='+');
        }

        private void sub_btn_Click(object sender, EventArgs e)
        {
            char symbol = '-';
            calculator(symbol);
        }

        private void mul_btn_Click(object sender, EventArgs e)
        {
            char symbol = '*';
            calculator(symbol);
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            char symbol = '/';
            calculator(symbol);
        }

    }
}

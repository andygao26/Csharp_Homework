using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_form1
{
    public partial class XOgame : Form
    {
        public XOgame()
        {
            InitializeComponent();
            btn_list = new Button[9] { button0, button1, button2, button3, button4, button5, button6, button7, button8 };

        }
        Button[] btn_list = new Button[9];
        bool isO = true;
        static private int[,] Wingroup = new int[8, 3]
        {
            {0,1,2},
            {3,4,5},
            {6,7,8},
            {0,3,6},
            {1,4,7},
            {2,5,8},
            {0,4,8},
            {2,4,6}
        };
        private bool CheckWin(List<int> OX_list)
        {
            for (int i = 0;i < Wingroup.GetLength(0); i++)
            {
                bool isWin = true;
                for (int j = 0;j < Wingroup.GetLength(1); j++)
                {
                    int index = Wingroup[i,j];
                    if (!OX_list.Contains(index))
                    {
                        isWin = false;
                        break;
                    }
                }
                if (isWin)
                {
                    return true;
                }
            }
            return false;
        }
        private void Result(string message)
        {
            DialogResult result = MessageBox.Show(message, "完局", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Restart_btn_Click(null, null);
            }
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            if (isO)
            {
                tmpButton.Text = "○";
                tmpButton.Enabled = false;
            }
            else
            {
                tmpButton.Text = "X";
                tmpButton.Enabled = false;
            }
            isO = !isO;
            List<int> O_list = new List<int>();
            List<int> X_list = new List<int>();

            for (int i = 0;i< btn_list.Length; i++)
            {
                if (btn_list[i].Text == "○")
                {
                    O_list.Add(i);
                }
                else if (btn_list[i].Text == "X")
                {
                    X_list.Add(i);
                }
            }
            if (CheckWin(O_list))
            {
                Result("玩家 O 獲勝！");

            }
            else if (CheckWin(X_list))
            {
                Result("玩家 X 獲勝！");

            }
            else if (O_list.Count+X_list.Count == 9)
            {
                Result("平手！按下確定重新開始！");
            }
        }
        private void Restart_btn_Click(object sender, EventArgs e)
        {
            isO = true;
            for (int i = 0; i < btn_list.Length; i++)
            {
                btn_list[i].Text = "";
                btn_list[i].Enabled = true;
            }
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class HomePage : Form
    {
        private Dictionary<Button, Type> homework_dic;
        public HomePage()
        {
            InitializeComponent();
            ButtonIntoHomeWork();
        }
        private void ButtonIntoHomeWork() 
        {
            homework_dic = new Dictionary<Button, Type>
            {
                { button1, typeof(HelloHi) },
                { button2, typeof(Loan) },
                { button3, typeof(Pos) },
                { button4, typeof(Student) },
                { button5, typeof(Calculator) },
                { button6, typeof(Screen) },
                { button7, typeof(Pictureview) },
                { button8, typeof(XOgame) },
                { button9, typeof(Guessnumber) }
            };
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (homework_dic.ContainsKey(button))
            {
                Type HW_Form = homework_dic[button];
                Form HW_Show = (Form)Activator.CreateInstance(HW_Form);   //創建指定類型表單
                if (button == button6)
                {
                    HW_Show.TopLevel= true;
                    HW_Show.FormBorderStyle = FormBorderStyle.None;
                    HW_Show.WindowState = FormWindowState.Maximized;

                }
                else
                {
                    HW_Show.TopLevel = false;
                    HW_Show.FormBorderStyle = FormBorderStyle.Sizable;
                    splitContainer2.Panel2.Controls.Clear();
                    splitContainer2.Panel2.Controls.Add(HW_Show);
                }
                
                HW_Show.Show();

            }
            
        }
    }
}

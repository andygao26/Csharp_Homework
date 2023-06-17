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
    public partial class HelloHi : Form
    {
        public HelloHi()
        {
            InitializeComponent();
        }

        private void HI_Click(object sender, EventArgs e)
        {
            string ch_Name=chname.Text;
            string en_Name=enname.Text;
            string Sex = sex.Text;
            string Sign=sign.Text;
            MessageBox.Show($"Hi,我是{ch_Name},\n英文名字是{en_Name},\n性別是{Sex},\n星座是{Sign}");
        }

        private void HELLO_Click(object sender, EventArgs e)
        {
            string ch_Name = chname.Text;
            string en_Name = enname.Text;
            string Sex = sex.Text;
            string Sign = sign.Text;
            MessageBox.Show($"Hello,我是{ch_Name},\n英文名字是{en_Name},\n性別是{Sex},\n星座是{Sign}");
        }


    }
}

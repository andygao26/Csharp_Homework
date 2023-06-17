using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Csharp_form1
{
    public partial class Guessnumber : Form
    {
        public Guessnumber()
        {
            InitializeComponent();
        }
        guess guessshow = new guess();
        public int answer;
        private void Guess_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            answer = random.Next(1, 100);
            guessshow.Owner = this;
            guessshow.ShowDialog();
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer:" + answer, "",MessageBoxButtons.OK);
        }
        public void SetLabelText(string text)
        {
            Text_lab.Text = text;
        }

    }
}

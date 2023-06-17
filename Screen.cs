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
    public partial class Screen : Form
    {
        public Screen()
        {
            InitializeComponent();
        }
        int x = Cursor.Position.X;  //取得滑鼠位置
        int y = Cursor.Position.Y;
        private void Mousemove()  //滑鼠移動即離開
        {
            if (Cursor.Position.X != x && Cursor.Position.Y != y)
            {
                Application.Exit();
            }
        }

        int Hight_speed = 6;
        int Width_speed = 8;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Mousemove();
            if ((pictureBox1.Right > this.Width)||(pictureBox1.Left < 0))
            {
                Width_speed *= -1;
            }
            if ((pictureBox1.Top < 0)||(pictureBox1.Bottom > this.Height))
            {
                Hight_speed *= -1;
            }

            pictureBox1.Left += Width_speed;
            pictureBox1.Top += Hight_speed;
        }

    }
}

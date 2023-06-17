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
    public partial class Pictureview : Form
    {
        private Dictionary<Button, string> Image_dic;
        public Pictureview()
        {
            InitializeComponent();
            InitializeButtonImageMapping();
        }
        private void InitializeButtonImageMapping()  //按鈕對應圖片的字典
        {
            Image_dic = new Dictionary<Button, string>
            {
                { button1, @"D:\宏旭\C#\pratice\Csharp_form1\Image\Screen_GIF.gif" },
                { button2, @"D:\宏旭\C#\pratice\Csharp_form1\Image\screen_jpg.jpg" },
                { button3, @"D:\宏旭\C#\pratice\Csharp_form1\Image\IU_2.jpg" },
                { button4, @"D:\宏旭\C#\pratice\Csharp_form1\Image\IUs.jpg" },
                { button5, @"D:\宏旭\C#\pratice\Csharp_form1\Image\beer.jpg" },
                { button6, @"D:\宏旭\C#\pratice\Csharp_form1\Image\Gin.jpg" },
                { button7, @"D:\宏旭\C#\pratice\Csharp_form1\Image\Rum.jpg" },
                { button8, @"D:\宏旭\C#\pratice\Csharp_form1\Image\Tequlia.jpg" },
                { button9, @"D:\宏旭\C#\pratice\Csharp_form1\Image\Vodka.jpg" },
                { button10, @"D:\宏旭\C#\pratice\Csharp_form1\Image\whiskey.jpg" },
                { button11, @"D:\宏旭\C#\pratice\Csharp_form1\Image\background_image.jpg" },
                { button12, @"D:\宏旭\C#\pratice\Csharp_form1\Image\Post_background.jpg" }
            };
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            Pictureview_show pic_show = new Pictureview_show();
            Button button = (Button)sender;
            if (Image_dic.ContainsKey(button))
            {
                string imagePath = Image_dic[button];
                if (System.IO.File.Exists(imagePath))
                {
                    pic_show.BackgroundImage = Image.FromFile(imagePath);
                    pic_show.BackgroundImageLayout = ImageLayout.Zoom;
                    pic_show.Size = new Size(400,400);
                    pic_show.Location = new Point(300, 300);
                    pic_show.Show();
                }
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateBlank( pictureBox1.Width, pictureBox1.Height);
           
        }
        /// <summary>
        /// Цвет заливки по умолчанию
        /// </summary>
        Color DefaultColor
        {
         get { return Color.White; }
        }
        /// <summary>
        /// Создаем пустую область рисования
        /// </summary>
        /// <param name="width">Ширина области</param>
        /// <param name="height">Высота области</param>
        void CreateBlank(int width, int height) 
        {
            //сохарняем картинку
            var oldImage = pictureBox1.Image;
            //Создаем новый Bitmap
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            //производим попиксельное закрашивание
            //Битмап - обычный двумерный массив точек, поэтому проходим его за 2 цикла:
            for (int i = 0; i < width; i++) 
            { 
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i,j, BackColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();     //освобождаем ресурсы, занятые старой картинкой
            }
        }

    } 
}

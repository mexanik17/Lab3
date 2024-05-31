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
            CreateBlank(pictureBox1.Width, pictureBox1.Height);

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
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //производим попиксельное закрашивание
            //Битмап - обычный двумерный массив точек, поэтому проходим его за 2 цикла:
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();     //освобождаем ресурсы, занятые старой картинкой
            }
        }
        int _x;
        int _y;
        bool _mouseCilicked = false;


        ///<summary>
        ///выбранный цвет, пока задан констнтой, в дальнейшем - из цветовой палитры
        ///</summary>
        Color SelectedColor
        {
            get { return Color.Red; }
        }
        ///<summary>
        ///выбранный размер кисти, задается положением ползунка на форме
        ///</summary>
        int SelectedSize
        {
            get { return brushSize.Value; }
        }
        Brush _selectedBrush;           //выбранная кисть

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }
        /// <summary>
        /// обработчик события при нажатии кнопки мыши
        /// </summary>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null)
            {

                return;
            }
            //в противном случае, рисуем точку на поверхности
            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            //и фиксируем тот факт, что мышка еще нажата, для отслеживания перемещений мыши:
            _mouseCilicked = true;
        }
        ///<summary>
        ///Обработчик события при отжатия кнопки мыши
        /// </summary>
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseCilicked = false;
        }

       ///<summary>
       ///Обработчик перемещений мыши
       /// </summary>
       /// <param name="e">Параметры перемещения, в том числе координатных</param>
       private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //не даем выйти мыши из границы области, отсекаем отрицательные координаты
            _x=e.X>0 ? e.X : 0;
            _y=e.Y>0 ? e.Y : 0;
            if (_mouseCilicked)
            {
                //если мышь зажата, то рисуем...
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x,_y);
                pictureBox1.Refresh();
            }
        }

    }
}
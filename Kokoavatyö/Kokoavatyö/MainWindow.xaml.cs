using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
using NotePad2020;
using calculator2;
using static Kokoavatyö.RenderVisualServise;

namespace Kokoavatyö
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int diameter = (int)Sizes.small;
        private Brush brushcolor = Brushes.Black;
        private bool ispaint = false;
        private bool iseraise = false;


        private enum Sizes
        {
            small = 10
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void paintcircle(Brush circlecolor, Point position)
        {
            Ellipse newellipse = new Ellipse();
            newellipse.Fill = circlecolor;
            newellipse.Width = diameter;
            newellipse.Height = diameter;
            Canvas.SetTop(newellipse, position.Y);
            Canvas.SetLeft(newellipse, position.X);
            myCanvas.Children.Add(newellipse);
        }




        private void red_Checked(object sender, RoutedEventArgs e)
        {
            brushcolor = Brushes.Red;
        }

        private void yellow_Checked(object sender, RoutedEventArgs e)
        {
            brushcolor = Brushes.Yellow;
        }

        private void blue_Checked(object sender, RoutedEventArgs e)
        {
            brushcolor = Brushes.Blue;
        }

        private void black_Checked(object sender, RoutedEventArgs e)
        {
            brushcolor = Brushes.Black;
        }

        private void myCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ispaint = true;
        }

        private void myCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ispaint = false;
        }

        private void myCanvas_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (ispaint)
            {
                Point mouseposition = e.GetPosition(myCanvas);
                paintcircle(brushcolor, mouseposition);
            }
            if (iseraise)
            {
                Point mouseposition = e.GetPosition(myCanvas);
                paintcircle(brushcolor, mouseposition);
            }
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            int count = myCanvas.Children.Count;

            if (count > 0)
                myCanvas.Children.RemoveAt(count - 1);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bowserwindow bw = new Bowserwindow();
            bw.Show();
            this.Close();
        }



        private void Notepad_Click(object sender, RoutedEventArgs e)
        {
            Form1 fm = new Form1();
            fm.ShowDialog();

        }

        private void Calculator_Click(object sender, RoutedEventArgs e)
        {
            calculator cl = new calculator();
            cl.ShowDialog();

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Image"; // Default file name
            dlg.DefaultExt = ".png"; // Default file extension
            dlg.Filter = "PNG File (.png)|*.png"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string filename = dlg.FileName;
                SaveCanvasToFile(this, myCanvas, 96, filename);
            }
        }

        public static void SaveCanvasToFile(Window window, Canvas canvas, int dpi, string filename)
        {
            Size size = new Size(window.Width, window.Height);
            canvas.Measure(size);
            //canvas.Arrange(new Rect(size));

            var rtb = new RenderTargetBitmap(
                (int)window.Width, //width
                (int)window.Height, //height
                dpi, //dpi x
                dpi, //dpi y
                PixelFormats.Pbgra32 // pixelformat
                );
            rtb.Render(canvas);

            SaveRTBAsPNGBMP(rtb, filename);
        }

        public static void SaveWindowToFile(Window window, int dpi, string filename)
        {
            var rtb = new RenderTargetBitmap(
                (int)window.Width, //width
                (int)window.Width, //height
                dpi, //dpi x
                dpi, //dpi y
                PixelFormats.Pbgra32 // pixelformat
                );
            rtb.Render(window);

            SaveRTBAsPNGBMP(rtb, filename);
        }

        private static void SaveRTBAsPNGBMP(RenderTargetBitmap bmp, string filename)
        {
            var enc = new System.Windows.Media.Imaging.PngBitmapEncoder();
            enc.Frames.Add(System.Windows.Media.Imaging.BitmapFrame.Create(bmp));

            using (var stm = System.IO.File.Create(filename))
            {
                enc.Save(stm);
            }
        }

    }
}

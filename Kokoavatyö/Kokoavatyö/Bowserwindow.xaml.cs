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
using System.Windows.Shapes;

namespace Kokoavatyö
{
    /// <summary>
    /// Interaction logic for Bowserwindow.xaml
    /// </summary>
    public partial class Bowserwindow : Window
    {
        public Bowserwindow()
        {
            InitializeComponent();
        }

        private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            
                myweb.Source = new Uri("http://www.google.com");
            
        }
        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

    }
}

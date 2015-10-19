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

namespace Spp3Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Image";
            openFileDialog.Filter = "Image File|*.bmp; *.gif; *.jpg; *.jpeg; *.png;";
            if (openFileDialog.ShowDialog() == true)
            {
                BitmapImage b = new BitmapImage();
                b.BeginInit();
                b.UriSource = new Uri(openFileDialog.FileName);
                b.EndInit();
                if (b.Height > 461 || b.Width > 366)
                {
                    ImagePanel.Stretch = Stretch.Fill;
                }
                else
                {
                    ImagePanel.Stretch = Stretch.None;
                }
                ImagePanel.Source = b;
            }
        }
    }
}

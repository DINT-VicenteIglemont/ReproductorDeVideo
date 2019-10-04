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

namespace ReproductorDeVideo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Trailer1Radio_Checked(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Source = new Uri(@"C:\Users\alumno\Desktop\trailer1.mp4");
        }

        private void Trailer2Radio_Checked(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Source = new Uri(@"C:\Users\alumno\Desktop\trailer2.mp4");
        }

        private void PLayButton_Click(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            VideoPlayer.Stop();
        }

        private void SilencioCheckBox_Checked(object sender, RoutedEventArgs e)
        {
        }
    }
}

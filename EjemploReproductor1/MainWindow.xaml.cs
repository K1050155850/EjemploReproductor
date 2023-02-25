
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

namespace EjemploReproductor1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WMPLib.WindowsMediaPlayer media = new WMPLib.WindowsMediaPlayer();
       
        public MainWindow()
        {
            InitializeComponent();
        }

        string[] archivo, musica;

        private void brdPlay_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            media.URL = "C:\\Users\\cuent\\Downloads\\Suyay Samy.mp3";
            media.controls.play();

        }

        private void brdList_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {


            
        }

        private void brdAnterior_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            media.controls.previous();
        }

        private void brdSiguiente_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            media.controls.next();
        }

        private void brdPause_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(media!= null)
            {
                media.controls.pause();

            }
           /* if (media != null)
            {
                double tiempo = media.controls.currentPosition;
                media.controls.currentPosition = tiempo;
                media.controls.play();
            }*/

        }


       
    }
}

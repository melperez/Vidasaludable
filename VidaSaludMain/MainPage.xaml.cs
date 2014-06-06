using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace VidaSaludMain
{
    public partial class MainPage : PhoneApplicationPage
    {
        private int m_intBandera = 0;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Vistas/BienvenidaPage.xaml", UriKind.Relative));
            m_intBandera++;
        }

        private void btnWeek1_Click(object sender, RoutedEventArgs e)
        {
            this.DesbloquearSemana(1, "/Assets/Tiles/Deporte.jpg");
        }

        private void btnWeek2_Click(object sender, RoutedEventArgs e)
        {
            this.DesbloquearSemana(2, "/Assets/Tiles/Metas.jpg");
        }
        private void btnWeek3_Click(object sender, RoutedEventArgs e)
        {
            this.DesbloquearSemana(3, "/Assets/Tiles/Alimentacion.jpg");
        }

        private void btnWeek4_Click(object sender, RoutedEventArgs e)
        {
            this.DesbloquearSemana(4, "/Assets/Tiles/Salud.jpg");
            
        }




        private void DesbloquearSemana(int p_intSemana, string URI)
        {
            if (m_intBandera == p_intSemana)
            {
                ImageBrush l_objNonBlockBg = new ImageBrush();
                l_objNonBlockBg.ImageSource = new System.Windows.Media.Imaging.BitmapImage(new Uri(URI, UriKind.Relative));
                this.btnWeek1.Background = l_objNonBlockBg;
                m_intBandera++;
            }
            else
                if (m_intBandera <= p_intSemana - 1)
                    MessageBox.Show("Debes completar la Semana " + (p_intSemana - 1), "Bloqueado", MessageBoxButton.OK);

        
        }


    }

}

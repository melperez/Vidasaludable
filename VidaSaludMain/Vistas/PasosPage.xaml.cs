using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;


namespace VidaSaludMain.Vistas
{
    public partial class PasosPage : PhoneApplicationPage
    {
        private int g_intBandera = 0;

        public PasosPage()
        {
            InitializeComponent();
            this.btnComenzar.IsEnabled = false;
            this.ItemPaso1.Tap += Item_Loaded;
            this.ItemPaso2.Tap += Item_Loaded;
            this.ItemPaso3.Tap += Item_Loaded;
            this.ItemPaso4.Tap += Item_Loaded;
            this.ItemPaso5.Tap += Item_Loaded;
            this.ItemPaso6.Tap += Item_Loaded;
        }   

        public void Item_Loaded(object sender, RoutedEventArgs e)
        {
            PivotItem p = (PivotItem)sender;

            switch (p.Header.ToString())
            {
                case "Paso 1":
                    if (g_intBandera == 0)
                        g_intBandera++;
                    break;
                case "Paso 2":
                    if (g_intBandera == 1)
                         g_intBandera++;;
                    break;
                case "Paso 3":
                    if (g_intBandera == 2)
                         g_intBandera++;;
                    break;
                case "Paso 4":
                    if (g_intBandera == 3)
                         g_intBandera++;;
                    break;
                case "Paso 5":
                    if (g_intBandera == 4)
                        g_intBandera++;;
                    break;
                default:
                    if (g_intBandera > 4)
                        btnComenzar.IsEnabled = true;
                    break;
            }
        }


        public void btnComenzar_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBox messageBox = new CustomMessageBox()
            {
                Caption = "Bienvenido a su nueva aventura por la salud",
                Message = "De ahora en adelante conocerá los secretos para llevar una vida saludable. Desea saber más?",
                LeftButtonContent = "Continuar",
                RightButtonContent = "Cancelar"
            };

            messageBox.Dismissed += (s1, e1) =>
            {
                switch (e1.Result)
                {
                    case CustomMessageBoxResult.LeftButton:
                        this.NavigationService.Navigate(new Uri("/Vistas/Semanas/Semana1.xaml", UriKind.Relative));
                        break;
                    case CustomMessageBoxResult.RightButton:
                        MessageBox.Show("Oh, vuelve pronto!");
                        break;
                    case CustomMessageBoxResult.None:
                        MessageBox.Show("Debes seleccionar una opción para continuar");
                        break;
                    default:
                        break;
                }
            };
            messageBox.Show();

        }


    }
}
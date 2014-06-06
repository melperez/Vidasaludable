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
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            this.btnAddMeta.Click += btnAddMeta_Click;
        }

        public void GoHome(object sender, EventArgs e)
        {
            PhoneApplicationFrame root = Application.Current.RootVisual as PhoneApplicationFrame;
            root.Navigate(new Uri("/../MainPage.xaml", UriKind.Relative));
        }

        public void CrearMeta(object sender, EventArgs e)
        {
            this.PopUpMessage.IsOpen = true;
            

        }

        public void btnAddMeta_Click(object sender, RoutedEventArgs e)
        {
            CheckBox l_chkBoxNewMeta = new CheckBox();
            l_chkBoxNewMeta.BorderBrush = this.ckboxMeta1.BorderBrush;
            l_chkBoxNewMeta.Foreground = this.ckboxMeta1.Foreground;
            l_chkBoxNewMeta.Content = this.txtNewMeta.Text.ToString();
            this.pnlMetas.Children.Insert(0,l_chkBoxNewMeta);
            pnlMetas.Height += l_chkBoxNewMeta.Height;
            MessageBox.Show("Su meta ha sido anexada exitosamente!");
            this.PopUpMessage.IsOpen = false;
        }

    }
}
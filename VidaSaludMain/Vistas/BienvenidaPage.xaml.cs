using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using VidaSaludMain.Resources;

namespace VidaSaludMain.Vistas
{
    public partial class BienvenidaPage : PhoneApplicationPage
    {
        public BienvenidaPage()
        {
            InitializeComponent();
            string introtext = AppResources.Intro.ToString();
        }


        
    }
}
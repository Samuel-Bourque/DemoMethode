using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace DemoMethodes_UI
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Thread.CurrentThread.CurrentCulture =
                   new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture =
                    new System.Globalization.CultureInfo("en-US");
        }
    }
}

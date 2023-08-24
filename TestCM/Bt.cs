using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestCM.ViewModels;
using TestCM.Views;

namespace TestCM
{
    internal class Bt : BootstrapperBase
    { 
        public Bt()
        {
            Initialize();
        }
         
        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
            // it is work
            await DisplayRootViewForAsync<ParentViewModel>();
            // it is not work
            // await DisplayRootViewForAsync<MainViewModel>();
        }
         
    }
}

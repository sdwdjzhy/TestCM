using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCM.ViewModels
{
    internal class MainViewModel : Conductor<Screen>.Collection.OneActive
    {
        public MainViewModel()
        {
            Task.Run(async () =>
            {
                await ActivateItemAsync(new ParentViewModel());
            });
        }

    }
}

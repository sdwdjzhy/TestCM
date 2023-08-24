using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCM.ViewModels
{
    internal class ParentViewModel : Screen
    {
        public bool IsOpen { get; set; }

        public ChildViewModel CView { get; set; } = new ChildViewModel();

        public void Open()
        {
            IsOpen = true;
        }


        public void Close()
        {
            IsOpen = false;
        }
    }
}

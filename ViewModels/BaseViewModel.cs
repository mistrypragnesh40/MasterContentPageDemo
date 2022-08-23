using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContentPageDemo.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _headerText;

        [ObservableProperty]
        private string _footerText;

        [ObservableProperty]
        private string _headerLogo;

        public BaseViewModel()
        {
            HeaderText = "Pragnesh Mistry";
            FooterText = "Powered By: Xamarin Coding Tutorial";
            HeaderLogo = "user";
        }

    }
}

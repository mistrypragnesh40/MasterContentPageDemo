using MasterContentPageDemo.Views;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MasterContentPageDemo.ViewModels
{
    public partial class TestPageViewModel : BaseViewModel 
    {


        public ICommand NavigateToOtherPageCommand => new Command(() =>
        {
            AppShell.Current.GoToAsync($"{nameof(TestPage1)}");
        });
    }
}

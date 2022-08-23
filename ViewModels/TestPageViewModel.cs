using MasterContentPageDemo.Views;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContentPageDemo.ViewModels
{
    public partial class TestPageViewModel : BaseViewModel 
    {


        [ICommand]
        public void NavigateToOtherPage()
        {
            AppShell.Current.GoToAsync($"{nameof(TestPage1)}");
        }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using Merchant.Models;
using Merchant.Navigation;
using Merchant.Tools;
using Merchant.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Merchant.ViewModels
{

    public class Tacir_InfoViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;
        public Tacir_InfoViewModel(INavigationService navigation)
        {
            this.navigationService = navigation;
        }

    }
    
}

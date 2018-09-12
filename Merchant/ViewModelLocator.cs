/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Merchant"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

//using Autofac;
//using Autofac.Configuration;
using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using Merchant.Navigation;
using Merchant.ViewModels;
using Merchant.Views;
using System;
using System.Windows;

namespace Merchant.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>z
    class ViewModelLocator
    {
       private NavigationService navigationService=new NavigationService() ;

        private IViewService viewService = ServiceManager.RegisterService<IViewService>(new ViewService());
       
        //TODO: Add VMs
        public AppViewModel AppViewModel;
        public Tacir_InfoViewModel TacirViewModel;
       

        public ViewModelLocator()
        {

            AppViewModel = new AppViewModel();
            TacirViewModel = new Tacir_InfoViewModel(navigationService);
           
            navigationService.AddPage(AppViewModel, ViewType.AppView);
            navigationService.AddPage(TacirViewModel, ViewType.Tacir_Info);
            navigationService.NavigateTo(ViewType.Tacir_Info);



           
            
        }
    }
}
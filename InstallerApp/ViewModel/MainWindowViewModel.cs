using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstallerApp.ViewModel;

namespace InstallerApp.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        HomeViewModel homeViewModel = new HomeViewModel();
        Page1ViewModel page1ViewModel = new Page1ViewModel();
        Page2ViewModel page2ViewModel = new Page2ViewModel();

        private BindableBase currentViewModel;
        public BindableBase CurrentViewModel
        {
            get { return currentViewModel; }
            set { SetProperty(ref currentViewModel, value); }
        }


        public MainWindowViewModel()
        {
            CurrentViewModel = homeViewModel;
            homeViewModel.ViewSwitch += SwitchCurrentViewModel;
            page1ViewModel.ViewSwitch += SwitchCurrentViewModel;
            page2ViewModel.ViewSwitch += SwitchCurrentViewModel;
        }

        private void SwitchCurrentViewModel(string vmName)
        {
            switch (vmName)
            {
                case "Page1":
                    CurrentViewModel = page1ViewModel;
                    break;
                case "Home":
                    CurrentViewModel = homeViewModel;
                    break;
                case "Page2":
                    CurrentViewModel = page2ViewModel;
                    break;
                default:
                    break;
            }
        }

    }
}

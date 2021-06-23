using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerApp.ViewModel
{
    

    public class HomeViewModel : BindableBase
    {       

        public RelayCommand InstallCommand { get; set; }        

        public HomeViewModel()
        {
            InstallCommand = new RelayCommand(SwitchToPage1);
        }        

        private void SwitchToPage1()
        {
            OnViewSwitch("Page1");
        }
    }
}

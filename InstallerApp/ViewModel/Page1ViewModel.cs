using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerApp.ViewModel
{
    public class Page1ViewModel : BindableBase
    {
        public RelayCommand Page1PreviousCommand { get; set; }
        public RelayCommand Page1NextCommand { get; set; }


        public Page1ViewModel()
        {
            Page1PreviousCommand = new RelayCommand(SwitchBackToHomePage);
            Page1NextCommand = new RelayCommand(SwitchToPage2);
        }

        private void SwitchToPage2()
        {
            OnViewSwitch("Page2");
        }

        private void SwitchBackToHomePage()
        {
            OnViewSwitch("Home");
        }
    }
}

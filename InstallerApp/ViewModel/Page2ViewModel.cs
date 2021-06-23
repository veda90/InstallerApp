using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallerApp.ViewModel
{
    public class Page2ViewModel : BindableBase
    {
        public RelayCommand Page2PreviousCommand { get; set; }
        public RelayCommand Page2FinishCommand { get; set; }


        public Page2ViewModel()
        {
            Page2PreviousCommand = new RelayCommand(SwitchBackToPage1);
            Page2FinishCommand = new RelayCommand(CloseApplication);
        }

        private void SwitchBackToPage1()
        {
            OnViewSwitch("Page1");
        }

        private void CloseApplication()
        {
            //TODO
        }
    }
}

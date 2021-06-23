using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InstallerApp
{
    public class RelayCommand: ICommand
    {
        Predicate<object> targetCanExecuteMethod;
        Action targetExecuteMethod;

        public RelayCommand(Action  executeMethod)
        {
            targetExecuteMethod = executeMethod;
        }
        public RelayCommand(Action executeMethod, Predicate<object> canExecuteMethod)
        {
            targetExecuteMethod = executeMethod;
            targetCanExecuteMethod = canExecuteMethod;
        }


        public event EventHandler CanExecuteChanged = delegate { };

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        public bool CanExecute(object param)
        {
            if(targetCanExecuteMethod != null)
            {
                return targetCanExecuteMethod(param);
            }
            if(targetExecuteMethod != null)
            {
                return true;
            }
            return false;
        }

        public void Execute(object param)
        {
            if(targetExecuteMethod != null)
            {
                targetExecuteMethod();
            }
        }
    }
}

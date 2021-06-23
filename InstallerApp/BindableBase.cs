﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InstallerApp
{
    public delegate void ViewSwitcher(string vmName);

    public class BindableBase : INotifyPropertyChanged
    {
        protected virtual void SetProperty<T>(ref T member,T value,[CallerMemberName] string propertyName = null)
        {
            if (object.Equals(member, value)) return;

            member = value;
            OnPropertyChanged(propertyName);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public event ViewSwitcher ViewSwitch;

        public void OnViewSwitch(string vmName)
        {
            ViewSwitch?.Invoke(vmName);
        }
    }
}

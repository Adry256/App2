﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Aapp2.ViewModels
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string nombrePropiedad)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nombrePropiedad));
        }


    }
}

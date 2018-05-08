﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImageServiceWPF.VModel
{
    interface IMainWindowViewModel : INotifyPropertyChanged
    {
        bool VM_IsConnected { get; }
        ICommand DisconnectCommand { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageServiceWPF.Model;

namespace ImageServiceWPF.VModel
{
    class LogsViewModel : ILogsViewModel
    {
        private ILogsModel model;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<string> logEntries;

        public LogsViewModel()
        {
            model = new LogsModel();
            this.model.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                this.NotifyPropertyChanged("VM_" + e.PropertyName);
            };
        }

        private void NotifyPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public ObservableCollection<string> VM_LogEntries
        {
            get
            {
                return this.model.LogEntries;
            }
        }


        
    }
}
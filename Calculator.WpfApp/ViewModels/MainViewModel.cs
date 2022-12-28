﻿using Calculator.WpfApp.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Calculator.WpfApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel() 
        {
            ScreenVal = "0";
            AddNumberCommand = new RelayCommand(AddNumber);
        }

        private void AddNumber(object obj)
        {
            MessageBox.Show("Test");
        }

        private string _screenVal;

        public ICommand AddNumberCommand { get; set; }

        public string ScreenVal
        {
            get { return _screenVal; }
            set 
            { 
                _screenVal = value; 
                OnPropertyChanged();
            }
        }



        public event PropertyChangedEventHandler
            PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

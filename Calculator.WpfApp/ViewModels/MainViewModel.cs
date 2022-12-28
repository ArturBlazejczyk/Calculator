using Calculator.WpfApp.Commands;
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
            ScreenVal = "1";
            AddNumberCommand = new RelayCommand(AddNumber);
            AddOperationCommand = new RelayCommand(AddOperation);
        }

        private void AddOperation(object obj)
        {
            ScreenVal += obj;
        }

        private void AddNumber(object obj)
        {
            if (ScreenVal == "0")
                ScreenVal = (string)obj;
            else
                ScreenVal += obj;
        }

        private string _screenVal;

        public ICommand AddNumberCommand { get; set; }
        public ICommand AddOperationCommand { get; set; }



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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp16.Command;
using WpfApp16.Views;

namespace WpfApp16.ViewModels
{
    public class MainViewModel
    {
        public ICommand? NewWindow { get; set; }


        public MainViewModel()
        {
            NewWindow = new RelayCommand(ExecuteNewWindow, CanExecuteNewWindow);
        }

        void ExecuteNewWindow(object? parameter)
        {
            AddView addview = new AddView();
            addview.ShowDialog();
        }
        bool CanExecuteNewWindow(object? parameter)
        {
            return true;
        }

    }
}

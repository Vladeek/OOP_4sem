using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LPLab06_07.ViewModels.Commands
{
    public class DeleteElementCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action< ShopElement> _execute;

        public DeleteElementCommand(Action<ShopElement> execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter as ShopElement);
        }
    }
}

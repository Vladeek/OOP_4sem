using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LPLab06_07.ViewModels.Commands
{
    public class EditElementCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<ShopElement> _execute;

        public EditElementCommand(Action<ShopElement> execute)
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

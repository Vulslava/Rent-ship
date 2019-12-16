using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Rent_ship.ViewModel
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canexecute;
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public RelayCommand(Action<object> execute, Func<object, bool> canexecute = null)
        {
            this.execute = execute;
            this.canexecute = canexecute;
        }
        public bool CanExecute(object par)
        {
            return this.canexecute == null || this.canexecute(par);
        }
        public void Execute(object par)
        {
            this.execute(par);
        }
    }
}

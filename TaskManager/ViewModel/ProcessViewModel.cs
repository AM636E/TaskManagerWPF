using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.ObjectModel;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using TaskManager.Model;

namespace TaskManager.ViewModel
{
    class ProcessViewModel : ViewModelBase
    {
        private ProcessModel _model = new ProcessModel();

        public ProcessViewModel()
        {
            _model = new ProcessModel();
            _model.Load();
            
        }

        public RelayCommand<Process> KillProcessCommand
        {
            get;
            set;
        }

        public ObservableCollection<Process> Processes
        {
            get { return _model.Processes; }
        }

        public void ShowAllProcesses()
        {
            _model.Load();
            RaisePropertyChanged("Processes");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Windows;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using TaskManager.Model;

namespace TaskManager.ViewModel
{
    class ProcessViewModel : ViewModelBase
    {
        private ProcessModel _model;

        public ProcessViewModel()
        {
            _model = new ProcessModel();
            _model.Load();

            KillProcessCommand = new RelayCommand<Process>(KillProcess);            
        }

        private void KillProcess(Process p)
        {
            p.Kill();
            _model.Load();
            
        }

        public RelayCommand<Process> KillProcessCommand
        {
            get;
            set;
        }

        //public static DependencyProperty ProcessesProperty = DependencyProperty.Register
        //    ("Processes", typeof(ObservableCollection<Process>), typeof(ProcessViewModel));

        public ObservableCollection<Process> Processes
        {
            get { return _model.Processes;  }
            set { _model.Processes = value; }
        }

        public void ShowAllProcesses()
        {
            _model.Load();
            RaisePropertyChanged("Processes");
        }
    }
}

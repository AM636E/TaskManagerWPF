using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace TaskManager.Model
{
    class ProcessModel
    {
        private ObservableCollection<Process> _processes;

        public ObservableCollection<Process> Processes
        {
            get 
            {
                _processes.CollectionChanged += (o, e) => { System.Windows.MessageBox.Show("Changed"); };
                return _processes; 
            }
            set { _processes = value; }
        }

        public ProcessModel()
        {
            _processes = new ObservableCollection<Process>();
        }

        public void Load()
        {
            foreach(Process p in Process.GetProcesses())
            {
                _processes.Add(p);
            }
        }
    }
}

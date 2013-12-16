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
            get { return _processes; }
        }

        public ProcessModel()
        {
            _processes = new ObservableCollection<Process>();
        }

        public void Load()
        {
            /*_processes = (ObservableCollection<Process>)
                         (from p in Process.GetProcesses()
                          select p).AsEnumerable<Process>();*/

            foreach(Process p in Process.GetProcesses())
            {
                _processes.Add(p);
            }
        }
    }
}

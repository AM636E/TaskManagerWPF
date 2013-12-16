using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskManager.Entitites
{
    class TMProcess
    {
        private int _pid;

        public TMProcess(int pid)
        {
            Process p = Process.GetProcessById(pid);

        }
    }
}

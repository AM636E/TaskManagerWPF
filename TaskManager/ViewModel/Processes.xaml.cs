using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaskManager.ViewModel
{
    /// <summary>
    /// Interaction logic for Processes.xaml
    /// </summary>
    public partial class ProcessesControl : UserControl
    {
        public static DependencyProperty ProcessesPropery = DependencyProperty.Register
            (
                "Processes",
                typeof(ObservableCollection<Process>),
                typeof(Process)
            );

        public ObservableCollection<Process> Processes
        {
            get { return (ObservableCollection<Process>)GetValue(ProcessesControl.ProcessesPropery); }
            set { SetValue(ProcessesControl.ProcessesPropery, value); }
        }

        public ProcessesControl()
        {
            InitializeComponent();
        }
    }
}

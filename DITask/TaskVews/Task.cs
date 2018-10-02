using DITask.Help_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITask.TaskVews
{
    class Task: ObservableObject
    {
        private string _name;

        public string TaskName
        {
            get { return _name; }
            set {
                if (value != _name)
                {
                    _name = value;
                    OnPropertyChanged("TaskName");
                }
            }
        }
    }
}

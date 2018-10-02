using System;

using System.Globalization;
using System.Windows.Data;
using System.Windows.Controls;

namespace DITask.Help_Classes
{
  class ButtonColorConverter : ObservableObject
    {
        private System.Windows.Media.Brush _b;
        public System.Windows.Media.Brush BackgroundColour
        {
            get { return _b; }
            set { _b = value; RaisePropertyChanged("BackgroundColour"); }
        }
        private string _s;
        public string SomeOtherProperty
        {
            get { return _s; }
            set { _s = value; RaisePropertyChanged("SomeOtherProperty"); BackgroundColour = System.Windows.Media.Brushes.Green; }
        }
    }
}

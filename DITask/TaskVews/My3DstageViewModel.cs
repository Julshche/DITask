using DITask.Help_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace DITask.TaskVews
{
    class My3DstageViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get { return "3D"; }
        }

        

        private Model3DGroup model;

        public Model3DGroup Model
        {
            get { return model; }
            set
            {
                if (value != model)
                {
                    model = value;
                    OnPropertyChanged("Model");
                }
            }
        }

        //public void SetModel(Model3DGroup value)
        //{
        //    if (model != value)
        //    { model = value; OnPropertyChanged("Model"); }
        //}

       
    }
}

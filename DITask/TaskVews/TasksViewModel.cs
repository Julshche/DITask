using DITask.Help_Classes;
using HelixToolkit.Wpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace DITask.TaskVews
{
    class TasksViewModel : ObservableObject, IPageViewModel
    {
        #region Fields
        
        private string _s;
        private Brush _b;
        private Model3DGroup mymodel;
        public string Name => "TASK 3";
        //private IPageViewModel _taskview3D;
        #endregion

        //public List<string> Name => new List<string> { "TASK 3", "TASK 5" };

        public Model3DGroup MyModel {
            get
            {
                return mymodel;
            }
            set
            {
                mymodel = value;
                OnPropertyChanged("MyModel");
            }
        }


        private RelayCommand _Load;
        public RelayCommand Load
        {
            get { return _Load ?? (_Load = new RelayCommand(OnLoad)); }
        }

        private void OnLoad(object param)
        {
           
           // Model3DGroup model1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Text files (*.obj)|*.obj";
            // amount of Zoom
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.);
            if (openFileDialog.ShowDialog() == true)
            {
                string filename = openFileDialog.FileName;
                ModelImporter import = new ModelImporter();
                DiffuseMaterial material = new DiffuseMaterial(new SolidColorBrush(Colors.Beige));
               
                import.DefaultMaterial = material;
               MyModel = import.Load(filename);
               
                
                //T = model1;
            
            }
        }
       
        private RelayCommand _Clear;
        public RelayCommand Clear
        {
            get { return _Clear ?? (_Clear = new RelayCommand(OnClear)); }
        }
        private void OnClear(object param)
        {
            MyModel = new Model3DGroup();
            OnPropertyChanged("MyModel");
            

        }

     
        #region try to change button`s background. Doesn`t work


        public Brush Background
        {
            get { return _b; }
            set { _b = value; OnPropertyChanged("Background"); }
        }
        public string SomeOtherProperty
        {
            get { return _s; }
            set { _s = value; OnPropertyChanged("SomeOtherProperty"); Background = System.Windows.Media.Brushes.Green; }
        }

      
        #endregion
    }
}
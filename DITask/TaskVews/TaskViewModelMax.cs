using DITask.Help_Classes;
using HelixToolkit.Wpf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;

namespace DITask.TaskVews
{
    class TaskViewModelMax : ObservableObject, IPageViewModel
    {
        #region Fields
        public string Name => "TASK 5";
        private Model3DGroup mymodel;
        private Rotation3D rotation;
        private RotateTransform3D transform;
        private TranslateTransform3D translate;
        double _maxZ;
        double _minZ;
        DoubleAnimation animation;

        #endregion

        public Model3DGroup MyModel
        {
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

        public double MaxZ
        {
            get { return _maxZ; }
            set
            {
                
                _maxZ = value;
            }
        }
        public double MinZ
        {
            get { return _minZ; }
            set
            {
                //move(value);
                _minZ = value;
            }
        }

        private RelayCommand _Start;
        public RelayCommand Start
        {
            get { return _Start ?? (_Start = new RelayCommand(OnStart)); }
        }


        private void OnStart(object param)
        {
            if (MyModel != null)
            {
                translate = new TranslateTransform3D();
                translate.OffsetZ = MinZ;
                MyModel.Transform = translate;
                animation = new DoubleAnimation(MaxZ, new Duration(TimeSpan.FromSeconds(1)));
                animation.AutoReverse = true;
                animation.RepeatBehavior = RepeatBehavior.Forever;
                translate.BeginAnimation(TranslateTransform3D.OffsetZProperty, animation);
            }
            #region rotation
            //if (MyModel != null)
            //{
            //    rotation = new AxisAngleRotation3D(new Vector3D(0, 0, 1), 0);
            //    transform = new RotateTransform3D(rotation);
            //    MyModel.Transform = transform;
            //    animation = new DoubleAnimation(360, new Duration(TimeSpan.FromSeconds(1)));
            //    animation.RepeatBehavior = RepeatBehavior.Forever;
            //    rotation.BeginAnimation(AxisAngleRotation3D.AngleProperty, animation);
            //}
            #endregion

        }

        private RelayCommand _Stop;
        public RelayCommand Stop
        {
            get { return _Stop ?? (_Stop = new RelayCommand(OnStop)); }
        }
        private void OnStop(object param)
        {

            animation.RepeatBehavior = new RepeatBehavior(0.1);
            translate.BeginAnimation(TranslateTransform3D.OffsetZProperty, animation);

            #region rotation
            //animation.RepeatBehavior = new RepeatBehavior(0.1);
            //rotation.BeginAnimation(AxisAngleRotation3D.AngleProperty, animation);
            #endregion
        }


        //void move(double angle)
        //{
        //    //new group of transformations, the group will "add" movements
        //    var Group_3D = new Transform3DGroup();
        //    Group_3D.Children.Add(MyModel.Transform);

            //    //we need to find out where our old point is now
            //    Point3D origin = Group_3D.Transform(new Point3D(-461, 1457, -157));

            //    //create new transformation
            //    RotateTransform3D antebrachium_dexter_transform = new RotateTransform3D(new AxisAngleRotation3D(new Vector3D(0, 1, 0), angle));
            //    antebrachium_dexter_transform.CenterX = origin.X;
            //    antebrachium_dexter_transform.CenterY = origin.Y;
            //    antebrachium_dexter_transform.CenterZ = origin.Z;

            //    //add it to the transformation group (and therefore to the femores movement
            //    Group_3D.Children.Add(antebrachium_dexter_transform);

            //    //Apply the transform
            //    MyModel.Transform = Group_3D;
            //}

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



        //public List<string> Name => new List<string> { "TASK 3", "TASK 5" }; 
    }


}

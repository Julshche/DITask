using DITask.Help_Classes;
using DITask.TaskVews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DITask
{
    class AppViewModel : ObservableObject
    {
        #region Fields

        private RelayCommand _changePageCommand;
       
        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pageViewModels;
        
        #endregion

        public AppViewModel()
        {
            // Add available pages
            PageViewModels.Add(new TasksViewModel());
            //PageViewModels.Add(new ProductsViewModel());
            //PageViewModels.Add(new TasksViewModel());
            PageViewModels.Add(new TaskViewModelMax());
            // Set starting page
            CurrentPageViewModel = PageViewModels[0];
        }

        #region Properties / Commands


        public RelayCommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }

                return _changePageCommand;
            }
        }

        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }

        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }

        #endregion

        #region Methods

       
        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageViewModels.Contains(viewModel))
                PageViewModels.Add(viewModel);

            CurrentPageViewModel = PageViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        #endregion
    }
}
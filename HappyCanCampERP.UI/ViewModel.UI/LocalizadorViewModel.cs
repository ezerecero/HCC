

namespace HappyCanCampERP.UI.ViewModel.UI
{
    public class LocalizadorViewModel
    {
        private static MainWindowViewModel
            _mainWindowViewModel;
        public static MainWindowViewModel
            MainWindowViewModelStatic
        {
            get
            {
                if (_mainWindowViewModel == null)
                {
                    //_mainWindowViewModel = new MainWindowViewModel(new UIDataProvider());
                }

                return _mainWindowViewModel;
            }
        }
    }
}


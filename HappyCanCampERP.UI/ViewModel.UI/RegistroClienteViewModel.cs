using System;
using System.ComponentModel;
using HappyCanCampERP.UI.Domain;

namespace HappyCanCampERP.UI.ViewModel.UI
{
    public class RegistroClienteViewModel : INotifyPropertyChanged
    {
        private string _nombre;

        public RegistroClienteViewModel()
        {
          

        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                this.MutateVerbose(ref _nombre, value, RaisePropertyChanged());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
        {
            return args => PropertyChanged?.Invoke(this, args);
        }
        
    }
}

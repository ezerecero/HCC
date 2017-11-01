using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UnaSolucionDigital.Validador
{
    public class ObservableObjectValidador : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this , new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

using System.Collections.ObjectModel;
using HappyCanCampERP.UI.Domain;

namespace HappyCanCampERP.UI.ViewModel.UI
{
    class ServiciosViewModel
    {
        private readonly ObservableCollection<SelectableViewModel> _items2;

        public ServiciosViewModel()
        {
            
            _items2 = CreateData();
            
        }

        private static ObservableCollection<SelectableViewModel> CreateData()
        {
            return new ObservableCollection<SelectableViewModel>
            {
                new SelectableViewModel
                {
                    Code = 'G',
                    Name = "Fido",
                    Description = "Boxer",
                    Food = "Canino GRANDE"
                },
                new SelectableViewModel
                {
                    Code = 'P',
                    Name = "Pequeño",
                    Description = "Popi",
                    Food = "Canino CHICO"

                },
                new SelectableViewModel
                {
                    Code = 'G',
                    Name = "Chata",
                    Description = "Canino GRANDE"
                },
                new SelectableViewModel
                {
                    Code = 'G',
                    Name = "Fido",
                    Description = "Boxer",
                    Food = "Canino GRANDE"
                },
                new SelectableViewModel
                {
                    Code = 'P',
                    Name = "Pequeño",
                    Description = "Popi",
                    Food = "Canino CHICO"

                },
                new SelectableViewModel
                {
                    Code = 'G',
                    Name = "Chata",
                    Description = "Canino GRANDE"
                },new SelectableViewModel
                {
                    Code = 'G',
                    Name = "Fido",
                    Description = "Boxer",
                    Food = "Canino GRANDE"
                },
                new SelectableViewModel
                {
                    Code = 'P',
                    Name = "Pequeño",
                    Description = "Popi",
                    Food = "Canino CHICO"

                },
                new SelectableViewModel
                {
                    Code = 'G',
                    Name = "Chata",
                    Description = "Canino GRANDE"
                }




            };
        }

        public ObservableCollection<SelectableViewModel> Items2 => _items2;

    }
}

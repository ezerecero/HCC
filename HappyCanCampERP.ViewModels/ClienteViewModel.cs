using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using UnaSolucionDigital.Validador;

namespace HappyCanCampERP.ViewModels
{
    public class ClienteViewModel: ValidadorEnViewModel
    {
        private string _nombre;
        private string _correo;
        private string _telefono;

        //Bueno los atributos estos se usan para definir lo que ya viene predefinido que digamos
        //es para no reinventar la rueda
        //[StringLength(32 , MinimumLength = 4)]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Hay que poner un nombre")]
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
                NotifyPropertyChanged();
            }
        }

        [EmailAddress]
        public string Correo
        {
            get { return _correo; }
            set
            {
                _correo = value;
                NotifyPropertyChanged();
            }
        }

        [Phone]
        public string Telefono
        {
            get { return _telefono; }
            set
            {
                _telefono = value;
                NotifyPropertyChanged();
            }
        }


        //Y este metodo se usa en caso de que los atributos no sean suficientes y se tenga que validar algo muy especifico
        //y es muy probable que lo tenga que usar cuando se haya que guardar los datos.
        protected override string OnValidate(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
                return "El nombre no puede estar vacio";
            return base.OnValidate(propertyName);
        }
    }
}

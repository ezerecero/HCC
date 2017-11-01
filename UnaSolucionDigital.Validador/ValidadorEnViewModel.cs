


using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace UnaSolucionDigital.Validador
{
    public abstract class ValidadorEnViewModel : ObservableObjectValidador, IDataErrorInfo
    {
        public string this[string columnName]
        {
            get { return OnValidate(columnName); }
        }

        public string Error
        {
            get
            {
                throw new NotSupportedException();
            }
        }
        
        protected virtual string OnValidate(string propertyName)
        {
            var context = new ValidationContext(this)
            {
                MemberName = propertyName
            };

            var results = new Collection<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this , context , results , true);

            //Esta linea de código tiene un error 
            //TODO
            //Pendiente corregir
            //return !isValid ? result[0].ErrorMessage : null;
            //YA CON LAS LINEAS SIGUENTES QUEDO CORREJIDO

            if (!isValid)
            {
                ValidationResult result = results.SingleOrDefault(p =>
                    p.MemberNames.Any(memberName =>
                        memberName == propertyName));
                return result == null ? null : result.ErrorMessage;

            }
            return null;
        }
    }
}

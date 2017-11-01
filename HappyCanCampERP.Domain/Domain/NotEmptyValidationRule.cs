﻿using System.Globalization;
using System.Windows.Controls;

namespace HappyCanCampERP.Domain.Domain
{
    public class NotEmptyValidationRule: ValidationRule
    {
        public override ValidationResult Validate(object value , CultureInfo cultureInfo)
        {
            return string.IsNullOrWhiteSpace((value ?? "").ToString())
                ? new ValidationResult(false , "Campo Requerido.")
                : ValidationResult.ValidResult;
        }
    }
}
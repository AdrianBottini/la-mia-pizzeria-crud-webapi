﻿using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_crud_mvc.Attributes
{
    public class MoreThenZeroPriceAttribute : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int? price = (int?)value;
            if (price <= 0)
            {
                return new ValidationResult(ErrorMessage ?? "Il prezzo deve essere maggiore di 0");
            }
            return ValidationResult.Success;
        }
    }
}

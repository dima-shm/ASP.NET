using AspCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore.Validation
{
    public class CustomValidator : ValidationAttribute
    {
        private int years;

        public CustomValidator(int a)
        {
            years = a;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime birthday = ((Person)validationContext.ObjectInstance).BDay;

            if ((DateTime.Now.Year - birthday.Year) > years)
            {
                return new ValidationResult("Возраст не более 120 лет");
            }
            return ValidationResult.Success;
        }
    }
}

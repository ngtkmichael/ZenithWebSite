using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ZenithWebSite.Models
{
    public class BeforeEndDateAttribute : ValidationAttribute
    {
        public string startDatePropertyName { get; set; }
        public string endDatePropertyName { get; set; }


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            PropertyInfo startDateProperty = validationContext.ObjectType.GetProperty(startDatePropertyName);
            PropertyInfo endDateProperty = validationContext.ObjectType.GetProperty(endDatePropertyName);

            DateTime startDate = (DateTime)startDateProperty.GetValue(validationContext.ObjectInstance, null);
            DateTime endDate = (DateTime)endDateProperty.GetValue(validationContext.ObjectInstance, null);
            
            // Do comparison
            // return ValidationResult.Success; // if success
            if (endDate.Date < startDate.Date)
            {
                return new ValidationResult("Event End Date must be greater or equal to Event Start Date"); // if fail
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}

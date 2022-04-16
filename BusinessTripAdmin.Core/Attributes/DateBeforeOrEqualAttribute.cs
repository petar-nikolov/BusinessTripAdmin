using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Core.Attributes
{
    public class DateBeforeOrEqualAttribute : GeneralValidationAttribute
    {
        public DateBeforeOrEqualAttribute(string dateToCompareToFieldName)
        {
            DateToCompareToFieldName = dateToCompareToFieldName;
        }
        private string DateToCompareToFieldName { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime earlierDate = (DateTime)value;

            DateTime laterDate = (DateTime)validationContext.ObjectType.GetProperty(DateToCompareToFieldName).GetValue(validationContext.ObjectInstance, null);

            if (laterDate < earlierDate)
            {
                return new ValidationResult("Date is not earlier");
            }

            return ValidationResult.Success;
        }
    }
}

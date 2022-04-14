using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Core.ViewModels
{
    public class CreateAllowance
    {
        public decimal DailyAllowance { get; set; }

        public decimal AccomodationAllowance { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime ValidFrom { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime? ValidTo { get; set; }
    }
}

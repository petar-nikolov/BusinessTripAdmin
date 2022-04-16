using BusinessTripAdmin.Core.Attributes;
using BusinessTripAdmin.Infrastructure.Constants;
using BusinessTripAdmin.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdmin.Core.ViewModels
{
    public class CreateBusinessTrip
    {
        public CreateBusinessTrip()
        {
              Employees = new List<string>();
        }

        [Required]
        public string TripFrom { get; set; }

        [Required]
        public string TripTo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd", ApplyFormatInEditMode = true)]
        [DateBeforeOrEqual(nameof(DateTo), ErrorMessage = "DateFrom need to be earlier or equal to DateTo")]
        public DateTime DateFrom { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime DateTo { get; set; }

        public ICollection<string> Employees { get; set; }

        [Required]
        public Transport TripBy { get; set; }

        [StringLength(ValidationConstants.TransportNumberMaxLength)]
        [Required]
        public string TransportNumber { get; set; }

        [Required]
        [StringLength(ValidationConstants.PurposeMaxLength)]
        public string  Purpose { get; set; }
    }
}

using BusinessTripAdmin.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class EmployeeBusinessTrip : BaseEntity
    {
        public EmployeeBusinessTrip()
        {
            TotalDays = (int)(DateTo - DateFrom).TotalDays;
        }

        [Required]
        [StringLength(ValidationConstants.CountryNameMaxLength)]
        public string TripFrom { get; set; }

        [Required]
        [StringLength(ValidationConstants.CountryNameMaxLength)]
        public string TripTo { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime DateFrom { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime DateTo { get; set; }

        public int TotalDays { get; set; }

        [ForeignKey(nameof(Employee))]
        public Guid EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [ForeignKey(nameof(TripDetail))]
        public Guid TripDetailId { get; set; }

        public TripDetail TripDetail { get; set; }

        [Required]
        [StringLength(ValidationConstants.PurposeMaxLength)]
        public string Purpose{ get; set; }
    }
}

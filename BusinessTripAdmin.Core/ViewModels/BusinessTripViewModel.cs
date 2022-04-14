namespace BusinessTripAdmin.Core.ViewModels
{
    public class BusinessTripViewModel
    {
        public string TripFrom { get; set; }

        public string TripTo { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public int TotalDays { get; set; }

        public Guid EmployeeId { get; set; }

        public string Employee { get; set; }

        public ICollection<string> Countries { get; set; }
    }
}

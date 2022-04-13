namespace BusinessTripAdmin.Core.ViewModels
{
    public class AllowanceViewModel
    {
        public string CountryName { get; set; }

        public decimal DailyAllowance { get; set; }

        public decimal AccomodationAllowance { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class Allowance : BaseEntity
    {
        public Allowance()
        {
            Countries = new List<Country>();
        }

        public decimal DailyAllowance { get; set; }

        public decimal AccomodationAllowance { get; set; }

        public DateTime ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        public ICollection<Country> Countries { get; set; }
    }
}

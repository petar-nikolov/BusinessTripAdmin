using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.ParseExact(DateTime.Now.ToString(), FormatingConstant.NormalDateFormat, CultureInfo.InvariantCulture);
        }

        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}

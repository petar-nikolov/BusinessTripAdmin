using BusinessTripAdmin.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace BusinessTripAdmin.Infrastructure.Data.DbModels
{
    public class BaseEntity
    {
        private string dateTimeNow = DateTime.Now.ToString(FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture);
       
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.ParseExact(dateTimeNow, FormatingConstants.FullTimeFormat, CultureInfo.InvariantCulture);
        }

        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}

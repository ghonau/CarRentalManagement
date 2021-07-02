using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Customer:BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastName { get; set; }
        
        [Required]
        [StringLength(15, MinimumLength = 2)]
        public string TaxId { get; set; }
        public string Address { get; set; }
        
        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }
        
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        public virtual List<Booking> Bookings { get; set;  }
    }
}
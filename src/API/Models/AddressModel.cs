using System.ComponentModel.DataAnnotations;

namespace Kaya.src.API.Models
{
    public class AddressModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(200, ErrorMessage = "Street address cannot be longer than 200 characters.")]
        public string StreetAddress { get; set; }


        // TODO: store city all names in a database or a configuration file.
        [Required]
        [StringLength(100, ErrorMessage = "City cannot be longer than 200 characters.")]
        public string City { get; set; }

        // TODO: store city all names in a database or a configuration file.
        [Required]
        [StringLength(100, ErrorMessage = "Province cannot be longer than 100 characters.")]
        public string Province { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Postal code cannot be longer than 10 characters.")]
        public string PostalCode { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;

    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperDuckInterestApi.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonId { get; set; }

        [Required]
        [StringLength(30)]
        public string? FirstName { get; set; } = default;

        [Required]
        [StringLength(30)]
        public string? LastName { get; set; } = default;

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }


        //[NotMapped]
        //[DisplayName("Name")]
        //public string FullName => (FirstName + " " + LastName);

    }
}

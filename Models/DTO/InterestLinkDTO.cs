using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperDuckInterestApi.Models
{
    public class InterestLinkDTO
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InterestLinkId { get; set; }
                
        [Required]
        [StringLength(240)] //longtweet
        public string LinkDescription { get; set; }

        [Required]
        [Url]
        [StringLength(200)]
        public string InterestURL { get; set; } = "https://http.cat/404";



    }
}

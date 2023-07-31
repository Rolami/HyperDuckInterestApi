using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperDuckInterestApi.Models
{
    public class InterestListDTO
    {
        [Key]
        public int InterestListId { get; set; }
        

        [ForeignKey("Persons")]
        public int Fk_PersonId { get; set; }
        public virtual PersonDTO Persons { get; set; }
        
        
        [ForeignKey("Interests")]
        public int Fk_InterestId { get; set; }
        public virtual InterestDTO Interests { get; set; }


        [ForeignKey("InterestLinks")]
        public int Fk_InterestLinkId { get; set; } = 0;
        public virtual InterestLinkDTO InterestLinks { get; set; }
        


    }
}

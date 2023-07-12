using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyperDuckInterestApi.Models
{
    public class InterestList
    {
        [Key]
        public int InterestListId { get; set; }
        

        [ForeignKey("Persons")]
        public int Fk_PersonId { get; set; }
        public virtual Person Persons { get; set; }
        
        
        [ForeignKey("Interests")]
        public int Fk_InterestId { get; set; }
        public virtual Interest Interests { get; set; }


        [ForeignKey("InterestLinks")]
        public int Fk_InterestLinkId { get; set; } = 0;
        public virtual InterestLink InterestLinks { get; set; }
        


    }
}

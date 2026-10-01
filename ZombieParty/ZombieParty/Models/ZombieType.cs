using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZombieParty.Models
{
    public class ZombieType
    {

        [Key]
        public int Id { get; set; }


        
        [DisplayName("Type Name")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "{0} length has to be between {1} and {2}.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} has to be filled.")]
        public string TypeName { get; set; }

        [Range(2,5 , ErrorMessage = "{0} requires a value between {1} and {2}.")]

        public int Point { get; set; }

        public List<Zombie> Zombies { get; set; }

     
    }
}

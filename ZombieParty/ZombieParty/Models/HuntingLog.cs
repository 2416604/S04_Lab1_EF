using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleOrStarship.Data.Entities
{
    public class Starship
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int CrewCount { get; set; }
        public int WinCount { get; set; }
    }
}
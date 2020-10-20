using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleOrStarship.Data.Entities
{
    public class People
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MassCount { get; set; }
        public int WinCount { get; set; }
    }
}
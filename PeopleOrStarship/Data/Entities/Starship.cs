using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleOrStarship.Data.Entities
{
    public class Starship
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public long CostInCredits { get; set; }
        public int Length { get; set; }
        public string MaxAtmospheringSpeed { get; set; }
        public int Crew { get; set; }
        public string Passengers { get; set; }
        public long CargoCapacity { get; set; }
        public string Consumables { get; set; }
        public decimal HyperdriveRating { get; set; }
        public string StarshipClass { get; set; }
        public int WinCount { get; set; }
    }
}
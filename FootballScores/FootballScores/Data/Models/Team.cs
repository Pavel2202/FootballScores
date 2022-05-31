namespace FootballScores.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Team
    {
        public Team()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Fixtures = new List<Fixture>();
            this.Tournaments = new List<Tournament>();
            this.Players = new List<Player>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(TeamNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(TeamManagerMaxLength)]
        public string Manager { get; set; }

        public IEnumerable<Fixture> Fixtures { get; set; }

        public IEnumerable<Tournament> Tournaments { get; set; }

        public IEnumerable<Player> Players { get; set; }
    }
}

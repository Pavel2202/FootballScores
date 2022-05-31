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
            this.Players = new List<Player>();
            this.Tournaments = new List<Tournament>();
            this.Users = new List<User>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(TeamNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(TeamManagerMaxLength)]
        public string Manager { get; set; }

        [Required]
        public string Logo { get; set; }

        public IEnumerable<Fixture> Fixtures { get; set; }

        public IEnumerable<Player> Players { get; set; }

        public IEnumerable<Tournament> Tournaments { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}

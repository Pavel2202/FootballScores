namespace FootballScores.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Tournament
    {
        public Tournament()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Teams = new List<Team>();
            this.Fixtures = new List<Fixture>();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(TournamentNameMaxLength)]
        public string Name { get; set; }

        public IEnumerable<Team> Teams { get; set; }

        public IEnumerable<Fixture> Fixtures { get; set; }
    }
}

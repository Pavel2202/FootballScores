namespace FootballScores.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Fixture
    {
        public Fixture()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        public Team HomeTeam { get; set; }

        [Required]
        public Team AwayTeam { get; set; }

        [Required]
        [MaxLength(FixtureStadiumNameMaxLength)]
        public string Stadium { get; set; }

        [Required]
        public Tournament Tournament { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}

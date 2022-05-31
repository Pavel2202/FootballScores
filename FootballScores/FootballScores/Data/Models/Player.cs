namespace FootballScores.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants;

    public class Player
    {
        public Player()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; }

        [Required]
        [MaxLength(PlayerFullNameMaxLength)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(PlayerNationalityMaxLength)]
        public string Nationality { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public Team Team { get; set; }

        [Required]
        public Tournament Tournament { get; set; }

        [Required]
        public int Goals { get; set; }

        [Required]
        public int Assists { get; set; }

        [Required]
        public int YellowCards { get; set; }

        [Required]
        public int RedCards { get; set; }

        [Required]
        public decimal Rating { get; set; }
    }
}

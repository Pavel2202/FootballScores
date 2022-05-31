namespace FootballScores.Models.Tournament
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants;

    public class AddTournamentViewModel
    {
        [Required]
        [StringLength(TournamentNameMaxLength, MinimumLength = TournamentNameMinLength)]
        public string Name { get; set; }
    }
}

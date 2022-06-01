namespace FootballScores.Models.Team
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants;

    public class AddTeamViewModel
    {
        [Required]
        [StringLength(TeamNameMaxLength, MinimumLength = TeamNameMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(TeamManagerMaxLength, MinimumLength = TeamManagerMinLength)]
        public string Manager { get; set; }

        [Required]
        [Url]
        public string Logo { get; set; }

        [Required]
        public string Tournament { get; set; }
    }
}

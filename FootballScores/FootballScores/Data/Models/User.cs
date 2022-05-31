namespace FootballScores.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        public User()
        {
            this.FavoriteTeams = new List<Team>();
            this.FavoriteTournaments = new List<Tournament>();
        }

        public IEnumerable<Team> FavoriteTeams { get; set; }

        public IEnumerable<Tournament> FavoriteTournaments { get; set; }
    }
}

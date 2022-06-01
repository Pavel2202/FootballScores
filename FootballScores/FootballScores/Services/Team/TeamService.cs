namespace FootballScores.Services.Team
{
    using FootballScores.Data;
    using FootballScores.Models.Team;
    using System.Threading.Tasks;
    using FootballScores.Data.Models;

    public class TeamService : ITeamService
    {
        private readonly FootballScoresDbContext context;

        public TeamService(FootballScoresDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> Add(AddTeamViewModel model)
        {
            if (context.Teams.Count(x => x.Name == model.Name) > 0)
            {
                return false;
            }

            var tournament = context.Tournaments.FirstOrDefault(x => x.Name == model.Tournament);

            if (tournament is null)
            {
                return false;
            }

            var team = new Team()
            {
                Name = model.Name,
                Manager = model.Manager,
                Logo = model.Logo,
                Points = 0,
                Tournament = tournament
            };

            await context.Teams.AddAsync(team);

            tournament.Teams.ToList().Add(team);

            await context.SaveChangesAsync();

            return true;
        }
    }
}

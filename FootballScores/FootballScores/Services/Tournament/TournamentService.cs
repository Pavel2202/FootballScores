namespace FootballScores.Services.Tournament
{
    using FootballScores.Data;
    using FootballScores.Models.Tournament;
    using System.Threading.Tasks;
    using FootballScores.Data.Models;

    public class TournamentService : ITournamentService
    {
        private readonly FootballScoresDbContext context;

        public TournamentService(FootballScoresDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> Add(AddTournamentViewModel model)
        {
            if (context.Tournaments.Count(x => x.Name == model.Name) > 0)
            {
                return false;
            }

            var tournament = new Tournament()
            {
                Name = model.Name
            };

            await context.Tournaments.AddAsync(tournament);

            await context.SaveChangesAsync();

            return true;
        }

        public IEnumerable<Tournament> All()
            => context.Tournaments.ToList();

        public Tournament GetTournament(string id)
            => context.Tournaments.FirstOrDefault(x => x.Id == id);

        public IEnumerable<Team> Teams(string tournamentId)
        {
            var tournament = GetTournament(tournamentId);

            var teams = context.Teams.Where(x => x.Tournament == tournament).ToList();

            return teams;
        }
    }
}

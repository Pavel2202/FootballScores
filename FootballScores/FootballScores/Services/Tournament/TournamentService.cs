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

        public async Task Add(AddTournamentViewModel model)
        {
            var tournament = new Tournament()
            {
                Name = model.Name
            };

            await context.Tournaments.AddAsync(tournament);

            await context.SaveChangesAsync();
        }
    }
}

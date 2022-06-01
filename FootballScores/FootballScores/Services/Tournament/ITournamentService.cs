namespace FootballScores.Services.Tournament
{
    using FootballScores.Models.Tournament;
    using FootballScores.Data.Models;

    public interface ITournamentService
    {
        IEnumerable<Tournament> All();

        Task<bool> Add(AddTournamentViewModel model);

        Tournament GetTournament(string id);

        IEnumerable<Team> Teams(string tournamentId);
    }
}

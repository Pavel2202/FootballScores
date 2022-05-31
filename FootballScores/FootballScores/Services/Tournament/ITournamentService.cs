namespace FootballScores.Services.Tournament
{
    using FootballScores.Models.Tournament;

    public interface ITournamentService
    {
        Task Add(AddTournamentViewModel model);
    }
}

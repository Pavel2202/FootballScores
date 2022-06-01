namespace FootballScores.Services.Team
{
    using FootballScores.Models.Team;

    public interface ITeamService
    {
        Task<bool> Add(AddTeamViewModel model);
    }
}

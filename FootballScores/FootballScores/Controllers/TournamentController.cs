namespace FootballScores.Controllers
{
    using FootballScores.Data;
    using FootballScores.Models.Tournament;
    using FootballScores.Services.Tournament;
    using Microsoft.AspNetCore.Mvc;

    public class TournamentController : Controller
    {
        private readonly ITournamentService service;

        public TournamentController(ITournamentService service)
        {
            this.service = service;
        }

        public IActionResult All()
            => this.View(service.All());

        public IActionResult Table(string id)
        {
            var tournament = service.GetTournament(id);

            var model = new TableViewModel
            {
                Id = tournament.Id,
                Name = tournament.Name,
            };

            var teams = service.Teams(id);

            model.Teams = teams;

            return this.View(model);
        }
    }
}

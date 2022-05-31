namespace FootballScores.Areas.Admin.Controllers
{
    using FootballScores.Models.Tournament;
    using FootballScores.Services.Tournament;
    using Microsoft.AspNetCore.Mvc;

    public class TournamentController : AdminController
    {
        private readonly ITournamentService service;

        public TournamentController(ITournamentService service)
        {
            this.service = service;
        }

        public IActionResult Add()
            => this.View();

        [HttpPost]
        public async Task<IActionResult> Add(AddTournamentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            await service.Add(model);

            return this.RedirectToAction("Index", "Home");
        }
    }
}

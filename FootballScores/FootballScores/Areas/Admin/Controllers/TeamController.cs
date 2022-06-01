namespace FootballScores.Areas.Admin.Controllers
{
    using FootballScores.Models.Team;
    using FootballScores.Services.Team;
    using Microsoft.AspNetCore.Mvc;

    public class TeamController : AdminController
    {
        private readonly ITeamService service;

        public TeamController(ITeamService service)
        {
            this.service = service;
        }

        public IActionResult Add()
            => this.View();

        [HttpPost]
        public async Task<IActionResult> Add(AddTeamViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            if (!await service.Add(model))
            {
                return this.View(model);
            }

            return this.RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}

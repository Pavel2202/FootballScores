namespace FootballScores.Controllers
{
    using FootballScores.Data;
    using Microsoft.AspNetCore.Mvc;

    public class TournamentController : Controller
    {
        private readonly FootballScoresDbContext context;

        public TournamentController(FootballScoresDbContext context)
        {
            this.context = context;
        }

        public IActionResult All()
        {
            var tournaments = context.Tournaments;

            return this.View(tournaments);
        }
    }
}

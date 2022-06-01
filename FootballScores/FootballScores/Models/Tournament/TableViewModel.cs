namespace FootballScores.Models.Tournament
{
    using FootballScores.Data.Models;

    public class TableViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Team> Teams { get; set; }
    }
}

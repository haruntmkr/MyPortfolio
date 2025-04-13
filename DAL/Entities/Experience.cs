using System.Reflection.Metadata.Ecma335;

namespace MyPortfolio.DAL.Entities
{
    public class Experience
    {
        public int experienceId { get; set; }
        public string Head { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}

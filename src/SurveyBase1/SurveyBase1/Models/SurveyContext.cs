using System.Data.Entity;

namespace SurveyBase1.Models
{
    public class SurveyContext : DbContext
    {
        public SurveyContext() : base("SurveyBase1")
        {

        }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Gate> Gates { get; set; }
    }
}

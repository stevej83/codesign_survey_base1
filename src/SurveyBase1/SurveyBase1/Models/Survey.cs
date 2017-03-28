using System;
using System.Data.Entity;

namespace SurveyBase1.Models
{
    public class Survey
    {
        public int SurveyID { get; set; }
        public int OrganizationID { get; set; }
        public DateTime SurveyStartDateTime { get; set; }
    }

    public class SurveyDBContext : DbContext
    {
        public DbSet<Survey> Surveys { get; set; }
    }
}
using System;
using System.Data.Entity;

namespace SurveyBase1.Models
{
    public class Survey
    {
        public string SurveyId { get; set; }
        public string ClientId { get; set; }
        public string UserId { get; set; }
        public DateTime SurveyStart { get; set; }
        public DateTime SurveyEnd { get; set; }
        public DateTime SurveyLastUpdate { get; set; }
        public string Q1Ans { get; set; }
        public double Q1Pt { get; set; }
        public string Q2Ans { get; set; }
        public double Q2Pt { get; set; }
        public string Q3Ans { get; set; }
        public double Q3Pt { get; set; }
        public string Q4Ans { get; set; }
        public double Q4Pt { get; set; }
        public string Q5Ans { get; set; }
        public double Q5Pt { get; set; }
        public string Q6Ans { get; set; }
        public double Q6Pt { get; set; }
    }

    // SurveyDBContext handles the task of connecting to the database and mapping Survey objects to database records.
    // Entity Framework will default to using LocalDB.
    // LocalDB database files are kept in the App_Data folder of a web project.
    // SQL Server Express is not recommended for use in production web applications.
    // LocalDB in particular should not be used for production with a web application because it is not designed to work with IIS.
    // However, a LocalDB database can be easily migrated to SQL Server or SQL Azure.
    public class SurveyDBContext : DbContext
    {
        public DbSet<Survey> Surveys { get; set; }
    }
}
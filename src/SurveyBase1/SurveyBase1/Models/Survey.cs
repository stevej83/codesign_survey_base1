using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SurveyBase1.Models
{
    public class Survey
    {
        [ScaffoldColumn(false)]
        public int SurveyID { get; set; }

        [ScaffoldColumn(false)]
        public int ClientID { get; set; }

        [ScaffoldColumn(false)]
        public int UserID { get; set; }

        [ScaffoldColumn(false)]
        public DateTime SurveyStart { get; set; }

        [ScaffoldColumn(false)]
        public DateTime SurveyEnd { get; set; }

        [ScaffoldColumn(false)]
        public DateTime SurveyLastUpdate { get; set; }

        [Required, StringLength(255), Display(Name = "Q1 Answer")]
        public string Q1Ans { get; set; }

        [Display(Name = "Q1 Point")]
        public double? Q1Pt { get; set; }

        [Required, StringLength(255), Display(Name = "Q2 Answer")]
        public string Q2Ans { get; set; }

        [Display(Name = "Q2 Point")]
        public double? Q2Pt { get; set; }
    }
}
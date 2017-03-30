using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SurveyBase1.Models
{
    public class Gate
    {
        [ScaffoldColumn(false)]
        public string QuestionGateID { get; set; }

        [ScaffoldColumn(false)]
        public string SurveyID { get; set; }

        [ScaffoldColumn(false)]
        public bool LandingGate1 { get; set; }

        [ScaffoldColumn(false)]
        public bool LandingGate2 { get; set; }

        [ScaffoldColumn(false)]
        public bool Section1Gate1 { get; set; }

        [ScaffoldColumn(false)]
        public bool Section1Gate2 { get; set; }
    }
}
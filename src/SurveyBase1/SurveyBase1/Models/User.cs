using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SurveyBase1.Models
{
    public class User
    {
        [ScaffoldColumn(false)]
        public string UserID { get; set; }

        [Required, StringLength(100), Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required, StringLength(100), Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required, StringLength(255), Display(Name = "Email")]
        public string Email { get; set; }

        [Required, StringLength(100), Display(Name = "Wechat")]
        public string Wechat { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DOB { get; set; }

        [ScaffoldColumn(false)]
        public bool IsBachelor { get; set; }

        [Required, StringLength(255), Display(Name = "Bachelor University")]
        public string BachelorUniversity { get; set; }

        [Required, StringLength(255), Display(Name = "Bachelor Degree Detail")]
        public string BachelorDegreeDetail { get; set; }
    }
}
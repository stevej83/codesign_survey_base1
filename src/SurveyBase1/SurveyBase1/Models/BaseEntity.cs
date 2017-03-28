using System;
using System.ComponentModel.DataAnnotations;

namespace SurveyBase1.Models
{
    abstract public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime ChangedOn { get; set; }

        public string ChangedBy { get; set; }
    }
}
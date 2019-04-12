using System;
using System.ComponentModel.DataAnnotations;
namespace RazorPagesCourse.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Number { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Start Date"), DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Semester { get; set; }
        public string Description { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]

        public decimal Credits { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace TaizlostSmart.Models
{
    public class Reports
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; } 
        public string Title { get; set; }


        public string Category { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime Date { get; set; }

        public string Phone { get; set; }

        public string ImagePath { get; set; }

        public int UserId { get; set; }
    }
}

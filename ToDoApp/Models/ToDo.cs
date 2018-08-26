using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }


        [Required]
        public DateTime? DueDate { get; set; }

        [Required]
        public bool IsComplete { get; set; }

        public ApplicationUser User { get; set; }
    }
}
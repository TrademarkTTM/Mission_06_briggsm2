using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_06_briggsm2.Models
{
    public class AddMovieResponce
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int Year { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent_To { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }        
        
        [Required(ErrorMessage = "This field is required")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

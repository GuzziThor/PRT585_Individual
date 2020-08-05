using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTheatre._00Data
{
    public class Movie
    { 
        public int MovieID { get; set; }
        [StringLength(50)]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Contact_Email { get; set; }
        [Required]

        public Language LanguageType { get; set; }
        [Required]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }

    public enum Language
    {
        English,
        Chinese,
        Japanese
    }
    public class Category
    {
        public int CategoryID { get; set; }
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public virtual ICollection<Movie> Movies {get;set;}
    }
}

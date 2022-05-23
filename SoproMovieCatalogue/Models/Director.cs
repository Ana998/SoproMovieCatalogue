using System.ComponentModel.DataAnnotations;

namespace SoproMovieCatalogue.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}

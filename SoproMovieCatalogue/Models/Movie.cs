using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoproMovieCatalogue.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 characters")]
        public string Name { get; set; }


        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        public List<Genre_Movie> Genres_Movies { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

        //Director
        public int DirectorId { get; set; }
        [ForeignKey("DirectorId")]
        public Director Director { get; set; }
    }
}

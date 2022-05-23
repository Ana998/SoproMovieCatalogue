using System.ComponentModel.DataAnnotations;

namespace SoproMovieCatalogue.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        //Relationships
        public List<Genre_Movie> Genres_Movies { get; set; }

    }
}

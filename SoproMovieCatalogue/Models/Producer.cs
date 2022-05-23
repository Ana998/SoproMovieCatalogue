
using System.ComponentModel.DataAnnotations;

namespace SoproMovieCatalogue.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }
        public Producer() { }
        public Producer(string Name)
        {
            Name = Name;
        }
        //Relationships

        public List<Movie> Movies { get; set; }
    }
}

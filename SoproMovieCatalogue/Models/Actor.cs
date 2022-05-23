
using System.ComponentModel.DataAnnotations;

namespace SoproMovieCatalogue.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }

        public Actor() { }
        public Actor(string name)        {

            Name = name;

        }



        //Relatioships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}

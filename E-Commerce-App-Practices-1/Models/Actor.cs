using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_App_Practices_1.Models
{
    public class Actor
    {
       
	    [Key]
        public int Id { get; set; }

        [Display (Name = "Profile Picture URI")]
        public string ProfilePictureURL { get; set; }

        [Display (Name = "Full Name")]
        public string FullName { get; set; }

        [Display (Name = "Bio")]
        public string Bio { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}

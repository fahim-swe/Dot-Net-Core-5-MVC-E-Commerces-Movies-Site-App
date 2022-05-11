using E_Commerce_App_Practices_1.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_App_Practices_1.Models
{
    public class Actor: IEntityBase
    {
       
	    [Key]
        public int Id { get; set; }

        [Display (Name = "Profile Picture URI")]
        [Required(ErrorMessage = "Profile Picture is required")]
        

        public string ProfilePictureURL { get; set; }

        [Display (Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name mush be between 3 and 50 chars")]
        public string FullName { get; set; }

        [Display (Name = "Bio")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}

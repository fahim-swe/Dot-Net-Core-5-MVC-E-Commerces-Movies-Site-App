using E_Commerce_App_Practices_1.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_App_Practices_1.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
      
        [Display(Name = "Cinema Logo")]
        [Required (ErrorMessage = "Cinema Logo is required")]
        
        public string Logo { get; set; }

        [Display (Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema Name is required")]
        public string Name { get; set; }
        
        [Display (Name = "Cinema Description")]
        [Required(ErrorMessage = "Cinema Description is required")]
        public string Description { get; set; }

      
        // Relationships
        public List<Movie> Movies { get; set; }

    }
}

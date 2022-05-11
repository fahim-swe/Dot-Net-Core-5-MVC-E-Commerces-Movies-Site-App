using E_Commerce_App_Practices_1.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_App_Practices_1.Models
{
    public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        // Relationships
        public List<Movie> Movies { get; set; }
    }
}

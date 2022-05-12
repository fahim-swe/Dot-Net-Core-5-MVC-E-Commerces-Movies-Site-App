using E_Commerce_App_Practices_1.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce_App_Practices_1.Data.ViewModels
{
    public class NewMovieVM
    {

        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie start Date")]
        [Required(ErrorMessage = "Movie start date required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie end Date")]
        [Required(ErrorMessage = "Movie end date required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is required")]
        public MovieCategory MovieCategory { get; set; }

        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is required")]
        public List<int> ActorIds { get; set; }
        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Movie cinema required")]
        public int CinemaId { get; set; }


        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Movie producer required")]
        public int ProducerId { get; set; }
        
     
    }
}

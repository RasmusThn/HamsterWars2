using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Hamster
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Hamster name is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Name is 20 characters.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Age is a required field.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Favourite Food is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for Food is 20 characters.")]
        public string? FavFood { get; set; }
        [Required(ErrorMessage = "Loves is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for Loves is 20 characters.")]
        public string? Loves { get; set; }
        public string? ImgName { get; set; }
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0;
        public int Games { get; set; } = 0;
        public bool isActive { get; set; } = true;

    }
}

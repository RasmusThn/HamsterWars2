using System.ComponentModel.DataAnnotations;


namespace Shared.DataTransferObjects
{
    public record HamsterForCreationDto
    {
        [Required(ErrorMessage = "Name is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for Name is 20 characters.")]
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
    }
}

using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Models
{
    public class MoviePlayList
    {
        public int PlayListId { get; set; }
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Movie name is required.")]
        [StringLength(200, ErrorMessage = "Movie name cannot be longer than 200 characters.")]
        public string MovieName { get; set; }
    }
}

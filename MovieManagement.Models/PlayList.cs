﻿using System.ComponentModel.DataAnnotations;

namespace MovieManagement.Models
{
    public class PlayList
    {
        public int PlayListId { get; set; }
        public int UserId { get; set; }

        [Required(ErrorMessage = "Playlist name is required.")]
        [StringLength(200, ErrorMessage = "Playlist name cannot be longer than 200 characters.")]
        public string PlayListName { get; set; }
    }
}

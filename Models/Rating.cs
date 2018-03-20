using System;
using System.ComponentModel.DataAnnotations;

namespace NilamHutAPI.Models
{
    public class Rating
    {
        public Guid Id { get; set; }

        [Required]
        public int UserRating { get; set; }

        [StringLength(500)]
        public String UserComment { get; set; }

        [Required]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
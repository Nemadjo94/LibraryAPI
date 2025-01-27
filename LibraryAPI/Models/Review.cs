﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This means that the Id will be generated by a database
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Headline must be between 2 and 200 characters")]
        public string Headline { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 20, ErrorMessage = "Review text must be between 20 and 2000 characters")]
        public string ReviewText { get; set; }

        [Required]
        [Range(1,5, ErrorMessage = "Rating must be between 1 and 5 stars")] // Stars
        public int Rating { get; set; }

        public virtual Reviewer Reviewer { get; set; }
        public virtual Book Book { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This means that the Id will be generated by a database
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "First Name cannot be longer than 100 characters")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Last Name cannot be longer than 100 characters")]
        public string LastName { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
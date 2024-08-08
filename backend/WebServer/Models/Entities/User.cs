﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace LangLearner.Models.Entities
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Username must be at least 4 chracters long.")]
        [MaxLength(20)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        public string NativeLanguageName { get; set; } = string.Empty;

        [Required]
        public string AppLanguageName { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email address format.")]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string HashedPassword { get; set; } = string.Empty;

        public virtual Language? NativeLanguage { get; set; }
        public virtual Language? AppLanguage { get; set; }

        public IEnumerable<Course>? EnrolledCourses { get; set; } = null;

        public IEnumerable<Course>? CreatedCourses { get; set; } = null;


    }
}

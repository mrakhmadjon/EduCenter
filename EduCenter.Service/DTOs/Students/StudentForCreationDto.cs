﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EduCenter.Service.DTOs.Students
{
    public class StudentForCreationDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public Guid GroupId { get; set; }
    }
}

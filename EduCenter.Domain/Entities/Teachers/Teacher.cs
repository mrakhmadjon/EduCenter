using EduCenter.Domain.Commons;
using EduCenter.Domain.Entities.Courses;
using EduCenter.Domain.Enums;
using System;
using System.Collections.Generic;

namespace EduCenter.Domain.Entities.Teachers
{
    internal class Teacher : IAuditable
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ItemState State { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}

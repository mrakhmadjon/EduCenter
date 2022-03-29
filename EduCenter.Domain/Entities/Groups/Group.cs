using EduCenter.Domain.Commons;
using EduCenter.Domain.Entities.Courses;
using EduCenter.Domain.Entities.Students;
using EduCenter.Domain.Entities.Teachers;
using EduCenter.Domain.Enums;
using EduCenter.Domain.Localizations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EduCenter.Domain.Entities.Groups
{
    internal class Group : IAuditable , ILocalizationNames
    {
        public Guid Id { get; set; }
        [JsonIgnore]
        public string NameUz { get; set; }
        [JsonIgnore]

        public string NameEn { get; set; }
        [JsonIgnore]

        public string NameRu { get; set; }
        [NotMapped]
        public string Name { get; set; }

        public Guid TeacherId { get; set; }

        [ForeignKey(nameof(TeacherId))]

        public Teacher Teacher { get; set; }

        public Guid CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ItemState State { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}

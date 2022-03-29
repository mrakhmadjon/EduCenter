using EduCenter.Domain.Commons;
using EduCenter.Domain.Enums;
using EduCenter.Domain.Localizations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EduCenter.Domain.Entities.Courses
{
    public class Course : IAuditable, ILocalizationNames
    {
        public Guid Id { get ; set; }
        [JsonIgnore]
        public string NameUz { get; set; }
        [JsonIgnore]

        public string NameEn { get; set; }
        [JsonIgnore]

        public string NameRu { get; set; }
        [NotMapped]
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ushort Duration { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ItemState State { get; set; }

    }
}

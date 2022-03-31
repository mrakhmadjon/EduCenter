using EduCenter.Domain.Entities.Courses;
using EduCenter.Domain.Entities.Groups;
using EduCenter.Domain.Entities.Students;
using EduCenter.Domain.Entities.Teachers;
using Microsoft.EntityFrameworkCore;

namespace EduCenter.Data.Contexts
{
    public class EduCenterDbContext : DbContext
    {
        public EduCenterDbContext(DbContextOptions<EduCenterDbContext> options) : base(options)
        {

        }


        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
    }
}

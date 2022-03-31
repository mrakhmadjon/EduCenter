using EduCenter.Data.Contexts;
using EduCenter.Data.IRepositories;
using EduCenter.Domain.Entities.Students;

namespace EduCenter.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(EduCenterDbContext eduCenterDbContext) : base(eduCenterDbContext)
        {
        }

    }
}

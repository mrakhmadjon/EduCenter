using EduCenter.Data.Contexts;
using EduCenter.Data.IRepositories;
using EduCenter.Domain.Entities.Students;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(EduCenterDbContext eduCenterDbContext) : base(eduCenterDbContext)
        {
        }

    }
}

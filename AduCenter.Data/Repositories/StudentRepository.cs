using AduCenter.Data.Contexts;
using AduCenter.Data.IRepositories;
using EduCenter.Domain.Entities.Students;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AduCenter.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(EduCenterDbContext eduCenterDbContext, ILogger logger) : base(eduCenterDbContext, logger)
        {
        }

    }
}

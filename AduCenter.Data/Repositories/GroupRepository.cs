using EduCenter.Data.Contexts;
using EduCenter.Data.IRepositories;
using EduCenter.Domain.Entities.Groups;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.Data.Repositories
{
    public class GroupRepository : GenericRepository<Group>, IGroupRepository
    {
        public GroupRepository(EduCenterDbContext eduCenterDbContext) : base(eduCenterDbContext)
        {
        }
    }
}

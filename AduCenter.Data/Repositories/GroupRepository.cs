using AduCenter.Data.Contexts;
using AduCenter.Data.IRepositories;
using EduCenter.Domain.Entities.Groups;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AduCenter.Data.Repositories
{
    public class GroupRepository : GenericRepository<Group>, IGroupRepository
    {
        public GroupRepository(EduCenterDbContext eduCenterDbContext, ILogger logger) : base(eduCenterDbContext, logger)
        {
        }
    }
}

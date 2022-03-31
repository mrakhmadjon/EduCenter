using EduCenter.Data.Contexts;
using EduCenter.Data.IRepositories;
using EduCenter.Domain.Entities.Groups;

namespace EduCenter.Data.Repositories
{
    public class GroupRepository : GenericRepository<Group>, IGroupRepository
    {
        public GroupRepository(EduCenterDbContext eduCenterDbContext) : base(eduCenterDbContext)
        {
        }
    }
}

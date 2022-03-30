using EduCenter.Data.Contexts;
using EduCenter.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EduCenterDbContext context;

        public UnitOfWork(EduCenterDbContext context)
        {
            this.context = context;
        }

        public IStudentRepository Students {get; private set;}

        public IGroupRepository Groups { get; private set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task SaveChangesAsync()
        {
            context.SavingChanges();
        }
    }
}

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

            //Object initializing for repositories
            Students = new StudentRepository(context);
            Groups = new GroupRepository(context);
        }

        public IStudentRepository Students {get; private set;}

        public IGroupRepository Groups { get; private set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
           await context.SaveChangesAsync();
        }
    }
}

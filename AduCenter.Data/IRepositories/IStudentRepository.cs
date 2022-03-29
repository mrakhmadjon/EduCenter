﻿using EduCenter.Domain.Entities.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCenter.Data.IRepositories
{
    public interface IStudentRepository : IGenericRepository<Student> 
    {
    }
}

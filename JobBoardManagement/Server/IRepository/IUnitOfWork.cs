using JobBoardManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoardManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Category> Categorys { get; }
        IGenericRepository<Application> Applications { get; }
        IGenericRepository<Employer> Employers { get; }
        IGenericRepository<JLocation> JLocations { get; }
        IGenericRepository<JobDetail> Jobs { get; }
        IGenericRepository<JobType> JobTypes { get; }
        IGenericRepository<Resume> Resumes { get; }
        IGenericRepository<Salary> Salarys { get; }
        IGenericRepository<User> users { get; }

    }
}
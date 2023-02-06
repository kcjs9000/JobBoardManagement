using JobBoardManagement.Server.Data;
using JobBoardManagement.Server.IRepository;
using JobBoardManagement.Server.Models;
using JobBoardManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JobBoardManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Application> _applications;
        private IGenericRepository<Category> _categorys;
        private IGenericRepository<Employer> _employers;
        private IGenericRepository<JLocation> _locations;
        private IGenericRepository<JobDetail> _jobdetails;
        private IGenericRepository<JobType> _jobtypes;
        private IGenericRepository<Resume> _resumes;
        private IGenericRepository<Salary> _salarys;
        private IGenericRepository<User> _users;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Application> Applications
            => _applications ??= new GenericRepository<Application>(_context);
        public IGenericRepository<Category> Categorys
            => _categorys ??= new GenericRepository<Category>(_context);
        public IGenericRepository<Employer> Employers
            => _employers ??= new GenericRepository<Employer>(_context);
        public IGenericRepository<JLocation> JLocations
            => _locations ??= new GenericRepository<JLocation>(_context);
        public IGenericRepository<JobDetail> Jobs
            => _jobdetails ??= new GenericRepository<JobDetail>(_context);
        public IGenericRepository<JobType> JobTypes
            => _jobtypes ??= new GenericRepository<JobType>(_context);
        public IGenericRepository<Resume> Resumes
           => _resumes ??= new GenericRepository<Resume>(_context);
        public IGenericRepository<Salary> Salarys
           => _salarys ??= new GenericRepository<Salary>(_context);
        public IGenericRepository<User> users
           => _users ??= new GenericRepository<User>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdate = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdateBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class WorkExperienceRepository : BaseRepository<WorkExperience> , IWorkExperienceRepository
    {
        private readonly ApplicationContext _context;
        public WorkExperienceRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
        public WorkExperience? Get(string title)
        {
            return _context.WorkExperiences.Include(u => u.User).FirstOrDefault(u => u.Title == title);
        }
    }
}

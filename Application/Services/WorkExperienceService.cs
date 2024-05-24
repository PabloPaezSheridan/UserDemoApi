using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class WorkExperienceService
    {
        private readonly IWorkExperienceRepository _repository;
        public WorkExperienceService(IWorkExperienceRepository repo)
        {
            _repository = repo;
        }

        public WorkExperience Get(string title)
        {
            return _repository.Get(title);
        }

        public WorkExperience Get(int id)
        {
            return _repository.Get(id);
        }

        public List<WorkExperience> Get()
        {
            return _repository.Get();
        }
    }
}

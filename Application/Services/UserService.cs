using Application.Dtos;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public User Get(string name)
        {
            return _repository.Get(name); 
        }

        public List<User> Get()
        {
            return _repository.Get();
        }

        public int AddUser(UserForAddRequest request)
        {
            var user = new User()
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password
            };
            return _repository.AddUser(user);
        }
    }
}

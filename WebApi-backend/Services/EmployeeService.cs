using Microsoft.AspNetCore.Mvc;
using WebApi_backend.Model;
using WebApi_backend.Repository;

namespace WebApi_backend.Services
{
    public class EmployeeService:IService
    {
        private readonly IRepository _repository;
        public EmployeeService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<EmplyeeDetails>> GetDetails()
        {
            return await _repository.GetDetails();
        }

        public async Task<EmplyeeDetails?> GetDetailsById(int id)
        {
            return await _repository.GetDetailsById(id);
        }

        
    }
}

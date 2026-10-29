using Microsoft.AspNetCore.Mvc;
using WebApi_backend.Services;
using WebApi_backend.Data;
using WebApi_backend.Model;
using Microsoft.EntityFrameworkCore;

namespace WebApi_backend.Repository
{
    public class EmployeeRepository : IRepository
    {
        private readonly AppDbContext _dbcontext; 
        public EmployeeRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<EmplyeeDetails>> GetDetails()
        {
            return await _dbcontext.EmpDetails.ToListAsync();
        }

        public async Task<EmplyeeDetails?> GetDetailsById(int id)
        {
            return await _dbcontext.EmpDetails.FirstOrDefaultAsync(x=>x.EmpID==id);
        }

        
    }
}

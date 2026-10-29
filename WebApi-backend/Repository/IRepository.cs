using Microsoft.AspNetCore.Mvc;
using WebApi_backend.Model;

namespace WebApi_backend.Repository
{
    public interface IRepository
    {
        Task<List<EmplyeeDetails>> GetDetails();
        Task<EmplyeeDetails?> GetDetailsById(int id);
    }
}

using Microsoft.AspNetCore.Mvc;
using WebApi_backend.Model;

namespace WebApi_backend.Services
{
    public interface IService
    {
        Task<List<EmplyeeDetails>> GetDetails();
        Task<EmplyeeDetails?> GetDetailsById(int id);
    }
}

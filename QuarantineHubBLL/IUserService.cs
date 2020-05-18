using Quarantine.Entities;
using MVC.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserViewModel>> GetAllAsync();
        Task<UserViewModel> GetByEmailAsync(string email);
        Task<UserViewModel> GetByIdAsync(string id);
        Task<bool> IsUserExistsAsync(string email);
        Task<bool> CheckPasswordByEmailAsync(string email, string password);
        void InsertUserAsync(UserViewModel userModel);
        void Follow(string requesterEmail, string userEmail);
        void RemoveFriend(string requesterEmail, string userEmail);
        Task<PortfolioViewModel> GetProfileModel(UserViewModel model);
        Task<PortfolioViewModel> UpdateUserAsync(PortfolioViewModel userModel);
    }
}

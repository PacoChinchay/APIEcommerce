using APIEcommerce.Models;
using APIEcommerce.Models.Dtos;

namespace APIEcommerce.Repository.IRepository
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User? Getuser(int userId);
        bool IsUniqueUser(string name);
        Task<UserLoginResponseDto> Login(UserLoginDto userLoginDto);
        Task<User> Register(CreateUserDto createUserDto);
    }
}

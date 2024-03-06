using oshhona.Areas.Admin.Data.Entities;
using oshhona.BusinesLogic.DTOs.UsesrDTOs;

namespace oshhona.BusinesLogic.Interfaces;

public interface IAuthService
{
    Task<AuthResult> LoginAsync(LoginDto loginDto, Role kim);
    AuthResult CreateUser(RegisterDto registerDto);
    bool IsLoggedIn();
    void Logout(Role kim);
    string GetFullName(Role kim);
    string GetPhoneNumber(Role kim);
}
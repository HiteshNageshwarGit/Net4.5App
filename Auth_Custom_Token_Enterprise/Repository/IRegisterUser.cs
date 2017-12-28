using Auth_Custom_Token_Enterprise.Models;

namespace Auth_Custom_Token_Enterprise.Repository
{
    public interface IRegisterUser
    {
        void Add(RegisterUser registeruser);
        bool ValidateRegisteredUser(RegisterUser registeruser);
        bool ValidateUsername(RegisterUser registeruser);
        int GetLoggedUserID(RegisterUser registeruser);
    }
}

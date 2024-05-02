using Microsoft.AspNetCore.Identity;

namespace LicentaTest.Data.Entities
{
    public class AddMyUser : IdentityUser
    {
        public AddMyUser(string nume, string email, string parola)
        {
            this.UserName = nume;
            this.Email = email;
            this.PasswordHash = parola;
            
        }
        
    }
}

using Microsoft.AspNetCore.Identity;

namespace LicentaTest.Data.Entities
{
    public class AddUserIdentity : IdentityUser
    {
        public AddUserIdentity()
        {
        }
        public AddUserIdentity(string userName, string email)
        {
            this.UserName = userName;
            this.Email = email;
        }
    }

}

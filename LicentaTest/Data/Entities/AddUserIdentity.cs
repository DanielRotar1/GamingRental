using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace LicentaTest.Data.Entities
{
    public class AddUserIdentity : IdentityUser
    {
        public AddUserIdentity(string userName, string email)
        {
            this.UserName = userName;
            this.Email = email;
        }
    }

}

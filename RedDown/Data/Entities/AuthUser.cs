using Microsoft.AspNetCore.Identity;

namespace RedDown.Data.Entities
{
    public class AuthUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
    }

    public class Role : IdentityRole<int> { }
    public class UserRole : IdentityUserRole<int> { }
    public class UserClaim : IdentityUserClaim<int> { }
    public class UserLogin : IdentityUserLogin<int> { }
    public class RoleClaim : IdentityRoleClaim<int> { }
    public class UserToken : IdentityUserToken<int> { }
}

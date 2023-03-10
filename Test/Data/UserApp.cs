using Microsoft.AspNetCore.Identity;

namespace Test.Data
{
    public class UserApp : IdentityUser
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public UserApp()
        {
            Bills = new List<Bill>();
        }
    }
}

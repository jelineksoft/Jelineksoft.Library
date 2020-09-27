using Jelineksoft.Library.Entities.Interfaces;

namespace Jelineksoft.Library.Entities.Users
{
    public class User: EntityBase, IUser
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
    }
}
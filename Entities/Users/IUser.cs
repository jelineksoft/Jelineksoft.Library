using System.Collections.ObjectModel;

namespace Jelineksoft.Library.Entities.Users
{
    public interface IUser
    {
        string UserName { get; set; }
        string PasswordHash { get; set; }

    }
}
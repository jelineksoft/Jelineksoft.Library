using Jelineksoft.Library.Entities.Interfaces;

namespace Jelineksoft.Library.Entities.Users
{
    public class Role: EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
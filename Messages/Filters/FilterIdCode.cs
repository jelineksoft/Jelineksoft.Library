using System;

namespace Jelineksoft.Library.Messages.Filters
{

    public interface IFilterIdCode
    {
         string Code { get; set; }
    }

    public class FilterIdCode: FilterId, IFilterIdCode
    {
        public FilterIdCode()
        {}

        public FilterIdCode(ulong id, string code)
        {
            Id = id;
            Code = code;
        }
        public FilterIdCode(ulong id, string code, bool? active)
        {
            Id = id;
            Code = code;
            Active = active;
        }

        public string Code { get; set; }
    }
}
using System;

namespace Jelineksoft.Library.Messages.Filters
{

    public interface IFilterId
    {
        UInt64 Id { get; set; }
        Boolean? Active { get; set; }
    }
    public class FilterId: IFilterId
    {
        public FilterId()
        {}

        public FilterId(ulong id)
        {
            Id = id;
        }
        public FilterId(ulong id, bool? active)
        {
            Id = id;
            Active = active;
        }

        public UInt64 Id { get; set; }
        public bool? Active { get; set; } = null;
    }
}
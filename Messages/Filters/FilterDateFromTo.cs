using System;
using System.Collections.Generic;
using System.Text;

namespace Jelineksoft.Library.Messages.Filters
{
    public interface IFilterDateFromTo
    {
        DateTime? DateFrom { get; set; }
        DateTime? DateTo { get; set; }
    }
    public class FilterDateFromTo: IFilterDateFromTo
    {
        public FilterDateFromTo()
        { }

        public FilterDateFromTo(DateTime dateFrom)
        {
            DateFrom = dateFrom;
        }
        public FilterDateFromTo(DateTime dateFrom, DateTime dateTo)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
        }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}

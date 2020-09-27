using System;

namespace Jelineksoft.Library.Messages
{
    public abstract class MessageBase
    {
        public MessageBase(MessageHeader messageHeader)
        {
            this.MessageHeader = messageHeader;
            this.Date = DateTime.Now;
        }

        public MessageHeader MessageHeader { get; set; }
        public DateTime Date { get; set; }

        public int ErrorNumber { get; set; }
        public string ErrorDescription { get; set; }

        public bool HasError()
        {
            if (ErrorNumber != 0)
                return true;
            return false;
        }

}
}
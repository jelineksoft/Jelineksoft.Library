using System;

namespace Jelineksoft.Library.Messages
{
    public class MessageHeader
    {
        public MessageHeader()
        {
            
        }
        public MessageHeader(string userToken, ulong stationId)
        {
            this.UserToken = userToken;
            this.StationId = stationId.ToString();
        }
        public MessageHeader(string userToken, string stationId)
        {
            this.UserToken = userToken;
            this.StationId = stationId;
        }

        public string UserToken { get; set; }
        public string StationId { get; set; }
    
}
}
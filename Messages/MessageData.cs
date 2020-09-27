using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Jelineksoft.Library.Messages
{
    public class MessageData: MessageBase
    {

        public MessageData()
            : base(new MessageHeader())
        {
            
        }
        public MessageData(MessageHeader msgHeader)
            : base(msgHeader)
        {
            this.Data = null;
        }

        public MessageData(MessageHeader msgHeader, object data)
            : base(msgHeader)
        {
            SetDataJSON(data);
        }

        public string Data { get; set; }
        public string DataFilter { get; set; }

        public void SetDataJSON(object data)
        {
            if (data == null) this.Data = null;
            
            var set = new JsonSerializerSettings();
            set.TypeNameHandling = TypeNameHandling.Objects;
            set.MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead;

            this.Data = JsonConvert.SerializeObject(data, set);
        }
        public void SetDataFilterJSON(object data)
        {
            if (data == null) this.DataFilter = null;
            
            var set = new JsonSerializerSettings();
            set.TypeNameHandling = TypeNameHandling.Objects;
            set.MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead;

            this.DataFilter = JsonConvert.SerializeObject(data, set);
        }

        public T GetDataJSON<T>() where T : class
        {
            if (this.Data == null) return null;
            var set = new JsonSerializerSettings();
            set.TypeNameHandling = TypeNameHandling.All;
            set.MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead;

            var x = JsonConvert.DeserializeObject<T>(this.Data, set);
            return x;
        }
        public T GetDataFilterJSON<T>() where T : class
        {
            if (this.DataFilter == null) return null;
            var set = new JsonSerializerSettings();
            set.TypeNameHandling = TypeNameHandling.All;
            set.MetadataPropertyHandling = MetadataPropertyHandling.ReadAhead;

            var x = JsonConvert.DeserializeObject<T>(this.DataFilter, set);
            return x;
        }

    }
}
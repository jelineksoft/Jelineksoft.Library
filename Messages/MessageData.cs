using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Jelineksoft.Library.Messages
{
    public class MessageData: MessageBase
    {

        public MessageData()
            : base(null)
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
        public MessageData(object data)
            : base(null)
        {
            SetDataJSON(data);
        }

        public string Data { get; set; }
        public string DataFilter { get; set; }

        public void SetDataJSON(object data)
        {
            if (data == null) {this.Data = null;
                return;
            }
            
            this.Data = JsonConvert.SerializeObject(data, GetSettings());
        }
        public void SetDataFilterJSON(object data)
        {
            if (data == null) {this.DataFilter = null;
                return;
            }
            
            this.DataFilter = JsonConvert.SerializeObject(data, GetSettings());
        }

        public T GetDataJSON<T>() where T : class
        {
            if (this.Data == null) return null;
            
            var x = JsonConvert.DeserializeObject<T>(this.Data, GetSettings());
            return x;
        }
        
        public T GetFromJSONString<T>(string data) where T : class
        {
            if (data == null) return null;
            
            var x = JsonConvert.DeserializeObject<T>(data, GetSettings());
            return x;
        }

        public T GetDataFilterJSON<T>() where T : class
        {
            if (this.DataFilter == null) return null;
            

            var x = JsonConvert.DeserializeObject<T>(this.DataFilter, GetSettings());
            return x;
        }

        private JsonSerializerSettings GetSettings()
        {
            var set = new JsonSerializerSettings();
            set.TypeNameHandling = TypeNameHandling.Auto;
            set.MetadataPropertyHandling = MetadataPropertyHandling.Default;
            set.MissingMemberHandling = MissingMemberHandling.Ignore;
            set.NullValueHandling = NullValueHandling.Include;
            return set;
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GavialServer
{
    [DataContract]
    public class MessageDto
    {
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public int ID { get; set; }
    }
}

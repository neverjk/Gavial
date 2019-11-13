using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GavialServer
{
    [DataContract]
    public class ProfileDto
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public int Money { get; set; }
        [DataMember]
        public int Rate { get; set; }
        [DataMember]
        public int BadWords { get; set; }
        [DataMember]
        public Bitmap Picture { get; set; }
    }
}

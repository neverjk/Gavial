using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GavialServer.Database.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public int Money { get; set; }
        public int Rate { get; set; }
        public int BadWords { get; set; }
        public Bitmap Picture { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GavialServer.Database.Entities
{
    [Table("users")]
    public class GavialUser
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public int Money { get; set; }
        public int Rate { get; set; }
        public int BadWords { get; set; }
        public string Picture { get; set; }
    }
}
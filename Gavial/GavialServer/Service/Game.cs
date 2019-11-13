using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GavialServer
{
    public class Game
    {
        public List<ICallBack> clients = new List<ICallBack>();
        public List<MessageDto> chat = new List<MessageDto>();
        public List<User> users = new List<User>();
        public Bitmap drawing;
    }
}

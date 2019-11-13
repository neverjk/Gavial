using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GavialServer
{
    [ServiceContract(CallbackContract = typeof(ICallBack))]
    public interface IPlay
    {
        [OperationContract(IsOneWay = true)]
        void JoinGame(string name, int gameId = -1);

        [OperationContract(IsOneWay = true)]
        void SendMessage(MessageDto message);

        [OperationContract(IsOneWay = true)]
        void Draw(Bitmap image, string namee);

        [OperationContract(IsOneWay = true)]
        void LeaveGame(string name);
    }
}

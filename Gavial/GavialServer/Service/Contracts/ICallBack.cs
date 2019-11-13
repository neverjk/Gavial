using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GavialServer
{
    public interface ICallBack
    {
        [OperationContract(IsOneWay = true)]
        void RefreshGame(MessageDto newMessage);
        [OperationContract(IsOneWay = true)]
        void RefreshCanvas(Bitmap newDrawing);
    }
}

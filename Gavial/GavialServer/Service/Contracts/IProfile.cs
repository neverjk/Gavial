using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GavialServer
{
    [ServiceContract(CallbackContract = typeof(ICallBack))]
    public interface IProfile
    {
        [OperationContract(IsOneWay = true)]
        void LogIn(string name);

        [OperationContract(IsOneWay = true)]
        void Register(string name);

        [OperationContract(IsOneWay = false)]
        ProfileDto GetProfileInfo(string name);

        [OperationContract(IsOneWay = false)]
        void SetProfileInfo(ProfileDto newProfileInfo);

        [OperationContract(IsOneWay = true)]
        void LogOut(string name);
    }
}

using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Ultimate_Bot_Reloaded.ServiceReference1
{

    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(ConfigurationName = "ServiceReference1.IBotService", SessionMode = (System.ServiceModel.SessionMode)1)]
    public interface IBotService
    {

        [OperationContract(ReplyAction = "http://tempuri.org/IBotService/GetAddressResponse", Action = "http://tempuri.org/IBotService/GetAddress")]
        int[] GetAddress(string addressName);

        [OperationContract(ReplyAction = "http://tempuri.org/IBotService/GetAddressResponse", Action = "http://tempuri.org/IBotService/GetAddress")]
        Task<int[]> GetAddressAsync(string addressName);

        [OperationContract(ReplyAction = "http://tempuri.org/IBotService/GetDataResponse", Action = "http://tempuri.org/IBotService/GetData")]
        string[] GetData(string value);

        [OperationContract(ReplyAction = "http://tempuri.org/IBotService/GetDataResponse", Action = "http://tempuri.org/IBotService/GetData")]
        Task<string[]> GetDataAsync(string value);

        [OperationContract(ReplyAction = "http://tempuri.org/IBotService/PingResponse", Action = "http://tempuri.org/IBotService/Ping")]
        string[] Ping();

        [OperationContract(ReplyAction = "http://tempuri.org/IBotService/PingResponse", Action = "http://tempuri.org/IBotService/Ping")]
        Task<string[]> PingAsync();

        [OperationContract(ReplyAction = "http://tempuri.org/IBotService/UserConnectionResponse", Action = "http://tempuri.org/IBotService/UserConnection")]
        void UserConnection(string regions);

        [OperationContract(ReplyAction = "http://tempuri.org/IBotService/UserConnectionResponse", Action = "http://tempuri.org/IBotService/UserConnection")]
        Task UserConnectionAsync(string regions);

        [OperationContract(ReplyAction = "http://tempuri.org/IBotService/UserDisconnectResponse", Action = "http://tempuri.org/IBotService/UserDisconnect", IsTerminating = true)]
        string UserDisconnect();

        [OperationContract(ReplyAction = "http://tempuri.org/IBotService/UserDisconnectResponse", Action = "http://tempuri.org/IBotService/UserDisconnect", IsTerminating = true)]
        Task<string> UserDisconnectAsync();

    }

}


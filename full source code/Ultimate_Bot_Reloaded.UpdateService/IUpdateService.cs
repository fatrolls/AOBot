using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Ultimate_Bot_Reloaded.UpdateService
{

    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(ConfigurationName = "UpdateService.IUpdateService")]
    public interface IUpdateService
    {

        [OperationContract(ReplyAction = "http://tempuri.org/IUpdateService/CheckUpdateResponse", Action = "http://tempuri.org/IUpdateService/CheckUpdate")]
        bool CheckUpdate(string version);

        [OperationContract(ReplyAction = "http://tempuri.org/IUpdateService/CheckUpdateResponse", Action = "http://tempuri.org/IUpdateService/CheckUpdate")]
        Task<bool> CheckUpdateAsync(string version);

    }

}


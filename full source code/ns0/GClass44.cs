using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Ultimate_Bot_Reloaded.UpdateService;

namespace ns0
{

    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [DebuggerStepThrough]
    public sealed class GClass44 : IUpdateService
    {

        public GClass44()
        {
        }

        public GClass44(string string_0) : base(string_0)
        {
        }

        public GClass44(string string_0, string string_1) : base(string_0, string_1)
        {
        }

        public GClass44(string string_0, EndpointAddress endpointAddress_0) : base(string_0, endpointAddress_0)
        {
        }

        public GClass44(Binding binding_0, EndpointAddress endpointAddress_0) : base(binding_0, endpointAddress_0)
        {
        }

        public bool CheckUpdate(string version)
        {
            return get_Channel().CheckUpdate(version);
        }

        public Task<bool> CheckUpdateAsync(string version)
        {
            return get_Channel().CheckUpdateAsync(version);
        }

    } // class GClass44

}


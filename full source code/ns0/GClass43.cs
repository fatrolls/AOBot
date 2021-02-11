using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Ultimate_Bot_Reloaded.ServiceReference1;

namespace ns0
{

    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public sealed class GClass43 : IBotService
    {

        public GClass43()
        {
        }

        public GClass43(string string_0) : base(string_0)
        {
        }

        public GClass43(string string_0, string string_1) : base(string_0, string_1)
        {
        }

        public GClass43(string string_0, EndpointAddress endpointAddress_0) : base(string_0, endpointAddress_0)
        {
        }

        public GClass43(Binding binding_0, EndpointAddress endpointAddress_0) : base(binding_0, endpointAddress_0)
        {
        }

        public int[] GetAddress(string addressName)
        {
            return get_Channel().GetAddress(addressName);
        }

        public Task<int[]> GetAddressAsync(string addressName)
        {
            return get_Channel().GetAddressAsync(addressName);
        }

        public string[] GetData(string value)
        {
            return get_Channel().GetData(value);
        }

        public Task<string[]> GetDataAsync(string value)
        {
            return get_Channel().GetDataAsync(value);
        }

        public string[] Ping()
        {
            return get_Channel().Ping();
        }

        public Task<string[]> PingAsync()
        {
            return get_Channel().PingAsync();
        }

        public void UserConnection(string regions)
        {
            get_Channel().UserConnection(regions);
        }

        public Task UserConnectionAsync(string regions)
        {
            return get_Channel().UserConnectionAsync(regions);
        }

        public string UserDisconnect()
        {
            return get_Channel().UserDisconnect();
        }

        public Task<string> UserDisconnectAsync()
        {
            return get_Channel().UserDisconnectAsync();
        }

    } // class GClass43

}


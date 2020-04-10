using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using TheCallCenter.Data.Entities;

namespace TheCallCenter.Hubs
{
    public class CallCenterHub : Hub<ICallCenterHub>
    {
        public static readonly string CallCenterGroup = "CallCenters";
        public async Task NewCallReceive(Call call)
        {
            await Clients.Group(CallCenterHub.CallCenterGroup).NewCallReceive(call);
        }

        public async Task JoinCallCenters()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, CallCenterHub.CallCenterGroup);
        }
    }
}

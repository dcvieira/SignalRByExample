using System.Threading.Tasks;
using TheCallCenter.Data.Entities;

namespace TheCallCenter.Hubs
{
    public interface ICallCenterHub
    {
        Task NewCallReceive(Call call);
        Task JoinCallCenters();
    }
}
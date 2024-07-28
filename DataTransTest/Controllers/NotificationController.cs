using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class NotificationController : Controller
{
    private readonly IHubContext<NotificationHub> _hubContext;

    public NotificationController(IHubContext<NotificationHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public async Task<IActionResult> SendNotification()
    {
        await Task.Delay(TimeSpan.FromSeconds(5));
        await _hubContext.Clients.All.SendAsync("ReceiveNotification", "New notification received!");
        return Ok();
    }
}
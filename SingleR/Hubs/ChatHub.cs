using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

public class ChatHub : Hub
{
    private readonly MessageRepository _messageRepository;

    public ChatHub(MessageRepository messageRepository)
    {
        _messageRepository = messageRepository;
    }

    public async Task SendMessage(string user, string message)
    {
        // Save the message to the database
        //await _messageRepository.SaveMessageAsync(user, message);

        // Broadcast the message to all clients
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}

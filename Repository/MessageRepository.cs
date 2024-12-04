using System.Threading.Tasks;

public class MessageRepository 
{
    public async Task SaveMessageAsync(string user, string message)
    {
        // Code to save the message in the database
        // Example using Entity Framework:
        // var chatMessage = new ChatMessage { User = user, Message = message };
        // _dbContext.ChatMessages.Add(chatMessage);
        // await _dbContext.SaveChangesAsync();
        await Task.CompletedTask; // Simulate async operat
    }
}

using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace MyBot
{
    public class Program
    {
        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            DiscordSocketClient client = new DiscordSocketClient();
            client.Log += Log;

            string token = System.IO.File.ReadAllText("AbyssBot.secret");
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            client.MessageReceived += MessageReceived;

            await Task.Delay(-1); //stops the program from exiting main until the program is closed

        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private async Task MessageReceived(SocketMessage message)
        {
            if (message.Content == "!hello")
            {
                await message.Channel.SendMessageAsync("Herro oni-chan!");
            }

            if (message.Content == "!test")
            {
                await message.Channel.SendMessageAsync("Test!");
            }

            if (message.Content == "!emotetest")
            {
                await message.Channel.SendMessageAsync("<a:SpriteServerTest1:448373306207240192> <a:SpriteServerTest2:448374244079042561> ");
            }

            if (message.Content == "!pm")
            {
                await message.Author.SendMessageAsync("This is a test, oni-chan!");
            }
        }

    }
}


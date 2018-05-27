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

            MessageHandler handler = new MessageHandler();
            client.MessageReceived += handler.MessageReceived;

            await Task.Delay(-1); //stops the program from exiting main until the program is closed
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}


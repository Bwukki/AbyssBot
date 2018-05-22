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

            string token = "blahblahblah";
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            await Task.Delay(-1); //stops the program from exiting main until the program is closed

        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}


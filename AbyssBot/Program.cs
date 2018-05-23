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
            if (message.Content == "!partytime")
            {
                await message.Author.SendMessageAsync("<a:TestMsg4:448379297405730827><a:TestMsg5:448379298714353674><a:TestMsg6:448379299666591744><a:TestMsg2:448379158817538048><a:TestMsg3:448379160553848842><a:TestMsg1:448379158620536832><a:TestMsg3:448379160553848842><a:TestMsg2:448379158817538048><a:TestMsg6:448379299666591744><a:TestMsg5:448379298714353674><a:TestMsg4:448379297405730827>");
                await message.Author.SendMessageAsync(" <a:SpriteServerTest1:448373306207240192> <a:SpriteServerTest2:448374244079042561> PARTY TIME <a:SpriteServerTest2:448374244079042561> <a:SpriteServerTest1:448373306207240192>");
                await message.Author.SendMessageAsync("<a:Test8:448380788019298324> <a:Test9:448380871171637260> <a:Test7:448380787075842051> https://gifsound.com/?gifv=5xa3bCB&v=NvS351QKFV4&s=70 <a:Test7:448380787075842051> <a:Test9:448380871171637260><a:Test8:448380788019298324>");
            }
            if (message.Content == "!This is a test")
            {
                await message.Channel.SendMessageAsync("This is a test of the development branch");
            }
        }

    }
}


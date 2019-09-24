using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Discord_bot
{
    class Program
    {
        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        
        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();
            
            _client.Log += Log;
            
            string token = System.IO.File.ReadAllText(@"../Token");
            Console.WriteLine(token);

            await _client.LoginAsync(TokenType.Bot, token.Trim());
            await _client.StartAsync();
            
            CommandHandler c = new CommandHandler(_client ,new CommandService());

            await c.InstallCommandsAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}

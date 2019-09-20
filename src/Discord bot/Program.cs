using System;
using System.Threading.Tasks;
using Discord;
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

            var token = "NjI0NTkxOTk5OTc0MjQ0MzUz.XYTPWw.j5jMDR5CN0Tn2quUkm5uR3vHGBM";

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}

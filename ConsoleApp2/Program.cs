using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Shadow_Android
{
    public class Program
    {

        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        public Program()
        {
            //Sets the bot's stats to 0 when the program starts.
            Stats.AnnoyLevel = 0;
            Stats.embarrasLevel = 0;
        }


        
        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            string token = System.IO.File.ReadAllText(@"token.txt");//Read token from text file.

            new CommandHandler();

            await _client.LoginAsync(TokenType.Bot, token);

            await _client.StartAsync();

            _handler = new CommandHandler();

            await _handler.InitializeAsync(_client);

            await Task.Delay(-1);
        }

    }

}
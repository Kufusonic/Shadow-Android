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
            


            new CommandHandler();

            await _client.LoginAsync(TokenType.Bot, "MzQwMDAwNjUxODc2NjMwNTI4.DLjagg.ztDCFFSSSeWsjEbS-a_tudWQlrs");//Token goes here TODO: MAKE TOKEN READ FROM TEXT FILE.

            await _client.StartAsync();

            _handler = new CommandHandler();

            await _handler.InitializeAsync(_client);

            await Task.Delay(-1);
        }

    }

}
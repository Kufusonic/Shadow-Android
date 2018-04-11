using Discord.Commands;
using Discord.WebSocket;
using Discord;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Shadow_Android
    //This damn thing is a mess like good lord. Just tons of shitty hardcoded bullshit.
{
    public class CommandHandler
    {
        private DiscordSocketClient _client;

        private CommandService _service;

        public async Task InitializeAsync(DiscordSocketClient client)
        {
            _client = client;

            _service = new CommandService();

            await _service.AddModulesAsync(Assembly.GetEntryAssembly());

            _client.MessageReceived += HandleCommandAsync;

            _client.MessageReceived += Genocide;

            _client.MessageReceived += TTS;

            _client.MessageReceived += Love;

            //_client.MessageReceived += Gam;

            _client.UserJoined += WelcomeMessage;

            //_client.UserJoined += RoleChange;

            _client.MessageReceived += racist;

            _client.UserLeft += usergone;

            _client.UserBanned += GotBanned;




        }



        private async Task GotBanned(SocketUser u, SocketGuild g)
        {
            var ch = _client.GetChannel(367828009371172875) as ISocketMessageChannel;
            await ch.SendMessageAsync(u.Mention + " has been banned, PASTA LA VISTA, BAYBEEE!");

        }


        private async Task usergone(SocketUser u)
        {
            var ch = _client.GetChannel(339293367659659264) as ISocketMessageChannel;
            await ch.SendMessageAsync(u.Mention+ " has left the server. Bye, Felicia.");

        }


        private async Task Genocide(SocketMessage s)
        {
            int test = 1;
            var msg = s as SocketUserMessage;
            int argPos = 0;
            var context = new SocketCommandContext(_client, msg);
            var result = await _service.ExecuteAsync(context, argPos);
            if (msg == null) return;
            if (msg.HasStringPrefix("Genocide", ref argPos) || msg.HasStringPrefix("genocide", ref argPos))
            {
                Console.WriteLine("Test");
                await context.Channel.SendMessageAsync("... ... ...");
            }
        }

        private async Task Gam(SocketMessage s)
        {
            //var user = _client.
            int test = 1;
            var msg = s as SocketUserMessage;
            int argPos = 0;
            var context = new SocketCommandContext(_client, msg);
            var result = await _service.ExecuteAsync(context, argPos);
            //if()

        }
        private async Task racist(SocketMessage s)
        {
            //var user = _client.
            int test = 1;
            var msg = s as SocketUserMessage;
            int argPos = 0;
            var context = new SocketCommandContext(_client, msg);
            var result = await _service.ExecuteAsync(context, argPos);
            if (msg.HasStringPrefix("racist", ref argPos) || msg.HasStringPrefix("rac", ref argPos) || msg.HasStringPrefix("RAC", ref argPos))
            {
                Console.WriteLine("Test");
                await context.Channel.SendFileAsync("pics/racist.gif", "U RACIST");
            }
            //if()

        }

        private async Task TTS(SocketMessage s)
        {
            int test = 1;
            var msg = s as SocketUserMessage;
            int argPos = 0;
            var context = new SocketCommandContext(_client, msg);
            var result = await _service.ExecuteAsync(context, argPos);
            if (msg == null) return;
            if (msg.IsTTS)
            {
                Console.WriteLine("Test");
                await context.Channel.SendMessageAsync("Don't fucking do that TTS BS it's annoying... FUCK!");
            }
        }

        private async Task WelcomeMessage(SocketUser g)
        {

            //var id = _client.GetGuild(339292238603354124);
            var ch = _client.GetChannel(340419650401861632) as ISocketMessageChannel;
            await ch.SendMessageAsync("Your Game Genie worked!\n"+g.Mention+", welcome to The Hidden Palace Discord. We've been expecting you...");
        
            
        }

        private async Task RoleChange(SocketUser g)
        {
            var id = g.Id;
            
        }

        private async Task Love(SocketMessage s)
        {
            int test = 1;
            var msg = s as SocketUserMessage;
            int argPos = 0;
            var context = new SocketCommandContext(_client, msg);
            var result = await _service.ExecuteAsync(context, argPos);
            
            if (msg == null) return;
            if (msg.HasStringPrefix("I love you shadow", ref argPos) || msg.HasStringPrefix("i love you shadow", ref argPos) || msg.HasStringPrefix("I love you Shadow", ref argPos) || msg.HasStringPrefix("i love you Shadow", ref argPos))
            {
                Random rnd = new Random();
                string say = "default";


                int select = rnd.Next(1, 4);
                
                

                if (select == 1 && Stats.embarrasLevel < 6)
                {
                    say = "Wow, this is... embarassing";
                    Console.WriteLine(Stats.embarrasLevel);
                    Stats.embarrasLevel = Stats.embarrasLevel + 3;
                }
                if (select == 2 && Stats.embarrasLevel < 6)
                {
                    say = "*blushes";
                    Console.WriteLine(Stats.embarrasLevel);
                    Stats.embarrasLevel = Stats.embarrasLevel + 4;
                }
                if (select == 3 && Stats.embarrasLevel < 6)
                {
                    say = "Umm...";
                    Console.WriteLine(Stats.embarrasLevel);
                    Stats.embarrasLevel = Stats.embarrasLevel + 1;
                }
                if (select == 4 && Stats.embarrasLevel < 6)
                {
                    say = "I'm a Android you know...";
                    Console.WriteLine(Stats.embarrasLevel);
                    Stats.embarrasLevel = Stats.embarrasLevel + 2;
                }
                
                if (Stats.embarrasLevel >= 7)
                {
                    Stats.embarrasLevel = 6;
                }
                Console.WriteLine("Test");
                if (Stats.embarrasLevel < 6)
                {
                    await context.Channel.SendMessageAsync(say);
                }
                Console.WriteLine(Stats.embarrasLevel);
                if (Stats.embarrasLevel >= 6)
                {
                    Console.WriteLine(Stats.embarrasLevel);
                    say = "Ok, please go away...";
                    
                    await context.Channel.SendFileAsync("Pics/shadow_love.png", say);
                    Stats.embarrasLevel = 0;
                }
            }
        }

        private async Task HandleCommandAsync(SocketMessage s)
        {
            var msg = s as SocketUserMessage;
            
            if (msg == null) return;

            var context = new SocketCommandContext(_client, msg);

            int argPos = 0;
            


            if (msg.HasCharPrefix('!', ref argPos))
            {



                var result = await _service.ExecuteAsync(context, argPos);

               

                if (!result.IsSuccess)
                {
                    
                    await context.Channel.SendMessageAsync("THE COMMAND IS INVALID U FUK: "+result.ErrorReason);
                }
            }
           
        }

    }
}
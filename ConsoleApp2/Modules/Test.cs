using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;
using Discord;

namespace Shadow_Android.Modules
{
    
    public class Test : ModuleBase<SocketCommandContext>
    {
        
        [Command("help")]
        public async Task fdsfsd()
        {
            await Context.Channel.SendMessageAsync("Command List: \n\n!rules: Displays the rules.\n\n!maria: Try it and see what happens. ;)\n\n!sonic:'Now I know who you are!'\n\n!dance: Dancing idk");
        }
        [Command("jose")]
        public async Task fdsdfdffsd()
        {
            Random rnd = new Random();
            string say = "default";

            int select = rnd.Next(1, 3);
            if (select == 1)
            {
                say = "Grrr...";
            }
            if (select == 2)
            {
                say = "I don't know you tell me.";
            }
            if (select == 3)
            {
                say = "Long time no see.";
            }
            if (select == 4)
            {
                say = "And this tub of fuck...";
            }
            await Context.Channel.SendMessageAsync(say);
            
        }
        [Command("Maria")]
        public async Task fd8789789sfsd()
        {
            Random rnd = new Random();
            string say = "...";
            

            Console.WriteLine(Stats.AnnoyLevel);
            int select = rnd.Next(1, 10);
            if (Stats.AnnoyLevel > 6)
            {
                say = "Stop asking about her...";
                await Context.Channel.SendMessageAsync(say);
                Stats.AnnoyLevel = 0;
            }
            
            if (select == 1)
            {
                say = "MARIA!!";
                Stats.AnnoyLevel = Stats.AnnoyLevel + 6;
            }
            if (select >= 2 && select <6)
            {
                say = "I made that promise...";
                Stats.AnnoyLevel = Stats.AnnoyLevel + 2;
            }
            if (select == 7)
            {
                say = "Don't you remind of such memories.";
                Stats.AnnoyLevel = Stats.AnnoyLevel + 3;
            }
            if(select > 8 && select < 10)
            {
                say = "Yeah, what about her?";
                Stats.AnnoyLevel = Stats.AnnoyLevel + 1;
            }

            Console.WriteLine(Stats.AnnoyLevel);
            await Context.Channel.SendMessageAsync(say);

        }
        [Command("Sonic")]
        public async Task fd878sdad9789sfsd()
        {
            Random rnd = new Random();
            string say = "default";

            int select = rnd.Next(1, 3);
            if (select == 1)
            {
                say = "Faker!!";
            }
            if (select == 2)
            {
                say = "So you really are just a Hedgehog...";
            }
            if (select == 3)
            {
                say = "You're not even good enough to be my fake";
            }
            await Context.Channel.SendMessageAsync(say);
        }
        [Command("rules")]
        public async Task fd8dfgdfg78sdad9789sfsd()
        {
            await Context.Channel.SendMessageAsync("Rules\n 1) All members joining a voice chat must have headphones. No headphones create annoying echos in the call, please wear them. \n 2) Be respectful to all members, don't insult others. If you have a problem with someone message one of the admins.\n 3) NFSW content must be posted to the forbidden-zone channel.Scat, Gore, and Cub is not allowed.\n 4) If you have a group or server that you would like to advertise on our server post it on our showcase channel.\n *Any violation of these rules could results in a ban from this Discord server and other Palace related groups.\nYou have been warned.");
        }
        [Command("dance")]
        public async Task fd878sdad97dfdf89sfsd()
        {

            Random rnd = new Random();
            string say = "default";

            int select = rnd.Next(1, 3);
            if (select == 1)
            {
                say = "Why must you summon this nonsense?";
            }
            if (select == 2)
            {
                say = "Seriously, why?";
            }
            if (select == 3)
            {
                say = "Ok, this has gone too far!";
            }

            await Context.Channel.SendFileAsync("pics/dance.gif",say);
        }
        [Command("gammas")]
        public async Task fds234234fsd()
        {
            await Context.Channel.SendMessageAsync("GAMMAS PLZ");
        }
        [Command("burgerking")]
        public async Task fds23hjhjk4234fsd()
        {
            Random rnd = new Random();
            string say = "default";

            int select = rnd.Next(1, 8);
            if (select >= 1 && select <= 4)
            {
                say = "Oh look, it's me at Burger King!";
            }
            if (select >= 4 && select <= 5)
            {
                say = "Wow that girl looks very confused...";
            }
            if (select >= 6 && select <= 8)
            {
                say = "I'll have a veggie burger.";
            }

            await Context.Channel.SendFileAsync("pics/Burgerking_Shadow.png", say);
        }
        [Command("evan")]
        public async Task fds2cvgfd34234fsd()
        {
            Random rnd = new Random();
            string say = "default";

            int select = rnd.Next(1, 3);
            if (select == 1)
            {
                say = "Fummy Tine";
            }
            if (select == 2)
            {
                say = "meme";
            }
            if (select == 3)
            {
                say = "I'm still secretly a Brony...";
            }
            await Context.Channel.SendMessageAsync(say);
        }
        //[Command("2")]
        //public async Task fdsvcbvcb234234fsd()
        //{
          //  await Context.Channel.SendFileAsync("pics/2.gif", "Two");
        //}
        [Command("connor")]
        public async Task fds2cvgfdfghfgdhd34234fsd()
        {
            Random rnd = new Random();
            string say = "default";

            int select = rnd.Next(1, 4);
            if (select == 1)
            {
                say = "Too Much 2D";
            }
            if (select == 2)
            {
                say = "Ginger's don't have souls.";
            }
            if (select == 3)
            {
                say = "I hate Sonic Forces";
            }
            if (select == 4)
            {
                say = "FUCK FIST BUMP";
            }
            await Context.Channel.SendMessageAsync(say);
        }
        [Command("kawnar")]
        public async Task fds2cvgfdfghjghj34234fsd()
        {
            Random rnd = new Random();
            string say = "default";

            int select = rnd.Next(1, 4);
            if (select == 1)
            {
                say = "Too Much 2D";
            }
            if (select == 2)
            {
                say = "Ginger's don't have souls.";
            }
            if (select == 3)
            {
                say = "I hate Sonic Forces";
            }
            if (select == 4)
            {
                say = "FUCK FIST BUMP";
            }
            await Context.Channel.SendMessageAsync(say);
        }
        [Command("kawnar")]
        public async Task fds2cvgfd342344564645hfsd()
        {
            Random rnd = new Random();
            string say = "default";

            int select = rnd.Next(1, 4);
            if (select == 1)
            {
                say = "Too Much 2D";
            }
            if (select == 2)
            {
                say = "Ginger's don't have souls.";
            }
            if (select == 3)
            {
                say = "I hate Sonic Forces";
            }
            if (select == 4)
            {
                say = "FUCK FIST BUMP";
            }
            await Context.Channel.SendMessageAsync(say);
        }
        [Command("gonzales")]
        public async Task fds2cvg6546fd34234fsd()
        {
            Random rnd = new Random();
            string say = "default";

            int select = rnd.Next(1, 3);
            if (select == 1)
            {
                say = "I'm a Mexico";
            }
            if (select == 2)
            {
                say = "*SKELETON DOOM MEME*";
            }
            if (select == 3)
            {
                say = "SHUT UP SIMBA, THE DOG, NOT THE FUCKING LION KING FUCK";
            }
            
            await Context.Channel.SendMessageAsync(say);
        }
        [Command("niggy")]
        public async Task fds2cvgfdgdf6546fd34234fsd()
        {
            Random rnd = new Random();
            string say = "default";

            int select = rnd.Next(1, 3);
            if (select == 1)
            {
                say = "that wapist";
            }
            if (select == 2)
            {
                say = "bat batist";
            }
            if (select == 3)
            {
                say = "chats chastist";
            }

            await Context.Channel.SendMessageAsync(say);
        }
        [Command("hooters")]
        public async Task fds2cvgfdgdnbvnbvf6546fd34234fsd()
        {
            Random rnd = new Random();
            string say = "";

            int select = rnd.Next(1, 7);

            try //Using an expection catcher to make this work with both PNG and JPG is a VERY jank way of doing it but whatever it works.
            {
                await Context.Channel.SendFileAsync("pics/hooters/" + select+".png", say);
            }
            catch (System.IO.IOException e)
            {
                await Context.Channel.SendFileAsync("pics/hooters/" + select + ".jpg", say);
            }


            
            
        }
    }
    
}

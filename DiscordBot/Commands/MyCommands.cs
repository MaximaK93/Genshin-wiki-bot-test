using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;
using System.IO;
using System.Text;
using DiscordBot;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DiscordBot.Commands
{
    public class MyCommands : ModuleBase<SocketCommandContext>
    {
        

        [Command("айди")]
        public async Task GetMyId()
        {
            var user = Context.User;
            await ReplyAsync($"{user.Mention}, Ваш ID: {user.Id}");            
        } 

        [Command("время")]

        public async Task GetCurrentTime()
        {
            DateTime date = DateTime.Now;
            await ReplyAsync($"{date}");
           
        }

        [Command("ролл")]

        public async Task Roll()
        {      
            Random roll = new Random();
            var user = Context.User;
            await ReplyAsync(user.Mention + $" Получает число {roll.Next(-1,101)}");
        }
    }
}


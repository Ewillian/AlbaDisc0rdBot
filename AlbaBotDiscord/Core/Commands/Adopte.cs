using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;

namespace AlbaBotDiscord.Core.Commands
{
    public class Adopte : ModuleBase<SocketCommandContext>
    {
        [Command("adopté"), Summary("")]
        public async Task help()
        {
            await Context.Channel.SendMessageAsync("Et qui qui c'est qui a été adopté ? https://media.giphy.com/media/2Qs2hKWMvEzdu/giphy.gif");

        }
    }
}

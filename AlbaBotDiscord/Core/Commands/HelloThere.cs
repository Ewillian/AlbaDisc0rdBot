using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;

namespace AlbaBotDiscord.Core.Commands
{
    class HelloThere : ModuleBase<SocketCommandContext>
    {
        [Command("Hello"), Alias("SalutATous"), Summary("Répond de manière cultisime.")]
        public async Task Gobiwan()
        {
            await Context.Channel.SendMessageAsync("https://media.giphy.com/media/Nx0rz3jtxtEre/giphy.gif");
        }
    }
}

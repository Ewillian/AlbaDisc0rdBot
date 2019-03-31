using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;

namespace AlbaBotDiscord.Core.Commands
{
    public class ReinforcementCall : ModuleBase<SocketCommandContext>
    {
        [Command("BF"), Alias("bf"), Summary("Appel en cours...")]
        public async Task battle()
        {
            ulong bfId = 561922806053470219;
            await Context.Channel.SendMessageAsync(Context.Message.Author.Mention + " appel des renfort en cours...");
            await Context.Channel.SendMessageAsync("HÉ ! "+ Context.Guild.GetRole(bfId).Mention + " GO BF !! https://media.giphy.com/media/etGqEtk7DtQNqfgzWa/giphy.gif");
        }
    }
}

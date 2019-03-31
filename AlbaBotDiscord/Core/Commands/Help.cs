using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;
using System.Collections;

namespace AlbaBotDiscord.Core.Commands
{
    public class Help : ModuleBase<SocketCommandContext>
    {
        [Command("help"), Alias("h"), Summary("Liste des commandes disponible.")]
        public async Task help()
        {
            var comList = new List<string>();
            comList.Add("?!Help ou ?!h || Affiche la liste des commandes.");
            comList.Add("?!Hello ou ?!ht || Dit bonjour.");
            comList.Add("?!BF ou ?!bf || Notifie joueurs de Battlefiel V.");
            await Context.Channel.SendMessageAsync("Liste des commandes :");
            foreach (String coms in comList)
            {
                await Context.Channel.SendMessageAsync("`"+coms+"`");
            }
        }
    }
}

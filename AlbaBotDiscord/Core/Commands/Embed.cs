using System;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;

namespace AlbaBotDiscord.Core.Commands
{
    public class Embed : ModuleBase<SocketCommandContext>
    {
        [Command("profile"), Summary("embed")]
        public async Task profile()
        {
            EmbedBuilder embed = new EmbedBuilder();
            //embed.WithAuthor(Context.Client.CurrentUser.Username, Context.Client.CurrentUser.GetAvatarUrl());
            embed.WithAuthor("Albab0t#8725", "https://cdn.discordapp.com/app-icons/521715447142416384/b9690f1ac7f3e45309390fe06d415d29.png");
            embed.WithColor(5688530);
            embed.WithTitle("Profil");
            embed.WithDescription("Description: \n"+ "```Salutation ! je suis Albab0t#8725, je suis né à l'usine d’assemblage de robots, RUEBA. \n"+
                "Robot protocolaire pouvant pirater, se miniaturiser, éclairer et parler plus de 700 langues. \n"+
                "Je possède cependant une peur du vide inexpliqué et si j'ai l'air aussi joyeux, ce sont mes concepteurs qui m'ont programmé avec cette voix par défaut.```");
            embed.AddInlineField("Apparence :", ""); 
            await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
    }
}

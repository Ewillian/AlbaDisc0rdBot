using System;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;

namespace AlbaBotDiscord.Core.Commands
{
    public class Embed : ModuleBase<SocketCommandContext>
    {
        [Command("profile"),Alias("pb"), Summary("embed")]
        public async Task profile()
        {
            EmbedBuilder embed = new EmbedBuilder();
            //embed.WithAuthor(Context.Client.CurrentUser.Username, Context.Client.CurrentUser.GetAvatarUrl());
            embed.WithAuthor("Albab0t#8725", "https://cdn.discordapp.com/app-icons/521715447142416384/b9690f1ac7f3e45309390fe06d415d29.png");
            embed.WithColor(5688530);
            embed.WithTitle("Profil");
            embed.WithDescription(" ``` Initialisation en cours...```"+
                "``` launcheurV2.1.bot lancement... ``` \n" +
                "\n **Description**: \n"+ "Salutation :slight_smile: ! je suis Albab0t#8725, je suis né à l'usine d’assemblage de robots :robot: , RUEBA. \n" +
                "Robot protocolaire pouvant pirater, se miniaturiser, éclairer et parler plus de 700 langues. \n"+
                "Je possède cependant une peur du vide inexpliquée et si j'ai l'air aussi joyeux, ce sont mes concepteurs qui m'ont programmé avec cette voix par défaut. \n"+
                "\n **Apparence :**");
            embed.WithImageUrl("https://github.com/Ewillian/AlbaDisc0rdBot/blob/master/AlbaBotDiscord/Image/Apparence.png?raw=true");
            await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
    }
}

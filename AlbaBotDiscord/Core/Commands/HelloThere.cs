using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

using Discord;
using Discord.Commands;

namespace AlbaBotDiscord.Core.Commands
{
    public class HelloThere : ModuleBase<SocketCommandContext>
    {

        //[Command("Help"), Alias("HELP"), Summary("Répond de manière cultisime.")]
        public async Task help()
        {
            await Context.Channel.SendMessageAsync("");
        }

        [Command("jet'aime"), Summary("Répond de manière cultisime.")]
        public async Task aimer()
        {
            await Context.Channel.SendMessageAsync("Je t'aime aussi "+ Context.Message.Author.Mention);
        }

        [Command("jet'aimepas"), Summary("Répond de manière cultisime.")]
        public async Task pasAimer()
        {
            await Context.Channel.SendMessageAsync("Tiens un peu d'amour propre !! " + Context.Message.Author.Mention+ " car tu as été adopté!");
        }

        [Command("Hello"), Summary("Répond de manière cultisime.")]
        public async Task Gobiwan()
        {
            await Context.Channel.SendMessageAsync("https://media.giphy.com/media/Nx0rz3jtxtEre/giphy.gif");
        }

        [Command("BF"), Summary("Appel en cours...")]
        public async Task battle()
        {
            await Context.Channel.SendMessageAsync(Context.Message.Author.Mention + " appel des renfort en cours...");
            if (Context.User.Username == "Ewillian")
            {
                await Context.Channel.SendMessageAsync("HÉ ! CallmeGemini Hexa🔴🔵 GO BF !! https://media.giphy.com/media/etGqEtk7DtQNqfgzWa/giphy.gif");
            }
            else if (Context.User.Username == "Hexa 🔴🔵")
            {
                await Context.Channel.SendMessageAsync("HÉ ! CallmeGemini Ewillian GO BF !! https://media.giphy.com/media/etGqEtk7DtQNqfgzWa/giphy.gif");
            }
            else if (Context.User.Username == "CallmeGemini")
            {
                await Context.Channel.SendMessageAsync("HÉ ! Ewillian Hexa🔴🔵 GO BF !! https://media.giphy.com/media/etGqEtk7DtQNqfgzWa/giphy.gif");
            }
        }

        //[Command("embed"), Summary("Embed test command")]
        public async Task Embed([Remainder]string Input = "None")
        {
            EmbedBuilder Embed = new EmbedBuilder();
            Embed.WithAuthor("Test embed", Context.User.GetAvatarUrl());
            Embed.WithColor(40, 200, 150);
            Embed.WithFooter("The footer of the embed", Context.Guild.Owner.GetAvatarUrl());
            Embed.WithDescription("This is a **dummy** description, with a cool link.\n" +
                              "[This is my favourite website](https://www.sjustein.com/)");
            Embed.AddInlineField("User input:", Input);

            await Context.Channel.SendMessageAsync("", false, Embed.Build());
        }
    }
}

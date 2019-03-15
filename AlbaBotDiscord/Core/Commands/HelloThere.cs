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
        [Command("Hello"), Alias("SalutATous"), Summary("Répond de manière cultisime.")]
        public async Task Gobiwan()
        {
            await Context.Channel.SendMessageAsync("https://media.giphy.com/media/Nx0rz3jtxtEre/giphy.gif");
        }

        [Command("embed"), Summary("Embed test command")]
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

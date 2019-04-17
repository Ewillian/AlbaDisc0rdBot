using Discord;
using Discord.Commands;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlbaBotDiscord.Core.Commands
{
    public class Rand : ModuleBase<SocketCommandContext>
    {
        public string path;
        [Command("Image"), Summary("Send random image.")]
        public async Task RandomImg()
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 29);
            

            XDocument doc = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "../../../Core/Data/ImgParameters.xml");
            var keys = doc.Descendants("appSettings");

            foreach (XElement el in doc.Root.Elements())
            {
               if(el.Attribute("key").Value == rand.ToString())
                {
                    path = el.Attribute("value").Value;
                }
            }
            Console.WriteLine(path);
            await Context.Channel.SendFileAsync("../../../Core/Data"+path);
        }
    }
}

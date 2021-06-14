using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using DiscordBot.Util;

namespace DiscordBot.Commands
{
    public class Actions : ModuleBase<SocketCommandContext>
    {
        private async Task Action(string key, string message, string action, SocketUser user)
        {
            if (user == null)
            {
                user = Context.User;
            }
            await CommandSource.SendAction(Context, user, key, message, action);

        }        
        [Command("kiss")]
        public async Task Kiss(SocketUser user = null)
        {
            await Action("kiss", "😽 mwuah", "kissing", user);
        }
        
        [Command("lick")]
        public async Task Lick(SocketUser user = null)
        {
            await Action("lick", "👅 lick!", "licking", user);
        }
        
        [Command("hug")]
        public async Task Hug(SocketUser user = null)
        {
            await Action("hug", "💞 hug!", "hugging", user);
        }
        
        [Command("slap")]
        public async Task Slap(SocketUser user = null)
        {
            await Action("slap", "🔪 slap!", "slapping", user);
        }
        
        [Command("cuddle")]
        public async Task Cuddle(SocketUser user = null)
        {
            await Action("cuddle", "💖 cuddle!", "cuddling", user);
        }
    }
}
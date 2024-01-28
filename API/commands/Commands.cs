using Eco.Gameplay.EcopediaRoot;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.ModKit;

namespace RD.Framework.API.commands
{
    public class Commands
    {
        private static string RDVersion = "0.0.1";

        [ChatCommand("Checks Verion of RD Framework", "rd-ver", ChatAuthorizationLevel.Admin)]
        public static void CheckModVersion(IChatClient chatClient)
        {
            chatClient.MsgLocStr($"RD Framework Version:" + RDVersion);
        }
    }
}

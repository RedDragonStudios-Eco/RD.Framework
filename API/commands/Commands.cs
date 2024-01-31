using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using System.Reflection;

namespace RD.Framework.API.commands
{
    [ChatCommandHandler]
    public class Commands
    {
        private static string RDVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        [ChatCommand("Checks Verion of RD Framework", "rd-ver", ChatAuthorizationLevel.Admin)]
        public static void CheckModVersion(IChatClient chatClient)
        {
            chatClient.MsgLocStr($"RD Framework Version:" + RDVersion);
        }
    }
}

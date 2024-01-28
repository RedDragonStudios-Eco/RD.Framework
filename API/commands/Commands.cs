using Eco.Gameplay.EcopediaRoot;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.ModKit;

namespace RD.Framework.API.commands
{
    public class Commands
    {
        private static string RDVersion = "0.0.1";

        [ChatCommand("Reloads the Unity Data Files without needing to reboot the server", "rl-unity", ChatAuthorizationLevel.Admin)]
        public static void ReloadUnitlyData(IChatClient chatClient)
        {
            ModKitPlugin.ContentSync.RefreshContent();
            chatClient.MsgLocStr("Unity Files Refreshed, Please Relog to get new changes.");
        }

        [ChatCommand("Rebuilds the ecopedia", "rl-ecopedia", ChatAuthorizationLevel.Admin)]
        public static void ReBuildEcopedia(IChatClient chatClient)
        {
            EcopediaManager.Build(ModKitPlugin.ModDirectory);
            chatClient.MsgLocStr("The Ecopedia has been Rebuilt and should auto update. Please check the console for any errors or issue with the rebuilt Ecopedia");
        }

        [ChatCommand("Checks Verion of RD Framework", "rd-ver", ChatAuthorizationLevel.Admin)]
        public static void CheckModVersion(IChatClient chatClient)
        {
            chatClient.MsgLocStr($"RD Framework Version:" + RDVersion);
        }
    }
}

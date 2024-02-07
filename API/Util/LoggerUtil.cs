namespace RD.Framework.API.Util
{
    using Eco.Core.Utils.Logging;
    using Eco.Shared.Localization;
    using Eco.Shared.Utils;
    using System.Reflection;

    public class LogUtility
    {
        private static string rdLogger = "RD-Framework";
        private static NLogWriter Logging = NLogManager.GetLogWriter(rdLogger);
        private static Dictionary<string, string> loged = new();
        public static NLogWriter Logger => GetLogger(Assembly.GetCallingAssembly());

        public static void CreateNewLogger(string log)
        {
            var assembly = Assembly.GetCallingAssembly().GetName().Name;
            if (loged.ContainsKey(assembly))
            {
                Log.WriteWarningLineLoc($"[RD Framework]: Mod Error: Existing Logger Registered: Loggers can only be created once per assembly, please use the already existing logger class");
                return;
            }
            loged.Add(assembly, log);
        }
        private static NLogWriter GetLogger(Assembly assembly)
        {
            var amblr = assembly.GetName().Name;
            foreach (var L in loged)
            {
                if (amblr == L.Key)
                    return NLogManager.GetLogWriter(L.Value);
            }
            return Logging;
        }

        public static void Write(string s) => Logger.Write($"[{DateTime.Now:HH:mm:ss}]" + s);
        public static void Debug(string s) => Logger.Debug($"[{DateTime.Now:HH:mm:ss}]" + s);
        public static void Warning(string s) => Logger.WriteWarning($"[{DateTime.Now:HH:mm:ss}]");
        public static void Error(string s) => Logger.WriteError($"[{DateTime.Now:HH:mm:ss}]" + s);
        public static void LogTypeSelect(string message, LogType logType)
        {
            message = Localizer.DoStr(message);

            switch (logType)
            {
                case LogType.Info:
                    Logger.Write($"[{DateTime.Now:HH:mm:ss}]" + message); return;
                case LogType.Error:
                    Logger.WriteError($"[{DateTime.Now:HH:mm:ss}]" + message); return;
                case LogType.Warn:
                    Logger.WriteWarning($"[{DateTime.Now:HH:mm:ss}]" + message); return;
                case LogType.Debug:
                    Logger.Debug($"[{DateTime.Now:HH:mm:ss}]" + message); return;
                case LogType.Important:
                    Logger.WriteError($"[{DateTime.Now:HH:mm:ss}]" + message);
                    Log.WriteError(Localizer.DoStr(message)); return;
                default: Logger.Write($"[{DateTime.Now:HH:mm:ss}]" + message); return;
            }
        }

        public enum LogType
        {
            Info,Error,Debug,Warn,Important
        }
    }
}

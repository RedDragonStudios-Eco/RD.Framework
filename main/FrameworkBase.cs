using RD.Framework.API.FileManager;
using System;
using System.IO;
using System.Reflection;




namespace RD.Framework.main
{
    public static class Defaults
    {
        internal const string location = "RedDragonMods";
        internal const string fileFormat = ".json";
        private static readonly string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        private static readonly string saveLocation = Path.Combine("Configs", "Mods");
        public const string appName = "<color=red>[RD Framework]:</color> ";
        public const string appnameCon = "[RD Framework]";
        public static string Version => version;

        public static string SaveLocation => GetReleventDirectory();
        public static string AssemblyLocation => Directory.GetCurrentDirectory();
        
       static string GetReleventDirectory()
        {
            if (saveLocation.StartsWith(Path.DirectorySeparatorChar))
            {
                return Path.Combine(AssemblyLocation, saveLocation);
            }
            return saveLocation;
        }
        public static string GetReleventDirectory(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return Path.Combine(AssemblyLocation, "Undefined");
            }
            return Path.Combine(AssemblyLocation, path);
        }
        static void CreateDirectoryIfNonExist() => CreateDirectoryIfNonExist(SaveLocation);
        public static void CreateDirectoryIfNonExist(string Path)
        {
            if (!Directory.Exists(SaveLocation)) {
                Directory.CreateDirectory(SaveLocation);
            }
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        static string GetPathof(string FileName)
        {
            if (FileName.Contains(fileFormat)) 
            {
                return Path.Combine(SaveLocation, FileName);
            }
            return Path.Combine(SaveLocation, FileName + fileFormat);
        }

        public static bool ConfigAlreadyExists(string fileName) => File.Exists(GetPathof(fileName));

        static string GetPath(string FileName)
        {
            if(FileName.EndsWith(fileFormat))
            {
                FileName += fileFormat;
            }
            return Path.Combine(SaveLocation, FileName);
        }

        public static BaseConfig Config
        {
            get
            {
                return FileManager<BaseConfig>.ReadFromFile(SaveLocation,"RD.Base");
            }
            set
            {
                FileManager<BaseConfig>.WriteToFile(value, SaveLocation, "RD.Base");
            }
        }

    }
}

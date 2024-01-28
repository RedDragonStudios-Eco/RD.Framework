using Eco.Shared.Localization;

namespace RD.Framework.API.config
{
    public class ConfigRDF
    {
        [LocDescription("Whether or not to check RDF Mods, versions and display them.")]
        public bool VersionDisplayEnabled { get; set; } = true;
    }
}

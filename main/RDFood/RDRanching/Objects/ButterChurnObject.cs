
using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Components;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Modules;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Mods.TechTree;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;

namespace RD.Framework.main.RDFood.RDRanching.Objects
{
    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(MinimapComponent))]
    [RequireComponent(typeof(LinkComponent))]
    [RequireComponent(typeof(CraftingComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(PluginModulesComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [Tag("Usable")]
    [Ecopedia("Work Stations", "Craft Tables", subPageName: "Butter Churn Item")]
    public partial class ButterChurnObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(ButterChurnItem);
        public override LocString DisplayName => Localizer.DoStr("Butter Churn");
        public override TableTextureMode TableTexture => TableTextureMode.Wood;

        protected override void Initialize()
        {
            ModsPreInitialize();
            GetComponent<MinimapComponent>().SetCategory(Localizer.DoStr("Crafting"));
            GetComponent<HousingComponent>().HomeValue = ButterChurnItem.homeValue;
            ModsPostInitialize();
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Butter Churn")]
    [LocDescription("Churns Milk into butter.")]
    [IconGroup("World Object Minimap")]
    [Ecopedia("Work Stations", "Craft Tables", createAsSubPage: true)]
    [Weight(5000)]
    [AllowPluginModules(Tags = new[] { "BasicUpgrade" }, ItemTypes = new[] { typeof(CookingUpgradeItem) })]
    public partial class ButterChurnItem : WorldObjectItem<ButterChurnObject>, IPersistentData
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName = typeof(ButterChurnObject).UILink(),
            Category = HousingConfig.GetRoomCategory("Industrial"),
            TypeForRoomLimit = Localizer.DoStr(""),
        };
        [Serialized, SyncToView, NewTooltipChildren(CacheAs.Instance, flags: TTFlags.AllowNonControllerTypeForChildren)] public object PersistentData { get; set; }
    }
}

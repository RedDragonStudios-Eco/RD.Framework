using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Eco.Core.Items;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Components;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Serialization;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Gameplay.Modules;
using Eco.Mods.TechTree;
using Eco.Core.Controller;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Math;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Shared.Utils;

namespace RD.Framework.main.RDRanching.Items.obj
{
    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(MinimapComponent))]
    [RequireComponent(typeof(LinkComponent))]
    [RequireComponent(typeof(CraftingComponent))]
    [RequireComponent(typeof(FuelSupplyComponent))]
    [RequireComponent(typeof(FuelConsumptionComponent))]
    [RequireComponent(typeof(HousingComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    [RequireComponent(typeof(PluginModulesComponent))]
    [RequireComponent(typeof(ForSaleComponent))]
    [Tag("Usable")]
    [Ecopedia("Work Stations", "Craft Tables", subPageName: "Barn Item")]
    public partial class BarnObject : WorldObject, IRepresentsItem
    {
        public virtual Type RepresentedItemType => typeof(BarnItem);
        public override LocString DisplayName => Localizer.DoStr("Barn");
        public override TableTextureMode TableTexture => TableTextureMode.Wood;
        private static string[] fuelTagList = new[] { "Bale" };

        protected override void Initialize()
        {
            ModsPreInitialize();
            GetComponent<MinimapComponent>().SetCategory(Localizer.DoStr("Crafting"));
            GetComponent<FuelSupplyComponent>().Initialize(2, fuelTagList);
            GetComponent<FuelConsumptionComponent>().Initialize(10);
            GetComponent<HousingComponent>().HomeValue = BarnItem.homeValue;
            ModsPostInitialize();
        }

        partial void ModsPreInitialize();

        partial void ModsPostInitialize();
    }


    [Serialized]
    [LocDisplayName("Barn")]
    [LocDescription("Breed animals and slaughter the extras for meat.")]
    [IconGroup("World Object Minimap")]
    [Ecopedia("Work Stations", "Craft Tables", createAsSubPage: true)]
    [Weight(25000)]
    [AllowPluginModules(Tags = new[] { "BasicUpgrade" }, ItemTypes = new[] { typeof(FarmingUpgradeItem) })]
    public partial class BarnItem : WorldObjectItem<BarnObject>, IPersistentData
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(WorldObjectType));
        public override HomeFurnishingValue HomeValue => homeValue;
        public static readonly HomeFurnishingValue homeValue = new HomeFurnishingValue()
        {
            ObjectName = typeof(BarnObject).UILink(),
            Category = HousingConfig.GetRoomCategory("Industrial"),
            TypeForRoomLimit = Localizer.DoStr(""),

        };

        [NewTooltip(CacheAs.SubType, 7)] public static LocString PowerConsumptionTooltip() => Localizer.Do($"Consumes: {Text.Info(10)}w of {new HeatPower().Name} power from fuel.");
        [Serialized, SyncToView, NewTooltipChildren(CacheAs.Instance, flags: TTFlags.AllowNonControllerTypeForChildren)] public object PersistentData { get; set; }
    }

    [RequiresSkill(typeof(CarpentrySkill), 1)]
    [Ecopedia("Work Stations", "Craft Tables", subPageName: "Barn Item")]
    public partial class BarnRecipe : RecipeFamily
    {
        public BarnRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Barn",
                displayName: Localizer.DoStr("Barn"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Wood", 5, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement("Rock", 30, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement("WoodBoard", 10, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BarnItem>()
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 5;
            LaborInCalories = CreateLaborInCaloriesValue(300, typeof(CarpentrySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BarnRecipe), start: 5, skillType: typeof(CarpentrySkill), typeof(CarpentryFocusedSpeedTalent), typeof(CarpentryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Barn"), recipeType: typeof(BarnRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SawmillObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();

    }



}

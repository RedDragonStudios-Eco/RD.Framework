namespace RD.Framework.main.RDSkills.Ranching
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using RD.Framework.main.RDRanching.Items.obj;

    [RequiresSkill(typeof(RancherSkill), 7)]
    [Ecopedia("Upgrade Modules", "Specialty Upgrades", subPageName: "Ranching Upgrade Item")]
    public partial class RanchingUpgradeRecipe : RecipeFamily
    {
        public RanchingUpgradeRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "RanchingUpgrade",
                displayName: Localizer.DoStr("Ranching Upgrade"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BasicUpgradeLvl4Item), 1, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RanchingUpgradeItem>()
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4;
            this.LaborInCalories = CreateLaborInCaloriesValue(3000, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RanchingUpgradeRecipe), start: 10, skillType: typeof(RancherSkill), typeof(RancherFocusedSpeedTalent), typeof(RancherParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Butchery Upgrade"), recipeType: typeof(RanchingUpgradeRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Ranching Upgrade")]
    [LocDescription("Basic Upgrade that greatly increases efficiency when crafting Ranching recipes.")]
    [Weight(1)]
    [Ecopedia("Upgrade Modules", "Specialty Upgrades", createAsSubPage: true)]
    [Tag("Upgrade")]
    public partial class RanchingUpgradeItem : EfficiencyModule
    {
        public RanchingUpgradeItem() : base(
            ModuleTypes.ResourceEfficiency | ModuleTypes.SpeedEfficiency,
            0.5f + 0.05f,
            typeof(RancherSkill),
            0.5f
        )
        { }
    }
}

namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meats
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDButcher.Items.RDRanching;
    using RD.Framework.main.RDFood.RDCooking.Items.Meats;

    [RequiresSkill(typeof(BakingSkill), 2)]
    [Ecopedia("Food", "RDFoods", subPageName: "Ham")]
    public partial class HamRecipe : RecipeFamily
    {
        public HamRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BakedBeans",
                displayName: Localizer.DoStr("Ham"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(RawPorkButtItem), 1, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<HamItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 3;
            LaborInCalories = CreateLaborInCaloriesValue(45, typeof(BakingSkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(HamRecipe), start: 2.0f, skillType: typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Ham"), recipeType: typeof(HamRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BakeryOvenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

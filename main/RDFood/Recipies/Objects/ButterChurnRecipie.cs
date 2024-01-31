using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using RD.Framework.main.RDFood.Items.Objects;

namespace RD.Framework.main.RDFood.Recipies.Objects
{
    [RequiresSkill(typeof(CarpentrySkill), 1)]
    [Ecopedia("Work Stations", "Craft Tables", subPageName: "Butter Churn Item")]
    public partial class ButterChurnRecipe : RecipeFamily
    {
        public ButterChurnRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Butter Churn",
                displayName: Localizer.DoStr("Butter Churn"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 2, true),
                    new IngredientElement("WoodBoard", 10, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ButterChurnItem>()
                });

            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 5;
            LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CarpentrySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButterChurnRecipe), start: 0.05f, skillType: typeof(CarpentrySkill), typeof(CarpentryFocusedSpeedTalent), typeof(CarpentryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Butter Churn"), recipeType: typeof(ButterChurnRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(SawmillObject), recipe: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

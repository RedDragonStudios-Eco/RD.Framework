using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcheringTable.PreparedMeats.ProcessedMeats
{
    [RequiresSkill(typeof(ButcherySkill), 2)]
    public partial class RawMeatballRecipe : RecipeFamily
    {
        public RawMeatballRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "PrepareRawMeatball",
                displayName: Localizer.DoStr("Prepare Raw Meatball"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ScrapMeatItem), 0.5f, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent))
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawMeatItem>(10)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 4;
            LaborInCalories = CreateLaborInCaloriesValue(20, typeof(ButcherySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(RawMeatballRecipe), start: 0.25f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Raw Chicken Nugget"), recipeType: typeof(RawMeatballRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using RD.Framework.main.RDFood.RDCooking.Items.Meals.Kitchen;

namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Kitchen
{
    [RequiresSkill(typeof(CookingSkill), 3)]
    [Ecopedia("Food", "Cooking", subPageName: "Beet Dip Item")]
    public partial class BeetDipRecipe : RecipeFamily
    {
        public BeetDipRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BeetDip",
                displayName: Localizer.DoStr("Beet Dip"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(CharredBeetItem), 10, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement(typeof(SunCheeseItem), 3, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement(typeof(FlatbreadItem), 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BeetDipItem>(3)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2;
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BeetDipRecipe), start: 1.0f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Beet Dip"), recipeType: typeof(BeetDipRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(KitchenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

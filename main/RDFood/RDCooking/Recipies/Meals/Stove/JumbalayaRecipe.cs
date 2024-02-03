using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using RD.Framework.main.RDFood.RDCooking.Items.Meals.Stove;

namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Stove
{
    [RequiresSkill(typeof(AdvancedCookingSkill), 6)]
    [Ecopedia("Jumbalaya", "Cooking", subPageName: "Jumbalaya Item")]
    public partial class JumbalayaRecipe : RecipeFamily
    {
        public JumbalayaRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Jumbalaya", 
                displayName: Localizer.DoStr("Jumbalaya"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(CharredSausageItem), 3, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(BeansItem), 10, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(TomatoItem), 5, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(MeatStockItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<JumbalayaItem>(2)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4;
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(AdvancedCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(JumbalayaRecipe), start: 2.0f, skillType: typeof(AdvancedCookingSkill), typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Jumbalaya"), recipeType: typeof(JumbalayaRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(StoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

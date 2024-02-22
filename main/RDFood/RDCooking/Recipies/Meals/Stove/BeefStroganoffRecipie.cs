namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Stove
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDCooking.Items.Ingredients.CastIronStove;
    using RD.Framework.main.RDFood.RDCooking.Items.Meals.Stove;

    [RequiresSkill(typeof(AdvancedCookingSkill), 4)]
    [Ecopedia("Food", "RDFoods", subPageName: "Beef Stroganoff")]
    public partial class BeefStroganoffRecipe : RecipeFamily
    {
        public BeefStroganoffRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BeefStroganoff",
                displayName: Localizer.DoStr("Beef Stroganoff"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(ScrapMeatItem), 8, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(MeatStockItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement("Fungus", 8, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(PastaNoodleItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BeefStroganoffItem>(1)
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 4;
            LaborInCalories = CreateLaborInCaloriesValue(45, typeof(AdvancedCookingSkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BeefStroganoffRecipe), start: 3.5f, skillType: typeof(AdvancedCookingSkill), typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Beef Stroganoff"), recipeType: typeof(BeefStroganoffRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(StoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

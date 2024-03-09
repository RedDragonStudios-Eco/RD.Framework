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
    using RD.Framework.main.RDFood.RDCooking.Items.Meals.Stove;
    using RD.Framework.main.RDFood.RDRanching.Ingredients;
    using RD.Framework.main.RDFood.RDButcher.Items.RDRanching;

    [RequiresSkill(typeof(CookingSkill), 3)]
    [Ecopedia("Food", "RDFoods", subPageName: "BBQ Chicken Wing")]
    public partial class BBQChickenWingRecipe : RecipeFamily
    {
        public BBQChickenWingRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BBQChickenWing", 
                displayName: Localizer.DoStr("BBQ Chicken Wing"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawChickenWingItem), 3, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement(typeof(EggItem), 2, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement(typeof(TomatoItem), 2, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement("Oil", 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BBQChickenWingItem>(3)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3;
            this.LaborInCalories = CreateLaborInCaloriesValue(65, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BBQChickenWingRecipe), start: 2.0f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("BBQ Chicken Wing"), recipeType: typeof(BBQChickenWingRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(StoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

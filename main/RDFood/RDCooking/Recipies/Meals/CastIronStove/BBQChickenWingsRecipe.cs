namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.CastIronStove
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
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 3;
            LaborInCalories = CreateLaborInCaloriesValue(65, typeof(CookingSkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BBQChickenWingRecipe), start: 2.0f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("BBQ Chicken Wing"), recipeType: typeof(BBQChickenWingRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

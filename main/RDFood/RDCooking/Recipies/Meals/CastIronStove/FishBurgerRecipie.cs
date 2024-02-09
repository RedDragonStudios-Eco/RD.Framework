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
    using RD.Framework.main.RDFood.RDCooking.Items.Meals.CastIronStove;

    [RequiresSkill(typeof(CookingSkill), 5)]
    [Ecopedia("FishBurger", "Cooking", subPageName: "Fish Burger Item")]
    public partial class FishBurgerRecipe : RecipeFamily
    {
        public FishBurgerRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "FishBurger",  
                displayName: Localizer.DoStr("Fish Burger"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(CharredFishItem), 2, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement(typeof(BeetGreensItem), 3, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement(typeof(CamasBreadItem), 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement(typeof(TomatoItem), 2, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<FishBurgerItem>(2)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2f;
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(FishBurgerRecipe), start: 2.0f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Fish Burger"), recipeType: typeof(FishBurgerRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

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
    using RD.Framework.main.RDFood.RDCooking.Items.Ingredients.CastIronStove;

    [RequiresSkill(typeof(CookingSkill), 5)]
    [Ecopedia("Food", "RDFoods", subPageName: "Spaghetti and Meatballs")]
    public partial class SpaghettiandMeatballsRecipe : RecipeFamily
    {
        public SpaghettiandMeatballsRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Spaghetti and Meatballs",
                displayName: Localizer.DoStr("Spaghetti and Meatballs"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(MeatballItem), 5, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement(typeof(PastaNoodleItem), 2, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement(typeof(TomatoItem), 2, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SpaghettiandMeatballsItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3f;
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SpaghettiandMeatballsRecipe), start: 3.0f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Spaghetti and Meatballs"), recipeType: typeof(SpaghettiandMeatballsRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
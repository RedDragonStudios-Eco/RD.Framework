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
    using RD.Framework.main.RDFood.RDButcher.Items.RDFood;

    [RequiresSkill(typeof(CookingSkill), 4)]
    [Ecopedia("Food", "RDFoods", subPageName: "Meatball")]
    public partial class MeatballRecipe : RecipeFamily
    {
        public MeatballRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Meatball",
                displayName: Localizer.DoStr("Meatball"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawMeatballItem), 20, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                    new IngredientElement("Oil", 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<MeatballItem>(20)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1f;
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MeatballRecipe), start: 1f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Meatball"), recipeType: typeof(MeatballRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
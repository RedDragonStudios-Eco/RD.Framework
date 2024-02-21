namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Campfire
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
    [RequiresSkill(typeof(CampfireCookingSkill), 0)]
    public partial class CampfireAnimalLargeRecipe : RecipeFamily
    {
        public CampfireAnimalLargeRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CampfireAnimalLarge",
                displayName: Localizer.DoStr("Campfire Animal Large"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("Large Carcass", 1, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CharredMeatItem>(8),
                    new CraftingElement<TallowItem>(2),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 0.5f;
            this.LaborInCalories = CreateLaborInCaloriesValue(25, typeof(CampfireCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CampfireAnimalTinyRecipe), start: 4, skillType: typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Campfire Animal Large"), recipeType: typeof(CampfireAnimalLargeRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CampfireObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

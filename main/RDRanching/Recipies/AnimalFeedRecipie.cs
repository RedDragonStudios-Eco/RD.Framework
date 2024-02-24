namespace RD.Framework.main.RDRanching.Recipies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDRanching.Items;
    using Eco.Gameplay.Components;

    public partial class AnimalFeedRecipe : RecipeFamily
    {
        public AnimalFeedRecipe()
        {
            var recipe = new Recipe();
            recipe.Init("Animal Feed", displayName: Localizer.DoStr("Animal Feed"),
            ingredients: new List<IngredientElement>
            {
                new IngredientElement("Crop", 5, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent)),
                new IngredientElement("Grain", 5, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent)),
            },
            items: new List<CraftingElement>
            {
                new CraftingElement<AnimalFeedItem>(2)
            });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 0.6f;
            LaborInCalories = CreateLaborInCaloriesValue(30, typeof(FarmingSkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(AnimalFeedRecipe), start: 1.5f, skillType: typeof(FarmingSkill), typeof(FarmingFocusedSpeedTalent), typeof(FarmingParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Animal Feed"), recipeType: typeof(AnimalFeedRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(FarmersTableObject), recipe: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}



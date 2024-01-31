﻿using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using RD.Framework.main.RDRanching.Items;

namespace RD.Framework.main.RDRanching.Recipies
{
    public partial class AnimalFeedRecipe : RecipeFamily
    {
        public AnimalFeedRecipe()
        {
            var recipe = new Recipe();
            recipe.Init("Animal Feed", displayName: Localizer.DoStr("Animal Feed"),
            ingredients: new List<IngredientElement>
            {
                new IngredientElement("Crop", 5),
                new IngredientElement("Grain", 5),
            },
            items: new List<CraftingElement>
            {
                new CraftingElement<AnimalFeedItem>(2)
            });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 0.6f;
            CraftMinutes = CreateLaborInCaloriesValue(30, typeof(FarmingSkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(AnimalFeedRecipe), start: 1, skillType: typeof(FarmingSkill));

            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Animal Feed"), recipeType: typeof(AnimalFeedRecipe));
            ModsPostInitialize();
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}


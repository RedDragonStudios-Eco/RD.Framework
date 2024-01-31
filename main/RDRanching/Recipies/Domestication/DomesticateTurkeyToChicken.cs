﻿using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using RD.Framework.main.RDRanching.Items;
using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
using RD.Framework.main.RDRanching.Items.Animals.BabyAnimals;
using RD.Framework.main.RDRanching.Items.obj;

namespace RD.Framework.main.RDRanching.Recipies.Domestication
{
    [RequiresSkill(typeof(HuntingSkill), 1)]
    public partial class DomesticateTurkeyRecipe : RecipeFamily
    {
        public DomesticateTurkeyRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "DomesticateTurkey",
                displayName: Localizer.DoStr("Domesticate Turkey"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BabyTurkeyItem), 1, true),
                    new IngredientElement(typeof(AnimalFeedItem), 2, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ChickenItem>(1),
                });

            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3.0f; 
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(HuntingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(DomesticateTurkeyRecipe), start: .75f, skillType: typeof(HuntingSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Domesticate Turkey"), recipeType: typeof(DomesticateTurkeyRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(NurseryObject), recipe: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
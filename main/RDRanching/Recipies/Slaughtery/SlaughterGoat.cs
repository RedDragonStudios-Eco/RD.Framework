﻿
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
using RD.Framework.main.RDRanching.Items.Animals.Carcass;
using RD.Framework.main.RDRanching.Items.obj;
using RD.Framework.main.RDSkills.Ranching;

namespace RD.Framework.main.RDRanching.Recipies.Slaughtery
{
    [RequiresSkill(typeof(RancherSkill), 5)]
    [Ecopedia("Items", "Products", subPageName: "Slaughter Goat")]
    public partial class SlaughterGoatRecipe : RecipeFamily
    {
        public SlaughterGoatRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SlaughterGoat",  
                displayName: Localizer.DoStr("Slaughter Goat"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoatItem), 1, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GoatCarcassItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5; 
            this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SlaughterGoatRecipe), start: 1.0f, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Slaughter Goat"), recipeType: typeof(SlaughterGoatRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
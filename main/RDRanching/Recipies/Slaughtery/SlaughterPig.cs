﻿using Eco.Core.Items;
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
    [Ecopedia("Natural Resources", "Animal", subPageName: "Slaughter Pig")]
    public partial class SlaughterPigRecipe : RecipeFamily
    {
        public SlaughterPigRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SlaughterPig",
                displayName: Localizer.DoStr("Slaughter Pig"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PigItem), 1, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PigCarcassItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SlaughterPigRecipe), start: 1.0f, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Slaughter Pig"), recipeType: typeof(SlaughterPigRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}
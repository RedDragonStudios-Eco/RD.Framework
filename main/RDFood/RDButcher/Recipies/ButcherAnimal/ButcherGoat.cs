using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using RD.Framework.main.RDRanching.Items.Animals.Carcass;

namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcherAnimal
{
    [RequiresSkill(typeof(ButcherySkill), 3)]
    public partial class ButcherGoatRecipie : RecipeFamily
    {
        public ButcherGoatRecipie()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ButcherGoat",
                displayName: Localizer.DoStr("Butcher A Goat"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GoatCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(6),
                    new CraftingElement<ShornWoolItem>(2),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4;
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButcherGoatRecipie), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Butcher A Goat"), recipeType: typeof(ButcherGoatRecipie));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

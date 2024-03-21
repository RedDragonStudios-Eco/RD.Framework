namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcheringTable.ButcherAnimal
{
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
    using RD.Framework.main.RDFood.RDButcher.Items;
    using RD.Framework.main.RDRanching.Items.Animals.Carcass;

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
                    new CraftingElement<RawMeatItem>(3),
                    new CraftingElement<ScrapMeatItem>(2),
                    new CraftingElement<ShornWoolItem>(2),
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 4;
            LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButcherGoatRecipie), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Butcher A Goat"), recipeType: typeof(ButcherGoatRecipie));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

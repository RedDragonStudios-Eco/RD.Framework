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
    using RD.Framework.main.RDRanching.Items.Animals.Carcass;
    using RD.Framework.main.RDFood.RDButcher.Items.RDRanching;

    [RequiresSkill(typeof(ButcherySkill), 3)]
    public partial class ButcherSheepRecipie : RecipeFamily
    {
        public ButcherSheepRecipie()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ButchSheep",
                displayName: Localizer.DoStr("Butcher A Sheep"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SheepCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawMuttonItem>(6),
                    new CraftingElement<TallowItem>(2),
                    new CraftingElement<ShornWoolItem>(2),
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 4;
            LaborInCalories = CreateLaborInCaloriesValue(70, typeof(ButcherySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButcherSheepRecipie), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Butcher A Sheep"), recipeType: typeof(ButcherSheepRecipie));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

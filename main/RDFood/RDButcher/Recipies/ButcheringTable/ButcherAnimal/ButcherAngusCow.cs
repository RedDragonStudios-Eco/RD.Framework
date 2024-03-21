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

    [RequiresSkill(typeof(ButcherySkill), 4)]
    public partial class ButcherAngusCow : RecipeFamily
    {
        public ButcherAngusCow()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ButcherAngusCow",
                displayName: Localizer.DoStr("Butcher Angus Cow"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(AngusCowCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawAngusRoastItem>(2),
                    new CraftingElement<RawAngusSteakItem>(4),
                    new CraftingElement<RawBeefRibsItem>(2),
                    new CraftingElement<ScrapMeatItem>(2),
                    new CraftingElement<TallowItem>(1),
                    new CraftingElement<LeatherHideItem>(2),
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 4;
            LaborInCalories = CreateLaborInCaloriesValue(300, typeof(ButcherySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButcherAngusCow), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Butcher Angus Cow"), recipeType: typeof(ButcherAngusCow));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

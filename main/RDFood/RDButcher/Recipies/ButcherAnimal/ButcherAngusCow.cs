namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcherAnimal
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
                    new CraftingElement<RawAngusRoastItem>(4),
                    new CraftingElement<RawAngusSteakItem>(4),
                    new CraftingElement<RawBeefRibsItem>(4),
                    new CraftingElement<ScrapMeatItem>(6),
                    new CraftingElement<TallowItem>(4),
                    new CraftingElement<LeatherHideItem>(1),
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 4;
            LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill));
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

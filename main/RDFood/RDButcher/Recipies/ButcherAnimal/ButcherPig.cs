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

    [RequiresSkill(typeof(ButcherySkill), 3)]
    public partial class ButcherPigRecipe : RecipeFamily
    {
        public ButcherPigRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ButcherPig",  
                displayName: Localizer.DoStr("Butcher A Pig"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PigCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawPorkChopItem>(5),
                    new CraftingElement<RawPorkRoastItem>(6),
                    new CraftingElement<RawBaconItem>(5),
                    new CraftingElement<RawPorkButtItem>(2),
                    new CraftingElement<TallowItem>(4),
                    new CraftingElement<LeatherHideItem>(1),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4;
            this.LaborInCalories = CreateLaborInCaloriesValue(350, typeof(ButcherySkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButcherPigRecipe), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Butcher A Pig"), recipeType: typeof(ButcherPigRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

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
    using Eco.Core.Items;

    [RequiresSkill(typeof(ButcherySkill), 3)]
    [Ecopedia("Natural Resources", "Animal", subPageName: "Pig Carcass")]
    public partial class ButcherPigRecipe : RecipeFamily
    {
        public ButcherPigRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ButcherPigRecipe",
                displayName: Localizer.DoStr("Butcher Pig"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PigCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawPorkRoastItem>(3),
                    new CraftingElement<TallowItem>(1),
                    new CraftingElement<LeatherHideItem>(1),
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 4;
            LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButcherPigRecipe), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Butcher Pig"), recipeType: typeof(ButcherPigRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(ButcherySkill), 3)]
    public partial class ButcherPigRecipeB : Recipe
    {
        public ButcherPigRecipeB()
        {
            this.Init(
                name: "ButcherPigRecipeB",
                displayName: Localizer.DoStr("Butcher Pig Chops"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PigCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawPorkChopItem>(3),
                    new CraftingElement<TallowItem>(1),
                    new CraftingElement<LeatherHideItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ButcherPigRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(ButcherySkill), 3)]
    public partial class ButcherPigRecipeC : Recipe
    {
        public ButcherPigRecipeC()
        {
            this.Init(
                name: "ButcherPigRecipeC",
                displayName: Localizer.DoStr("Butcher Pig Butt"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PigCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawPorkButtItem>(2),
                    new CraftingElement<TallowItem>(1),
                    new CraftingElement<LeatherHideItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ButcherPigRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(ButcherySkill), 3)]
    public partial class ButcherPigRecipeD : Recipe
    {
        public ButcherPigRecipeD()
        {
            this.Init(
                name: "ButcherPigRecipeD",
                displayName: Localizer.DoStr("Butcher Pig Bacon"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PigCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawBaconItem>(4),
                    new CraftingElement<LeatherHideItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ButcherPigRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}

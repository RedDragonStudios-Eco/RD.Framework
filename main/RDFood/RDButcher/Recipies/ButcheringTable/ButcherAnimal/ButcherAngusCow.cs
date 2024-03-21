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
    using RD.Framework.main.RDFood.RDCooking.Recipies.Meals.CastIronStove;

    [RequiresSkill(typeof(ButcherySkill), 4)]
    [Ecopedia("Natural Resources", "Animal", subPageName: "Angus Cow Carcass")]
    public partial class ButcherAngusCowRecipe : RecipeFamily
    {
       public ButcherAngusCowRecipe()
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
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 4;
            LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButcherAngusCowRecipe), start: 1.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Butcher Angus Cow"), recipeType: typeof(ButcherAngusCowRecipe));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(ButcherySkill), 4)]
    public partial class ButcherAngusCowB : Recipe
    {
        public ButcherAngusCowB()
        {
            this.Init(
                name: "ButcherAngusCowB",
                displayName: Localizer.DoStr("Butcher Angus Cow Steaks"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(AngusCowCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawAngusSteakItem>(2),
                    new CraftingElement<TallowItem>(1),
                    new CraftingElement<LeatherHideItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ButcherAngusCowRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(ButcherySkill), 4)]
    public partial class ButcherAngusCowC : Recipe
    {
        public ButcherAngusCowC()
        {
            this.Init(
                name: "ButcherAngusCowC",
                displayName: Localizer.DoStr("Butcher Angus Cow Ribs"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(AngusCowCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawBeefRibsItem>(2),
                    new CraftingElement<TallowItem>(1),
                    new CraftingElement<LeatherHideItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ButcherAngusCowRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}

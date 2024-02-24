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
    using RD.Framework.main.RDUtil.Items;
    using RD.Framework.main.RDFood.RDButcher.Items.RDRanching;
    using Eco.Core.Items;

    [RequiresSkill(typeof(ButcherySkill), 2)]
    [Ecopedia("Natural Resources", "Animal", subPageName: "Chicken Carcass")]
    public partial class ButcherChickenRecipie : RecipeFamily
    {
        public ButcherChickenRecipie()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ButcherChicken",
                displayName: Localizer.DoStr("Butcher Chicken"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ChickenCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawChickenBreastItem>(2),
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 4;
            LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButcherChickenRecipie), start: 0.5f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Butcher Chicken"), recipeType: typeof(ButcherChickenRecipie));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(ButcherySkill), 2)]
    public partial class ButcherChickenRecipieB : Recipe
    {
        public ButcherChickenRecipieB()
        {
            this.Init(
                name: "ButcherChickenB",
                displayName: Localizer.DoStr("Butcher Chicken Wings"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(ChickenCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<RawChickenWingItem>(2),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ButcherChickenRecipie), this);
        }
        partial void ModsPostInitialize();
    }
}

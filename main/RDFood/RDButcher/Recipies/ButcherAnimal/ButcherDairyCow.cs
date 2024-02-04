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

namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcherAnimal
{
    [RequiresSkill(typeof(ButcherySkill), 4)]
    public partial class ButcherDairyCow : RecipeFamily
    {
        public ButcherDairyCow()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ButcherDairyCow",
                displayName: Localizer.DoStr("Butcher Dairy Cow"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(DairyCowCarcassItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(10),
                    new CraftingElement<LeatherHideItem>(1),
                });
            Recipes = new List<Recipe> { recipe };
            ExperienceOnCraft = 3;
            LaborInCalories = CreateLaborInCaloriesValue(50, typeof(ButcherySkill));
            CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ButcherDairyCow), start: 1.2f, skillType: typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));
            ModsPreInitialize();
            Initialize(displayText: Localizer.DoStr("Butcher Dairy Cow"), recipeType: typeof(ButcherDairyCow));
            ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(ButcheryTableObject), recipe: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

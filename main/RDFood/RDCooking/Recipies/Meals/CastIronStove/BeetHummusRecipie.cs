using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using RD.Framework.main.RDFood.RDCooking.Items.Meals.CastIronStove;

namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.CastIronStove
{
    [RequiresSkill(typeof(CookingSkill), 3)]
    [Ecopedia("Food", "Cooking", subPageName: "Beet Hummus Item")]
    public partial class BeetHummusRecipe : RecipeFamily
    {
        public BeetHummusRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BeetHummus",
                displayName: Localizer.DoStr("Beet Hummus"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(CharredBeetItem), 20, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                   new IngredientElement(typeof(OilItem), 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BeetHummusItem>(3)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2;
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BeetHummusRecipe), start: 1.0f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Beet Hummus"), recipeType: typeof(BeetHummusRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

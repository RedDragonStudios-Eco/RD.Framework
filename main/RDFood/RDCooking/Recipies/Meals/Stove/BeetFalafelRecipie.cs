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
using RD.Framework.main.RDFood.RDCooking.Items.Meals.Stove;

namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Stove
{
    [RequiresSkill(typeof(AdvancedCookingSkill), 3)]
    [Ecopedia("Food", "AdvancedCooking", subPageName: "Beet Falafel Item")]
    public partial class BeetFalafelRecipe : RecipeFamily
    {
        public BeetFalafelRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BeetFalafel",
                displayName: Localizer.DoStr("Beet Falafel"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(BeetHummusItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(FlatbreadItem), 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(BeetGreensItem), 4, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(FalafelItem), 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BeetFalafelItem>(4)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2;
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(AdvancedCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BeetFalafelRecipe), start: 1.0f, skillType: typeof(AdvancedCookingSkill), typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Beet Falafel"), recipeType: typeof(BeetFalafelRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(StoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

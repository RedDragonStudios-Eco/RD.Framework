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
using RD.Framework.main.RDFood.RDCooking.Items.Meals.Stove;

namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Stove
{
    [RequiresSkill(typeof(AdvancedCookingSkill), 4)]
    [Ecopedia("SeaUrchinPasta", "Cooking", subPageName: "Sea Urchin Pasta Item")]
    public partial class SeaUrchinPastaRecipe : RecipeFamily
    {
        public SeaUrchinPastaRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SeaUrchinPasta",
                displayName: Localizer.DoStr("Sea Urchin Pasta"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(RiceNoodlesItem), 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(SunCheeseItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(UrchinItem), 5, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   //new IngredientElement(typeof(WineItem), 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(OilItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SeaUrchinPastaItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(AdvancedCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SeaUrchinPastaRecipe), start: 2.0f, skillType: typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Sea Urchin Pasta"), recipeType: typeof(SeaUrchinPastaRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(StoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

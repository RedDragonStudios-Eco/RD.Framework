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
using RD.Framework.main.RDFood.RDCooking.Items.Meals.Kitchen;

namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Kitchen
{
    [RequiresSkill(typeof(AdvancedCookingSkill), 4)]
    [Ecopedia("Food", "Cooking", subPageName: "Beef Stroganoff Item")]
    public partial class BeefStroganoffRecipe : RecipeFamily
    {
        public BeefStroganoffRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "BeefStroganoff",
                displayName: Localizer.DoStr("Beef Stroganoff"),
                ingredients: new List<IngredientElement>
                {
                   new IngredientElement(typeof(ScrapMeatItem), 10, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(MeatStockItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement("Fungus", 20, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(RiceNoodlesItem), 1, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BeefStroganoffItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 4;
            this.LaborInCalories = CreateLaborInCaloriesValue(45, typeof(AdvancedCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(BeefStroganoffRecipe), start: 3.5f, skillType: typeof(AdvancedCookingSkill), typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Beef Stroganoff"), recipeType: typeof(BeefStroganoffRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(KitchenObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

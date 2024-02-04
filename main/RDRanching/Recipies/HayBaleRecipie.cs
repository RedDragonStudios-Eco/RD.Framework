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
using RD.Framework.main.RDRanching.Items;

namespace RD.Framework.main.RDRanching.Recipies
{
    [RequiresSkill(typeof(FarmingSkill), 4)]
    [Ecopedia("Items", "Products", subPageName: "Hay Bale Item")]
    public partial class HayBaleRecipe : RecipeFamily
    {
        public HayBaleRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "Hay Bale",
                displayName: Localizer.DoStr("Hay Bale"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(("NaturalFiber"), 10, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent))
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<HayBaleItem>(2)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 1;
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(FarmingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(HayBaleRecipe), start: 1.2f, skillType: typeof(FarmingSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Hay Bale"), recipeType: typeof(HayBaleRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(FarmersTableObject), recipe: this);
        }
        partial void ModsPreInitialize();

        partial void ModsPostInitialize();
    }
}

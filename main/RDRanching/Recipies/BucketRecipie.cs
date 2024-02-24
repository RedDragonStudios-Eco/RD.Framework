namespace RD.Framework.main.RDRanching.Recipies
{
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

    [RequiresSkill(typeof(CarpentrySkill), 4)]
    [Ecopedia("Items", "Products", subPageName: "Wood Bucket")]
    public partial class CraftWoodBucketRecipe : RecipeFamily
    {
        public CraftWoodBucketRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CraftWoodBucket",
                displayName: Localizer.DoStr("Craft Wood Bucket"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BoardItem), 5, true),
                    new IngredientElement(typeof(IronBarItem), 1, typeof(CarpenterSkill), typeof(CarpentryLavishResourcesTalent)), 
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<BucketItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(CarpentrySkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CraftWoodBucketRecipe), start: 1.5f, skillType: typeof(CarpentrySkill), typeof(CarpentryFocusedSpeedTalent),typeof(CarpentryParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Craft Wood Bucket"), recipeType: typeof(CraftWoodBucketRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CarpentryTableObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

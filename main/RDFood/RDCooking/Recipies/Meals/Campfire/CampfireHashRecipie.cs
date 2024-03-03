namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Campfire
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
    using RD.Framework.main.RDFood.RDCooking.Items.Meals.Campfire;

    [RequiresSkill(typeof(CampfireCookingSkill), 3)]
    [Ecopedia("Food", "RDFoods", subPageName: "Campfire Hash")]
    public partial class CampfireHashRecipe : RecipeFamily
    {
        public CampfireHashRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CampfireHash",
                displayName: Localizer.DoStr("Campfire Hash"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(TaroRootItem), 2, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(RawSausageItem), 1, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(RawBaconItem), 1, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CampfireHashItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3f;
            this.LaborInCalories = CreateLaborInCaloriesValue(45, typeof(CampfireCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CampfireHashRecipe), start: 3.0f, skillType: typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Campfire Hash"), recipeType: typeof(CampfireHashRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CampfireObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
 }
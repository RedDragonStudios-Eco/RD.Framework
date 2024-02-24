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

    [RequiresSkill(typeof(CampfireCookingSkill), 6)]
    [Ecopedia("Food", "Cooking", subPageName: "Mushroom Stew")]
    public partial class MushroomStewRecipe : RecipeFamily
    {
        public MushroomStewRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MushroomStew",
                displayName: Localizer.DoStr("Mushroom Stew"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BoleteMushroomsItem), 6, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(CriminiMushroomsItem), 6, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(WiltedFiddleheadsItem), 2, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                    new IngredientElement("Fat", 1, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<MushroomStewItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2f;
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CampfireCookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MushroomStewRecipe), start: 4.0f, skillType: typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Mushroom Stew"), recipeType: typeof(MushroomStewRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CampfireObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
 }
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
 
 namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Campfire
 {

 [RequiresSkill(typeof(CampfireCookingSkill), 6)]
    [Ecopedia("Food", "Cooking", subPageName: "Mushroom Stew")]
    public partial class MushroomStewRecipe : RecipeFamily
    {
        public MushroomStewRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "MushroomStew",  //noloc
                displayName: Localizer.DoStr("Mushroom Stew"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BoleteMushroomItem), 6, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(CriminiMushroomItem), 6, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(WiltedFiddleheadItem), 2, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                    new IngredientElement(typeof(TallowItem), 1, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<MushroomStewItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CampfireCookingSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(MushroomStewRecipe), start: 4.0f, skillType: typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Baked Beans"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Mushroom Stew"), recipeType: typeof(MushroomStewRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(CampfireObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
 }
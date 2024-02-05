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
    [Ecopedia("Food", "Cooking", subPageName: "Forest Chicken Gyro")]
    public partial class ForestChickenGyroRecipe : RecipeFamily
    {
        public ForestChickenGyroRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "ForestChickenGyro",  //noloc
                displayName: Localizer.DoStr("Forest Chicken Gyro"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(GrilledChickenItem), 2, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(FiddleheadItem), 3, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(BannockItem), 1, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                  },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<ForestChickenGyroItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 2.5; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CampfireCookingSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ForestChickenGyroRecipe), start: 3.0f, skillType: typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Baked Beans"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Forest Chicken Gyro"), recipeType: typeof(ForestChickenGyroRecipe));
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
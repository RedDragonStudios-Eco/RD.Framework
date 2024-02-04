 [RequiresSkill(typeof(CookingSkill), 3)]
    [Ecopedia("Food", "Cooking", subPageName: "Campfire Hash")]
    public partial class CampfireHashRecipe : RecipeFamily
    {
        public CampfireHashRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CampfireHash",  //noloc
                displayName: Localizer.DoStr("Campfire Hash"),

                // Defines the ingredients needed to craft this recipe. An ingredient items takes the following inputs
                // type of the item, the amount of the item, the skill required, and the talent used.
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(TaroRootItem), 2, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(RawSausageItem), 1, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                   new IngredientElement(typeof(RawBaconItem), 1, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                },

                // Define our recipe output items.
                // For every output item there needs to be one CraftingElement entry with the type of the final item and the amount
                // to create.
                items: new List<CraftingElement>
                {
                    new CraftingElement<CampfireHashItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3; // Defines how much experience is gained when crafted.
            
            // Defines the amount of labor required and the required skill to add labor
            this.LaborInCalories = CreateLaborInCaloriesValue(45, typeof(CampfireCookingSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CampfireHashRecipe), start: 3.0f, skillType: typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));

            // Perform pre/post initialization for user mods and initialize our recipe instance with the display name "Baked Beans"
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Campfire Hash"), recipeType: typeof(CampfireHashRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(CampfireObject), recipe: this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();

        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
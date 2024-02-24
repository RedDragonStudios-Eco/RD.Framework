namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.CastIronStove
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    [RequiresSkill(typeof(CookingSkill), 4)]
    [Ecopedia("Food", "Charred Food", subPageName: "Charred Fish Item")]
    public partial class CharredFishCastIronRecipe : RecipeFamily
    {
        public CharredFishCastIronRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CharredFishCastIron",
                displayName: Localizer.DoStr("Cast Iron Stove Charred Fish "),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawFishItem), 1, typeof(CookingSkill),typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CharredFishItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 0.5f;
            this.LaborInCalories = CreateLaborInCaloriesValue(15, typeof(CookingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(CharredFishCastIronRecipe), start: 1f, skillType: typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Charred Fish"), recipeType: typeof(CharredFishCastIronRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(CastIronStoveObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(CookingSkill), 4)]
    public partial class CastIronFishLargeRecipe : Recipe
    {
        public CastIronFishLargeRecipe()
        {
            this.Init(
                name: "CastIronFishLarge",
                displayName: Localizer.DoStr("Cast Iron Stove Fish Large"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("LargeFish", 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)), 
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CharredFishItem>(5),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(CastIronStoveObject), typeof(CharredFishCastIronRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(CookingSkill), 4)]
    public partial class CastIronFishMediumRecipe : Recipe
    {
        public CastIronFishMediumRecipe()
        {
            this.Init(
                name: "CastIronFishMedium",
                displayName: Localizer.DoStr("Cast Iron Stove Fish Medium"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("MediumFish", 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CharredFishItem>(2),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(CastIronStoveObject), typeof(CharredFishCastIronRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(CookingSkill), 4)]
    public partial class CastIronFishSmallRecipe : Recipe
    {
        public CastIronFishSmallRecipe()
        {
            this.Init(
                name: "CastIronFishSmall",
                displayName: Localizer.DoStr("Cast Iron Stove Fish Small"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement("SmallFish", 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CharredFishItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(CastIronStoveObject), typeof(CharredFishCastIronRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(CookingSkill), 4)]
    public partial class CastIronFishSardineRecipe : Recipe
    {
        public CastIronFishSardineRecipe()
        {
            this.Init(
                name: "CastIronFishSardine",
                displayName: Localizer.DoStr("Cast Iron Stove Fish Sardine"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(PacificSardineItem), 3, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CharredFishItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(CastIronStoveObject), typeof(CharredFishCastIronRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}

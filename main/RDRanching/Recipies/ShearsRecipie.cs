
namespace RD.Framework.main.RDRanching.Recipies
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Settlements;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Core.Controller;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Mods.TechTree;
    using RD.Framework.main.RDRanching.Items;

    [RequiresSkill(typeof(SmeltingSkill), 2)]
    [Ecopedia("Items", "Products", subPageName: "Shears Item")]
    public partial class ShearsRecipe : RecipeFamily
    {
        public ShearsRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "CraftSheers",  //noloc
                displayName: Localizer.DoStr("Craft Sheers"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(IronBarItem), 2, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ShearItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5;
            this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(SmeltingSkill));

            // Defines our crafting time for the recipe
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(ShearsRecipe), start: 0.5f, skillType: typeof(SmeltingSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Craft Shears"), recipeType: typeof(ShearsRecipe));
            this.ModsPostInitialize();

            // Register our RecipeFamily instance with the crafting system so it can be crafted.
            CraftingComponent.AddRecipe(tableType: typeof(BloomeryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

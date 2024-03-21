namespace RD.Framework.main.RDRanching.Recipies.Domestication
{
    using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDRanching.Items;
    using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
    using RD.Framework.main.RDRanching.Items.Animals.BabyAnimals;
    using RD.Framework.main.RDRanching.Items.Objects;

    [RequiresSkill(typeof(HuntingSkill), 3)]
    public partial class DomesticateBighornSheepRecipe : RecipeFamily
    {
        public DomesticateBighornSheepRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "DomesticateBighornSheep", 
                displayName: Localizer.DoStr("Domesticate BighornSheep"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BabyBighornSheepItem), 1, true),
                    new IngredientElement(typeof(AnimalFeedItem), 5, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SheepItem>(1),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f;
            this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(HuntingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(DomesticateBighornSheepRecipe), start: 1.5f, skillType: typeof(HuntingSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Domesticate Bighorn Sheep"), recipeType: typeof(DomesticateBighornSheepRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(NurseryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

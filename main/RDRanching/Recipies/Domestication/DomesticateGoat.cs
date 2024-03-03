
namespace RD.Framework.main.RDRanching.Recipies.Domestication
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
    using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
    using RD.Framework.main.RDRanching.Items.Animals.BabyAnimals;
    using RD.Framework.main.RDRanching.Items.Objects;

    [RequiresSkill(typeof(HuntingSkill), 1)]
    public partial class DomesticateMountainGoatRecipe : RecipeFamily
    {
        public DomesticateMountainGoatRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "DomesticateMountainGoat",  
                displayName: Localizer.DoStr("Domesticate Mountain Goat"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BabyMountainGoatItem), 1, true),
                    new IngredientElement(typeof(AnimalFeedItem), 5, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<GoatItem>(1),
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5.0f; 
            this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(HuntingSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(DomesticateMountainGoatRecipe), start: 1.5f, skillType: typeof(HuntingSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Domesticate Mountain Goat"), recipeType: typeof(DomesticateMountainGoatRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(NurseryObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

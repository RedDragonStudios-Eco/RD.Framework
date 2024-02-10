using System;
using System.Collections.Generic;

namespace RD.Framework.main.RDRanching.Recipies.Domestication
{
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDRanching.Items;
    using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
    using RD.Framework.main.RDRanching.Items.Animals.BabyAnimals;
    using RD.Framework.main.RDRanching.Items.obj;
    using RD.Framework.main.RDSkills.Ranching;
    using Eco.Core.Items;

    [RequiresSkill(typeof(HuntingSkill), 1)]
    [Ecopedia("Items", "Products", subPageName: "Chicken")]
    public partial class DomesticateTurkeyRecipe : RecipeFamily
    {
        public DomesticateTurkeyRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "DomesticateTurkey",
                displayName: Localizer.DoStr("Domesticate Turkey"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(BabyTurkeyItem), 1, true),
                    new IngredientElement(typeof(AnimalFeedItem), 2, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ChickenItem>(1),
                });

            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 3.0f; 
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(DomesticateTurkeyRecipe), start: .75f, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Domesticate Turkey"), recipeType: typeof(DomesticateTurkeyRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(NurseryObject), recipe: this);
        }

        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

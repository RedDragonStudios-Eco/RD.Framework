
namespace RD.Framework.main.RDRanching.Recipies.Slaughtery
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
    using Eco.Shared.Localization;
    using RD.Framework.main.RDRanching.Items.Animals.AdultAnimals;
    using RD.Framework.main.RDRanching.Items.Animals.Carcass;
    using RD.Framework.main.RDRanching.Items.obj;
    using RD.Framework.main.RDSkills.Ranching;

    [RequiresSkill(typeof(RancherSkill), 5)]
    [Ecopedia("Natural Resources", "Animal", subPageName: "Sheep Carcass")]
    public partial class SlaughterSheepRecipe : RecipeFamily
    {
        public SlaughterSheepRecipe()
        {
            var recipe = new Recipe();
            recipe.Init(
                name: "SlaughterSheep",  
                displayName: Localizer.DoStr("Slaughter Sheep"),


                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(SheepItem), 1, true),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<SheepCarcassItem>(1)
                });
            this.Recipes = new List<Recipe> { recipe };
            this.ExperienceOnCraft = 5; 
            this.LaborInCalories = CreateLaborInCaloriesValue(70, typeof(RancherSkill));
            this.CraftMinutes = CreateCraftTimeValue(beneficiary: typeof(SlaughterSheepRecipe), start: 1.0f, skillType: typeof(RancherSkill));
            this.ModsPreInitialize();
            this.Initialize(displayText: Localizer.DoStr("Slaughter Sheep"), recipeType: typeof(SlaughterSheepRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(tableType: typeof(BarnObject), recipe: this);
        }
        partial void ModsPreInitialize();
        partial void ModsPostInitialize();
    }
}

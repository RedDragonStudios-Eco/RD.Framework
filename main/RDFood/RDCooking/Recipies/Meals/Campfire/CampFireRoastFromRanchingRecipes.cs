namespace RD.Framework.main.RDFood.RDCooking.Recipies.Meals.Campfire
{
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDButcher.Items.RDRanching;

    [RequiresSkill(typeof(CampfireCookingSkill), 2)]
    public partial class CampFireAngusRoastRecipe : Recipe
    {
        public CampFireAngusRoastRecipe()
        {
            this.Init(
                name: "CampFireAngusRoast",
                displayName: Localizer.DoStr("Campfire Roast From Angus Roast"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawAngusRoastItem), 1, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CampfireRoastItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(CampfireObject), typeof(CampfireRoastRecipe), this);
        }
        partial void ModsPostInitialize();
    }

    [RequiresSkill(typeof(CampfireCookingSkill), 2)]
    public partial class CampFirePorkRoastRecipe : Recipe
    {
        public CampFirePorkRoastRecipe()
        {
            this.Init(
                name: "CampFirePorkRoast",
                displayName: Localizer.DoStr("Campfire Roast From Pork Roast"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawPorkRoastItem), 1, typeof(CampfireCookingSkill), typeof(CampfireCookingLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<CampfireRoastItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(CampfireObject), typeof(CampfireRoastRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}

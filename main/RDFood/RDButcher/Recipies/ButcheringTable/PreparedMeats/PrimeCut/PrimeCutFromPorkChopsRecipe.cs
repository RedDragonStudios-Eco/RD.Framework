namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcheringTable.PreparedMeats.PrimeCut
{
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDButcher.Items.RDRanching;

    [RequiresSkill(typeof(ButcherySkill), 6)]
    public partial class PrimeCutFromPorkChopsRecipe : Recipe
    {
        public PrimeCutFromPorkChopsRecipe()
        {
            this.Init(
                name: "PrimeCutPorkChop",
                displayName: Localizer.DoStr("Prime Cut From pork Chops"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawPorkChopItem), 16, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<PrimeCutItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(PrimeCutRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}

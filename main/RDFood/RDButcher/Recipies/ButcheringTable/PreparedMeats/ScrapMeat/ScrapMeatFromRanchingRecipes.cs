namespace RD.Framework.main.RDFood.RDButcher.Recipies.ButcheringTable.PreparedMeats.ScrapMeat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Items.Recipes;
    using Eco.Gameplay.Skills;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using RD.Framework.main.RDFood.RDButcher.Items.RDRanching;

    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class ScrapMeatFromAngusRoastRecipe : Recipe
    {
        public ScrapMeatFromAngusRoastRecipe()
        {
            this.Init(
                name: "ScrapMeatRecipeA",
                displayName: Localizer.DoStr("Scrap Meat From Angus Roast"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawAngusRoastItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(6),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ScrapMeatRecipe), this);
        }
        partial void ModsPostInitialize();
    }
    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class ScrapMeatFromAngusSteakRecipe : Recipe
    {
        public ScrapMeatFromAngusSteakRecipe()
        {
            this.Init(
                name: "ScrapMeatRecipeB",
                displayName: Localizer.DoStr("Scrap Meat From Angus Steak"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawAngusSteakItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(3),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ScrapMeatRecipe), this);
        }
        partial void ModsPostInitialize();
    }
    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class ScrapMeatFromBeefRibsRecipe : Recipe
    {
        public ScrapMeatFromBeefRibsRecipe()
        {
            this.Init(
                name: "ScrapMeatRecipeC",
                displayName: Localizer.DoStr("Scrap Meat From Beef Ribs"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawBeefRibsItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(1.5f),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ScrapMeatRecipe), this);
        }
        partial void ModsPostInitialize();
    }
    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class ScrapMeatFromChickenBreastRecipe : Recipe
    {
        public ScrapMeatFromChickenBreastRecipe()
        {
            this.Init(
                name: "ScrapMeatRecipeD",
                displayName: Localizer.DoStr("Scrap Meat From Chicken Breast"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawChickenBreastItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(1),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ScrapMeatRecipe), this);
        }
        partial void ModsPostInitialize();
    }
    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class ScrapMeatFromRawMuttonRecipe : Recipe
    {
        public ScrapMeatFromRawMuttonRecipe()
        {
            this.Init(
                name: "ScrapMeatRecipeE",
                displayName: Localizer.DoStr("Scrap Meat From Raw Mutton"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawMuttonItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(3),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ScrapMeatRecipe), this);
        }
        partial void ModsPostInitialize();
    }
    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class ScrapMeatFromPorkButtRecipe : Recipe
    {
        public ScrapMeatFromPorkButtRecipe()
        {
            this.Init(
                name: "ScrapMeatRecipeF",
                displayName: Localizer.DoStr("Scrap Meat From Pork Butt"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawPorkButtItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(9),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ScrapMeatRecipe), this);
        }
        partial void ModsPostInitialize();
    }
    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class ScrapMeatFromPorkChopRecipe : Recipe
    {
        public ScrapMeatFromPorkChopRecipe()
        {
            this.Init(
                name: "ScrapMeatRecipeG",
                displayName: Localizer.DoStr("Scrap Meat From Pork Chop"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawPorkChopItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(3),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ScrapMeatRecipe), this);
        }
        partial void ModsPostInitialize();
    }
    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class ScrapMeatFromPorkRoastRecipe : Recipe
    {
        public ScrapMeatFromPorkRoastRecipe()
        {
            this.Init(
                name: "ScrapMeatRecipeH",
                displayName: Localizer.DoStr("Scrap Meat From Pork Roast"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawPorkRoastItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(6),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ScrapMeatRecipe), this);
        }
        partial void ModsPostInitialize();
    }
    [RequiresSkill(typeof(ButcherySkill), 1)]
    public partial class ScrapMeatFromRawRabbitRecipe : Recipe
    {
        public ScrapMeatFromRawRabbitRecipe()
        {
            this.Init(
                name: "ScrapMeatRecipeI",
                displayName: Localizer.DoStr("Scrap Meat From Raw Rabbit"),
                ingredients: new List<IngredientElement>
                {
                    new IngredientElement(typeof(RawRabbitMeatItem), 1, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),
                },
                items: new List<CraftingElement>
                {
                    new CraftingElement<ScrapMeatItem>(3),
                });
            this.ModsPostInitialize();
            CraftingComponent.AddTagProduct(typeof(ButcheryTableObject), typeof(ScrapMeatRecipe), this);
        }
        partial void ModsPostInitialize();
    }
}

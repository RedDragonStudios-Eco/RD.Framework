namespace RD.Framework.API.Helpers
{
    using Eco.Core.Plugins.Interfaces;
    using Eco.Mods.TechTree;
    using Eco.Simulation.Types;
    using Range = Eco.Shared.Math.Range;
    using RD.Framework.main.RDRanching.Items.Animals.BabyAnimals;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using static Eco.Mods.TechTree.BighornSheep;
    using static Eco.Mods.TechTree.Bison;
    using static Eco.Mods.TechTree.MountainGoat;
    using static Eco.Mods.TechTree.Turkey;
    using static Eco.Mods.TechTree.Agouti;
    using static Eco.Mods.TechTree.Hare;
    using static Eco.Mods.TechTree.PrairieDog;
    public class FarmingBasePlugin : IModKitPlugin, IModInit
    {
        public string GetStatus()
        {
            return "RD Ranching - Adding Baby Animals to The Adult Animals";
        }

        public static void Initialize()
        {
            var bindings = BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic;

            var bisonSpecies = typeof(Bison).GetField("species", bindings).GetValue(typeof(Bison)) as BisonSpecies;
            var list = bisonSpecies.GetType().GetProperty("ResourceList", bindings).GetValue(bisonSpecies) as List<SpeciesResource>;
            list.Add(new SpeciesResource(typeof(BabyBisonItem), new Range(0, 2), 0.1f));

            var mGoatSpecies = typeof(MountainGoat).GetField("species", bindings).GetValue(typeof(MountainGoat)) as MountainGoatSpecies;
            var mlist = mGoatSpecies.GetType().GetProperty("ResourceList", bindings).GetValue(mGoatSpecies) as List<SpeciesResource>;
            mlist.Add(new SpeciesResource(typeof(BabyMountainGoatItem), new Range(0, 2), 0.1f));

            var bHornSpecies = typeof(BighornSheep).GetField("species", bindings).GetValue(typeof(BighornSheep)) as BighornSheepSpecies;
            var bHornList = bHornSpecies.GetType().GetProperty("ResourceList", bindings).GetValue(bHornSpecies) as List<SpeciesResource>;
            bHornList.Add(new SpeciesResource(typeof(BabyBighornSheepItem), new Range(0, 2), 0.1f));

            var turkeySpecies = typeof(Turkey).GetField("species", bindings).GetValue(typeof(Turkey)) as TurkeySpecies;
            var turkeyList = turkeySpecies.GetType().GetProperty("ResourceList", bindings).GetValue(turkeySpecies) as List<SpeciesResource>;
            turkeyList.Add(new SpeciesResource(typeof(BabyTurkeyItem), new Range(0, 3), 0.1f));

            var agoutiSpecies = typeof(Agouti).GetField("species", bindings).GetValue(typeof(Agouti)) as AgoutiSpecies;
            var agoutiList = agoutiSpecies.GetType().GetProperty("ResourceList", bindings).GetValue(agoutiSpecies) as List<SpeciesResource>;
            agoutiList.Add(new SpeciesResource(typeof(BabyAgoutiItem), new Range(0, 3), 0.1f));

            var hareSpecies = typeof(Hare).GetField("species", bindings).GetValue(typeof(Hare)) as HareSpecies;
            var hareList = hareSpecies.GetType().GetProperty("ResourceList", bindings).GetValue(hareSpecies) as List<SpeciesResource>;
            hareList.Add(new SpeciesResource(typeof(BabyHareItem), new Range(0, 3), 0.1f));

            var prairieDogSpecies = typeof(PrairieDog).GetField("species", bindings).GetValue(typeof(PrairieDog)) as PrairieDogSpecies;
            var prairieDogList = prairieDogSpecies.GetType().GetProperty("ResourceList", bindings).GetValue(prairieDogSpecies) as List<SpeciesResource>;
            prairieDogList.Add(new SpeciesResource(typeof(BabyPrairieDogItem), new Range(0, 3), 0.1f));


            //ConsoleColors.PrintConsoleMultiColored("[EM Farming]", System.ConsoleColor.Magenta, " Added Baby Animals: Bison, Mountain Goat, Bighorn Sheep", System.ConsoleColor.White);

        }

        public override string ToString() => "EM Farming";

        public string GetCategory() => "Natural Resources";

    }
}

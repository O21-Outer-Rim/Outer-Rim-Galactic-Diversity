using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace OuterRimDiversity
{
    public class OuterRimDiversityMod : Mod
    {
        public static OuterRimDiversityMod mod;

        internal static string VersionDir => Path.Combine(mod.Content.ModMetaData.RootDir.FullName, "Version.txt");
        public static string CurrentVersion { get; private set; }

        public OuterRimDiversityMod(ModContentPack content) : base(content)
        {
            mod = this;

            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            CurrentVersion = $"{version.Major}.{version.Minor}.{version.Build}";

            LogUtil.LogMessage($"{CurrentVersion} ::");

            File.WriteAllText(VersionDir, CurrentVersion);

            Harmony harmony = new Harmony("Neronix17.OuterRimDiversity.RimWorld");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

        //public override string SettingsCategory() => "Outer Rim - Galactic Diversity";

        //public override void DoSettingsWindowContents(Rect inRect)
        //{
        //    base.DoSettingsWindowContents(inRect);
        //}
    }
}

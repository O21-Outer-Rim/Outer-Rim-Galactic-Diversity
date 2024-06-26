﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

using HarmonyLib;

namespace OuterRimDiversity
{
    [HarmonyPatch(typeof(PawnCapacityWorker_Sight), "CalculateCapacityLevel")]
    public static class Patch_PawnCapacityWorker_Sight_CalculateCapacityLevel
    {
        [HarmonyPostfix]
        public static void Postfix(ref float __result, HediffSet diffSet, List<PawnCapacityUtility.CapacityImpactor> impactors = null)
        {
            if (diffSet?.pawn?.genes?.HasGene(ORDivDefOf.OuterRim_ForceSight) ?? false && __result < 1f)
            {
                __result = 1f;
            }
        }
    }
}

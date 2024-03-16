using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace OuterRimDiversity
{
    [DefOf]
    public static class ORDivDefOf
    {
        static ORDivDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ORDivDefOf));
        }

        public static GeneDef OuterRim_ForceSight;

        public static HediffDef OuterRim_VestigialEye;

        public static HediffDef OuterRim_Vestigial;
    }
}

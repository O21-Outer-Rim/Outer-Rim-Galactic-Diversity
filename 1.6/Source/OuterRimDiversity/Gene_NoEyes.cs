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
    public class Gene_NoEyes : Gene
    {
        public override void PostAdd()
        {
            base.PostAdd();
            if (Active)
            {
                foreach (BodyPartRecord part in pawn.health.hediffSet.GetNotMissingParts())
                {
                    if(part.def == BodyPartDefOf.Eye)
                    {
                        Hediff_MissingPart hediff = (Hediff_MissingPart)HediffMaker.MakeHediff(ORDivDefOf.OuterRim_VestigialEye, pawn);
                        hediff.lastInjury = ORDivDefOf.OuterRim_Vestigial;
                        hediff.part = part;
                        hediff.IsFresh = false;
                        pawn.health.AddHediff(hediff);
                    }
                }
            }
        }
    }
}

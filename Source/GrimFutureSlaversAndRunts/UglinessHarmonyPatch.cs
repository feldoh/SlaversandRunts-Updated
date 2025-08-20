using HarmonyLib;
using RimWorld;
using Verse;

namespace SlaversAndRunts;

public static class UglinessHarmonyPatch
{
    [HarmonyPatch(typeof(ThoughtWorker_Ugly), "CurrentSocialStateInternal", typeof(Pawn), typeof(Pawn))]
    [HarmonyAfter("redmattis.betterprerequisites")]
    public static class ThoughtWorker_Ugly_Patch
    {
        public static void Postfix(ref ThoughtState __result, Pawn pawn, Pawn other)
        {
            if (!ModsConfig.BiotechActive ||
                !(pawn.genes?.HasActiveGene(SlaversAndRuntsDefOf.GrimFutureSlaversAndRunts_VekkarousChosen) ?? false) ||
                !(other.genes?.HasActiveGene(SlaversAndRuntsDefOf.GrimFutureSlaversAndRunts_VekkarousChosen) ?? false)) return;
            __result = ThoughtState.Inactive;
        }
    }
}

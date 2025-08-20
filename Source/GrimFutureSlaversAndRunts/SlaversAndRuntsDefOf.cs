using RimWorld;
using Verse;

namespace SlaversAndRunts;

[DefOf]
public static class SlaversAndRuntsDefOf
{
    public static GeneDef GrimFutureSlaversAndRunts_VekkarousChosen;

    static SlaversAndRuntsDefOf() => DefOfHelper.EnsureInitializedInCtor(typeof(SlaversAndRuntsDefOf));
}

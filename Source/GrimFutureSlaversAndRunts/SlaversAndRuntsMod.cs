using HarmonyLib;
using Verse;

namespace SlaversAndRunts;

public class SlaversAndRuntsMod : Mod
{
    public SlaversAndRuntsMod(ModContentPack content) : base(content)
    {
#if DEBUG
        Harmony.DEBUG = true;
#endif

        Harmony harmony = new Harmony("GrimFuturesSlaversAndRunts.Mod");
        harmony.PatchAll();
    }
}

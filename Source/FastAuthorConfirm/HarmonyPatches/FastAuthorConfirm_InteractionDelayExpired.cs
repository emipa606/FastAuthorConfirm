using HarmonyLib;
using Verse;

namespace FastAuthorConfirm.HarmonyPatches;

[HarmonyPatch(typeof(Dialog_MessageBox))]
[HarmonyPatch("InteractionDelayExpired", MethodType.Getter)]
public static class FastAuthorConfirm_InteractionDelayExpired
{
    public static bool Prefix(ref bool __result)
    {
        __result = true;
        return false;
    }
}
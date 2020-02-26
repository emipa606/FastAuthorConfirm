using Verse;
using HarmonyLib;

namespace FastAuthorConfirm.HarmonyPatches
{
    [HarmonyPatch(typeof(Dialog_MessageBox))]
    [HarmonyPatch("InteractionDelayExpired", MethodType.Getter)]
    public static class FastAuthorConfirm_InteractionDelayExpired
    {
        public static bool Prefix(ref bool __result, ref Dialog_MessageBox __instance)
        {
            __result = true;
            return false;
        }
    }
}
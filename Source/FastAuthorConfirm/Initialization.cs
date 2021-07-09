using FastAuthorConfirm.HarmonyPatches;
using Verse;

namespace FastAuthorConfirm
{
    [StaticConstructorOnStartup]
    public static class Initialization
    {
        static Initialization()
        {
            HPatcher.Init();
        }
    }
}